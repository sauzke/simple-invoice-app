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
        List<ServiceItem> list;
        public addServiceDialog()
        {
            InitializeComponent();
            list = new List<ServiceItem>();
            listDataGridView.DataSource = list;
        }

        private void addServiceDialog_Load(object sender, EventArgs e)
        {            
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
                debugLabel.Text = "";
                DataGridViewSelectedRowCollection collection = serviceDirectoryDataGridView.SelectedRows;
                

                for (int i = collection.Count - 1; i >= 0; i--)
                {
                    debugLabel.Text += serviceDirectoryDataGridView.SelectedRows[i].Cells[1].Value.ToString();
                    ServiceItem temp = new ServiceItem(Convert.ToInt64(serviceDirectoryDataGridView.SelectedRows[i].Cells[0].Value.ToString()), serviceDirectoryDataGridView.SelectedRows[i].Cells[1].Value.ToString(), Convert.ToDouble(serviceDirectoryDataGridView.SelectedRows[i].Cells[2].Value.ToString()));
                    list.Add(temp);
                }

                listDataGridView.DataSource = null;
                listDataGridView.DataSource = list;
            }
        }
    }
}
