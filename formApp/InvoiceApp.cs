using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;

// todo: generate .mdf file if missing with all tables

namespace formApp
{
    public partial class InvoiceApp : Form
    {
        AutoCompleteStringCollection autoCompleteID = new AutoCompleteStringCollection();
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
            // TODO: This line of code loads data into the 'applicationDatabase.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.applicationDatabase.Invoice);
            this.customerTableAdapter.Fill(this.applicationDatabase.Customer);


            invoiceTimePicker.CustomFormat = "MM/dd/yyyy   hh:mm tt";

            invoiceTextBoxInvoiceNumber.Text = getInvoiceId();

            items.Text = "Subtotal";
            items.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Bold);

            items.SubItems.Add("");
            items.SubItems.Add("0.00");
            serviceListView.Items.Add(items);

            invoiceTextBoxFirstName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            invoiceTextBoxFirstName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            invoiceTextBoxFirstName.AutoCompleteCustomSource = autoCompleteID;

            
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
                String errMsg = "please enter:\n";

                if (String.IsNullOrWhiteSpace(invoiceTextBoxFirstName.Text))
                {
                    errFlag = true;
                    errMsg += "First Name\n";
                }
                if (String.IsNullOrWhiteSpace(invoiceTextBoxLastName.Text))
                {
                    errFlag = true;
                    errMsg += "Last Name\n";
                }
                if (errFlag)
                {
                    MessageBox.Show(errMsg, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
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
    }
}
