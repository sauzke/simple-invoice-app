using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formApp
{
    public partial class addServiceDialog : Form
    {
        public addServiceDialog()
        {
            InitializeComponent();
        }

        private void addServiceDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'applicationDatabase.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.applicationDatabase.Product);

        }
    }
}
