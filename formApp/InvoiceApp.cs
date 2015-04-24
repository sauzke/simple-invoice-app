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

namespace formApp
{
    public partial class InvoiceApp : Form
    {
        SqlConnection conn = new SqlConnection(global::formApp.Properties.Settings.Default.DatabaseConnectionString);
        ListViewItem items = new ListViewItem();

        public InvoiceApp()
        {
            InitializeComponent();
            invoiceTimePicker.CustomFormat = "MM/dd/yyyy   hh:mm tt";

            //customerDataGridView.DataSource = customerBindingSource;
            //invoiceDataGridView.DataSource = invoiceBindingSource;         

            invoiceTextBoxInvoiceNumber.Text = getInvoiceId();
            
            items.Text = "Subtotal";
            items.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Bold); 

            items.SubItems.Add("");
            items.SubItems.Add("0.0");
            serviceListView.Items.Add(items);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'applicationDatabase.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.applicationDatabase.Invoice);
            this.customerTableAdapter.Fill(this.applicationDatabase.Customer);

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

        private void loadList(List<ServiceItem> list)
        {
            foreach (ServiceItem serviceItem in list)
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
               // MessageBox.Show(serviceListView.Items[i].SubItems[2].Text, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }

            items.SubItems.Add(subtotal + "");
            serviceListView.Items.Add(items);

        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            addServiceDialog addServiceDlg = new addServiceDialog();
            addServiceDlg.ShowDialog();

            if (addServiceDlg.DialogResult == DialogResult.OK)
            {
                List<ServiceItem> serviceList = addServiceDlg.ServiceList;
                loadList(serviceList);
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
            }
        }

        private void invoiceClearButton_Click(object sender, EventArgs e)
        {
            // todo: implement clear button
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
