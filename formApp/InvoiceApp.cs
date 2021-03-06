﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using iTextSharp.text;
using System.Linq;

// todo: generate .mdf file if missing with all tables and view

namespace formApp
{
    public partial class InvoiceApp : Form
    {
        #region variable declaration

        AutoCompleteStringCollection autoCompleteFirstName = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autoCompleteLastName = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autoCompletePhone = new AutoCompleteStringCollection();
        SqlConnection conn;
        ListViewItem items;
        List<ServiceItem> serviceList;

        #endregion

        #region constructor

        public InvoiceApp()
        {
            InitializeComponent();            
            items = new ListViewItem();
            serviceList = new List<ServiceItem>();
        }

        #endregion

        #region initialize

        private void Form1_Load(object sender, EventArgs e)
        {
            this.invoiceCustViewTableAdapter.Fill(this.applicationDatabase.InvoiceCustView);
            this.invoiceDetailsTableAdapter.Fill(this.applicationDatabase.InvoiceDetails);
            this.invoiceTableAdapter.Fill(this.applicationDatabase.Invoice);
            this.customerTableAdapter.Fill(this.applicationDatabase.Customer);

            invoiceTimePicker.CustomFormat = "MM/dd/yyyy   hh:mm tt";

            invoiceTextBoxInvoiceNumber.Text = getInvoiceId();

            items.Text = "Subtotal";
            items.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Bold);

            items.SubItems.Add("");
            items.SubItems.Add("0.00");
            serviceListView.Items.Add(items);

            List<String> firstNameList = new List<String>();
            List<String> lastNameList = new List<String>();
            List<String> phoneList = new List<String>();

            var query = from customer in this.applicationDatabase.Customer
                        select customer;

            foreach (var item in query)
            {
                firstNameList.Add(item.FirstName);
                lastNameList.Add(item.LastName);
                phoneList.Add(item.PhoneNumber.ToString());
            }

            invoiceTextBoxFirstName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            invoiceTextBoxFirstName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            autoCompleteFirstName.AddRange(firstNameList.ToArray());
            invoiceTextBoxFirstName.AutoCompleteCustomSource = autoCompleteFirstName;

            invoiceTextBoxLastName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            invoiceTextBoxLastName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            autoCompleteLastName.AddRange(lastNameList.ToArray());
            invoiceTextBoxLastName.AutoCompleteCustomSource = autoCompleteLastName;


            invoiceTextBoxPhone.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            invoiceTextBoxPhone.AutoCompleteSource = AutoCompleteSource.CustomSource;
            autoCompletePhone.AddRange(phoneList.ToArray());
            invoiceTextBoxPhone.AutoCompleteCustomSource = autoCompletePhone;  
        }

        #endregion

        #region click events

        private void addServiceButton_Click(object sender, EventArgs e)
        {

            addServiceDialog addServiceDlg;
            if(serviceList.Count == 0){
                addServiceDlg = new addServiceDialog();
            }
            else
            {
                addServiceDlg = new addServiceDialog(serviceList);
            }
            addServiceDlg.ShowDialog();

            if (addServiceDlg.DialogResult == DialogResult.OK)
            {
                serviceList = addServiceDlg.ServiceList;
                serviceListView.Items.Clear();
                loadList();
            }
            
        }

