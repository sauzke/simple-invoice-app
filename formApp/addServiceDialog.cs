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
        private List<ServiceItem> serviceList;

        public addServiceDialog()
        {
            InitializeComponent();
            serviceList = new List<ServiceItem>();
            listDataGridView.DataSource = serviceList;
        }

        public List<ServiceItem> ServiceList {
            get
            {
                return this.serviceList;
            }
        }

        private void addServiceDialog_Load(object sender, EventArgs e)
        {            
            this.productTableAdapter.Fill(this.applicationDatabase.Product);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
                    serviceList.Add(temp);
                }

                listDataGridView.DataSource = null;
                listDataGridView.DataSource = serviceList;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
