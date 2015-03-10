using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using System.Linq;

namespace formApp
{
    public partial class InvoiceApp : Form
    {
        public InvoiceApp()
        {
            InitializeComponent();
            invoiceTimePicker.CustomFormat = "MM/dd/yyyy   hh:mm tt";
            

            
            // Todo:
            // invoiceTimePicker take system time on reload
            // Load invoices and customers from database            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'applicationDatabase.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.applicationDatabase.Invoice);
            this.customerTableAdapter.Fill(this.applicationDatabase.Customer);

        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            addServiceDialog addServiceDlg = new addServiceDialog();
            addServiceDlg.Show();
        }
    }
}
