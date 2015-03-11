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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            if (serviceDirectoryDataGridView.SelectedRows != null)
            {
                for (int rowCount = serviceDirectoryDataGridView.SelectedRows.Count; rowCount >= 0; rowCount--)
                {
                    debugLabel.Text = serviceDirectoryDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    listDataGridView.Rows.Add(serviceDirectoryDataGridView.SelectedRows[rowCount]);
                }
            }
        }
    }
}
