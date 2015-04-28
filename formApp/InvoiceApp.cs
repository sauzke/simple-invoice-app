﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using System.Linq;

// todo: generate .mdf file if missing with all tables

namespace formApp
{
    public partial class InvoiceApp : Form
    {
        AutoCompleteStringCollection autoCompleteFirstName = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autoCompleteLastName = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autoCompletePhone = new AutoCompleteStringCollection();
        SqlConnection conn;
        ListViewItem items;
        List<ServiceItem> serviceList;

        public InvoiceApp()
        {
            InitializeComponent();
            conn = new SqlConnection(global::formApp.Properties.Settings.Default.DatabaseConnectionString);
            items = new ListViewItem();
            serviceList = new List<ServiceItem>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private String getInvoiceId()
        {
            String id = "";

            try
            {
                String sql = "SELECT MAX(InvoiceId) FROM Invoice";
                SqlCommand exeSql = new SqlCommand(sql, conn);
                conn.Open();
                id = exeSql.ExecuteScalar().ToString();
               
                if (id == null || id == "")
                {
                    id = "1";
                    
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return id;
        }

        private void loadList()
        {
            foreach (ServiceItem serviceItem in serviceList)
            {
                ListViewItem items = new ListViewItem();
                items.Text = serviceItem.Description;
                items.SubItems.Add(serviceItem.Id+"");
                items.SubItems.Add(serviceItem.Price+"");
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
                subtotal += Convert.ToDouble(serviceListView.Items[i].SubItems[2].Text);
            }

            items.SubItems.Add(subtotal.ToString("0.00"));
            serviceListView.Items.Add(items);

        }       

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
            if (String.IsNullOrWhiteSpace(InvoiceTextBoxCustomerId.Text))
            {
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
                // todo: regex phone number validation
                if (String.IsNullOrWhiteSpace(invoiceTextBoxPhone.Text))
                {
                    errFlag = true;
                    firstNameErrorProvider.SetError(this.invoiceTextBoxPhone, "Phone Number required");
                }
                if (!errFlag)
                {
                    // todo: no error, implement accessing db and inser new inovice 
                    // also add new customer to table
                }
            }
            else
            {
                // todo: implement accessing DB and insert invoice with valid custID
                // todo: auto complete custID;
                // todo: check SQLexception for invalid custID
            }
        }

        private void invoiceClearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the form?", "Clearing form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedIndex == 0)
            {
                invoiceTimePicker.Value = DateTime.Now;
            }
        }

        private void autoFillButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(InvoiceTextBoxCustomerId.Text))
            {
                long id = Convert.ToInt64(InvoiceTextBoxCustomerId.Text);

                var query = from customer in this.applicationDatabase.Customer
                            where customer.CustomerId == id
                            select customer;

                if (!query.Any())
                {
                    MessageBox.Show("Please enter a valid Customer ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (var items in query)
                    {
                        invoiceTextBoxFirstName.Text = items.FirstName;
                        invoiceTextBoxLastName.Text = items.LastName;
                        invoiceTextBoxPhone.Text = items.PhoneNumber.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Customer ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
