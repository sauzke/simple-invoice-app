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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            invoiceTimePicker.CustomFormat = "MM/dd/yyyy   hh:mm tt";

            // Todo:
            // invoiceTimePicker take system time on reload
            // Load invoices and customers from database            
        }
    }
}