        private void invoiceSaveButton_Click(object sender, EventArgs e)
        {
            firstNameErrorProvider.Clear();
            lastNameErrorProvider.Clear();
            phoneErrorProvider.Clear();
            
            bool errFlag = false;

            if (String.IsNullOrWhiteSpace(invoiceTextBoxFirstName.Text))
            {
                errFlag = true;
                firstNameErrorProvider.SetError(this.invoiceTextBoxFirstName, "First name required");
            }
            if (String.IsNullOrWhiteSpace(invoiceTextBoxLastName.Text))
            {
                errFlag = true;
                firstNameErrorProvider.SetError(this.invoiceTextBoxLastName, "Last name required");
            }
            long result;
            if (String.IsNullOrWhiteSpace(invoiceTextBoxPhone.Text) || !Int64.TryParse(invoiceTextBoxPhone.Text,out result))
            {
                errFlag = true;
                firstNameErrorProvider.SetError(this.invoiceTextBoxPhone, "Phone Number required");
            }
            // todo: check phone number with regex

            if (!errFlag)
            {
                // creating new customer 
                if (String.IsNullOrWhiteSpace(InvoiceTextBoxCustomerId.Text))
                {
                    if (MessageBox.Show("Would you like to create a new customer using the infomation above?", "Creating new customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = createCustomer();
                        if (createInvoice(id))
                        {
                            MessageBox.Show("Invoice created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                            clearForm();
                            invoiceTextBoxInvoiceNumber.Text = getInvoiceId();

                            //update datagridview data
                            updateInvoiceDataGrid();
                            updateCustomerDataGrid();
                        }
                        else
                        {
                            MessageBox.Show("Failed creating invoice", "unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                // validating customer ID
                else
                {
                    long id;
                    bool valid = Int64.TryParse(InvoiceTextBoxCustomerId.Text,out id);

                    if (valid)
                    {
                        var query = from customer in this.applicationDatabase.Customer
                                    where customer.CustomerId == id
                                    select customer;

                        if (!query.Any())
                        {
                            MessageBox.Show("Please enter a valid Customer ID.\nIf you would like to create a new customer with the above infomation, please leave 'Customer ID' blank.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (createInvoice(id))
                            {
                                MessageBox.Show("Invoice created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                                clearForm();
                                invoiceTextBoxInvoiceNumber.Text = getInvoiceId();

                                //update datagridview data
                                updateInvoiceDataGrid();
                            }
                            else
                            {
                                MessageBox.Show("Failed creating invoice", "unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Customer ID.\nIf you would like to create a new customer with the above infomation, please leave 'Customer ID' blank.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                }
            }                      
        }

        private void invoiceClearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the form?", "Clearing form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clearForm();
            }
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedIndex == 0)
            {
                invoiceTimePicker.Value = DateTime.Now;
            }
        }

        
        private void customerDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //MessageBox.Show(customerDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                InvoiceTextBoxCustomerId.Text = customerDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                invoiceTextBoxFirstName.Text = customerDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                invoiceTextBoxLastName.Text = customerDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                invoiceTextBoxPhone.Text = customerDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void invoiceDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                // insert data from database
            }
        }

        //private void autoFillButton_Click(object sender, EventArgs e)
        //{
        //    long id;
        //    if (!String.IsNullOrWhiteSpace(InvoiceTextBoxCustomerId.Text) && Int64.TryParse(InvoiceTextBoxCustomerId.Text, out id))
        //    {
        //        var query = from customer in this.applicationDatabase.Customer
        //                    where customer.CustomerId == id
        //                    select customer;

        //        if (!query.Any())
        //        {
        //            MessageBox.Show("Please enter a valid Customer ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        else
        //        {
        //            foreach (var items in query)
        //            {
        //                invoiceTextBoxFirstName.Text = items.FirstName;
        //                invoiceTextBoxLastName.Text = items.LastName;
        //                invoiceTextBoxPhone.Text = items.PhoneNumber.ToString();
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please enter a valid Customer ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        #endregion

        #region Other Events

        private void InvoiceTextBoxCustomerId_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(InvoiceTextBoxCustomerId.Text))
                createCustomerGroupBox.Enabled = true;
            else
                createCustomerGroupBox.Enabled = false;
        }

        private void invoiceTextBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(invoiceTextBoxFirstName.Text) && String.IsNullOrWhiteSpace(invoiceTextBoxLastName.Text) && String.IsNullOrWhiteSpace(invoiceTextBoxPhone.Text))
                selectFromDirectoryGroupBox.Enabled = true;
            else
                selectFromDirectoryGroupBox.Enabled = false;
        }

        private void invoiceTextBoxLastName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(invoiceTextBoxFirstName.Text) && String.IsNullOrWhiteSpace(invoiceTextBoxLastName.Text) && String.IsNullOrWhiteSpace(invoiceTextBoxPhone.Text))
                selectFromDirectoryGroupBox.Enabled = true;
            else
                selectFromDirectoryGroupBox.Enabled = false;
        }

        private void invoiceTextBoxPhone_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(invoiceTextBoxFirstName.Text) && String.IsNullOrWhiteSpace(invoiceTextBoxLastName.Text) && String.IsNullOrWhiteSpace(invoiceTextBoxPhone.Text))
                selectFromDirectoryGroupBox.Enabled = true;
            else
                selectFromDirectoryGroupBox.Enabled = false;
        }

        #endregion

        #region SQL methods

