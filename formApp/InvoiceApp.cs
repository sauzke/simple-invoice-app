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

        public InvoiceApp()
        {
            InitializeComponent();
            invoiceTimePicker.CustomFormat = "MM/dd/yyyy   hh:mm tt";

            //customerDataGridView.DataSource = customerBindingSource;
            //invoiceDataGridView.DataSource = invoiceBindingSource;

            ListViewItem items = new ListViewItem();
            items.Text = "Subtotal";
            items.SubItems.Add("");
            items.SubItems.Add("");
            items.SubItems.Add("0.0");
            serviceListView.Items.Add(items);
            
            // Todo:
            // invoiceTimePicker take system time on reload   

            invoiceTextBoxInvoiceNumber.Text = getInvoiceId();
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
                MessageBox.Show("got exception son", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return id;
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            addServiceDialog addServiceDlg = new addServiceDialog();
            addServiceDlg.Show();
        }

        private void invoiceDataGridView_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