        // Gets the ID of the last invoice and incriment it by 1
        private String getInvoiceId()
        {
            String id = "";

            try
            {
                // SQL
                using (conn = new SqlConnection(global::formApp.Properties.Settings.Default.DatabaseConnectionString))
                {
                    String sql = "SELECT MAX(InvoiceId) FROM Invoice";
                    SqlCommand exeSql = new SqlCommand(sql, conn);
                    conn.Open();
                    long result;
                    if (long.TryParse(exeSql.ExecuteScalar().ToString(), out result))
                    {
                        id = (result + 1).ToString();
                    }
                    else
                    {
                        id = "1";
                    }
                }

                // LINQ
                //var query = from invoice in this.applicationDatabase.Invoice
                //            select invoice.InvoiceId;
                //if (!query.Any())
                //{
                //    id = "1";
                //}
                //else
                //{
                //    id = (query.Max() + 1).ToString();
                //}                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return id;
        }

        private void updateInvoiceDataGrid()
        {
            this.invoiceCustViewTableAdapter.Fill(this.applicationDatabase.InvoiceCustView);
            invoiceCustViewBindingSource.ResetBindings(false);
            invoiceDataGridView.DataSource = null;
            invoiceDataGridView.DataSource = invoiceCustViewBindingSource;
        }

        private void updateCustomerDataGrid()
        {
            this.customerTableAdapter.Fill(this.applicationDatabase.Customer);
            customerBindingSource.ResetBindings(false);
            customerDataGridView.DataSource = null;
            customerDataGridView.DataSource = customerBindingSource;
        }

        //todo: create addtion sql for invoicedetails table
        private bool createInvoice(long id)
        {
            if (id != 0)
            {
                Invoice invoice = new Invoice();
                invoice.CustomerId = id;

                long result;
                if (Int64.TryParse(invoiceTextBoxInvoiceNumber.Text.ToString(), out result))
                {
                    invoice.InvoiceId = result;
                    invoice.Services = serviceList;

                    // LINQ
                    //ApplicationDatabase.InvoiceRow rb = this.applicationDatabase.Invoice.NewInvoiceRow();
                    //rb.CustomerId = (int)invoice.CustomerId;
                    //rb.InvoiceId = (int)invoice.InvoiceId;
                    //this.applicationDatabase.Invoice.AddInvoiceRow(rb);

                    // SQL
                    using (conn = new SqlConnection(global::formApp.Properties.Settings.Default.DatabaseConnectionString))
                    {
                        string sqlIns = "INSERT INTO Invoice (CustomerId) VALUES (@customerId)";
                        SqlCommand cmdIns = new SqlCommand(sqlIns, conn);
                        cmdIns.Parameters.AddWithValue("@customerId", invoice.CustomerId);
                        conn.Open();
                        cmdIns.ExecuteNonQuery();
                        cmdIns.Parameters.Clear();
                        conn.Close();
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("Null invoiceID while creating invoice", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Null custID while creating invoice", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private int createCustomer()
        {
            int id = 0;

            using (conn = new SqlConnection(global::formApp.Properties.Settings.Default.DatabaseConnectionString))
            {
                string sqlIns = "INSERT INTO Customer (FirstName,LastName,PhoneNumber) OUTPUT INSERTED.CustomerId VALUES (@firstName,@lastName,@phoneNumber)";
                SqlCommand cmdIns = new SqlCommand(sqlIns, conn);
                cmdIns.Parameters.AddWithValue("@firstName", invoiceTextBoxFirstName.Text.ToString());
                cmdIns.Parameters.AddWithValue("@lastName", invoiceTextBoxLastName.Text.ToString());
                cmdIns.Parameters.AddWithValue("@phoneNumber", invoiceTextBoxPhone.Text.ToString());
                conn.Open();

                id = (int)cmdIns.ExecuteScalar();
                conn.Close();
                
            }
            return id;
        }

        #endregion

        #region utility methods

        private void loadList()
        {
            foreach (ServiceItem serviceItem in serviceList)
            {
                ListViewItem items = new ListViewItem();
                items.Text = serviceItem.Description;
                items.SubItems.Add(serviceItem.Id + "");
                items.SubItems.Add(serviceItem.Price + "");
                serviceListView.Items.Add(items);
            }
            calcSubtotal();
        }

        private void calcSubtotal()
        {
            serviceListView.Items.Remove(items);
            items.SubItems.RemoveAt(2);
            double subtotal = 0.0;

            for (int i = 0; i < serviceListView.Items.Count; i++)
            {
                subtotal += Double.Parse(serviceListView.Items[i].SubItems[2].Text);
            }

            items.SubItems.Add(subtotal.ToString("0.00"));
            serviceListView.Items.Add(items);

        }       

        private void clearForm()
        {
            serviceList.Clear();
            serviceListView.Items.Clear();
            InvoiceTextBoxCustomerId.Clear();
            invoiceTextBoxFirstName.Clear();
            invoiceTextBoxLastName.Clear();
            invoiceTextBoxPhone.Clear();
            invoiceTimePicker.Value = DateTime.Now;
            calcSubtotal();
        }


        #endregion
        
    }
}
