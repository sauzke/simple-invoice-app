namespace formApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.customerListView = new System.Windows.Forms.ListView();
            this.firstNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.invoiceNumHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.invoiceFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.invoiceLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.invoicePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.invoiceTab = new System.Windows.Forms.TabPage();
            this.invoiceTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.invoiceClearButton = new System.Windows.Forms.Button();
            this.invoiceSaveButton = new System.Windows.Forms.Button();
            this.removeServiceButton = new System.Windows.Forms.Button();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.serviceListView = new System.Windows.Forms.ListView();
            this.discHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.invoiceTextBoxInvoiceNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.invoiceTextBoxPhone = new System.Windows.Forms.TextBox();
            this.invoiceTextBoxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.invoiceTextBoxFirstName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.invoiceTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(981, 557);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(321, 550);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.customerListView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(313, 524);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Customer Directory";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // customerListView
            // 
            this.customerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstNameHeader,
            this.lastNameHeader,
            this.phoneNumberHeader});
            this.customerListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerListView.Location = new System.Drawing.Point(3, 3);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(307, 518);
            this.customerListView.TabIndex = 0;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            this.customerListView.View = System.Windows.Forms.View.Details;
            // 
            // firstNameHeader
            // 
            this.firstNameHeader.Text = "Frist Name";
            this.firstNameHeader.Width = 80;
            // 
            // lastNameHeader
            // 
            this.lastNameHeader.Text = "Last Name";
            this.lastNameHeader.Width = 80;
            // 
            // phoneNumberHeader
            // 
            this.phoneNumberHeader.Text = "Phone Number";
            this.phoneNumberHeader.Width = 147;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(313, 524);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Past Invoices";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.invoiceNumHeader,
            this.invoiceFirstName,
            this.invoiceLastName,
            this.invoicePrice});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(307, 518);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // invoiceNumHeader
            // 
            this.invoiceNumHeader.Text = "Invoice #";
            // 
            // invoiceFirstName
            // 
            this.invoiceFirstName.Text = "First Name";
            this.invoiceFirstName.Width = 88;
            // 
            // invoiceLastName
            // 
            this.invoiceLastName.Text = "Last Name";
            this.invoiceLastName.Width = 89;
            // 
            // invoicePrice
            // 
            this.invoicePrice.Text = "Total Price";
            this.invoicePrice.Width = 70;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.invoiceTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // invoiceTab
            // 
            this.invoiceTab.Controls.Add(this.invoiceTimePicker);
            this.invoiceTab.Controls.Add(this.label5);
            this.invoiceTab.Controls.Add(this.invoiceClearButton);
            this.invoiceTab.Controls.Add(this.invoiceSaveButton);
            this.invoiceTab.Controls.Add(this.removeServiceButton);
            this.invoiceTab.Controls.Add(this.addServiceButton);
            this.invoiceTab.Controls.Add(this.label4);
            this.invoiceTab.Controls.Add(this.serviceListView);
            this.invoiceTab.Controls.Add(this.label3);
            this.invoiceTab.Controls.Add(this.invoiceTextBoxInvoiceNumber);
            this.invoiceTab.Controls.Add(this.label2);
            this.invoiceTab.Controls.Add(this.invoiceTextBoxPhone);
            this.invoiceTab.Controls.Add(this.invoiceTextBoxLastName);
            this.invoiceTab.Controls.Add(this.label1);
            this.invoiceTab.Controls.Add(this.firstNameLabel);
            this.invoiceTab.Controls.Add(this.invoiceTextBoxFirstName);
            this.invoiceTab.Location = new System.Drawing.Point(4, 22);
            this.invoiceTab.Name = "invoiceTab";
            this.invoiceTab.Padding = new System.Windows.Forms.Padding(3);
            this.invoiceTab.Size = new System.Drawing.Size(639, 528);
            this.invoiceTab.TabIndex = 0;
            this.invoiceTab.Text = "Invoices";
            this.invoiceTab.UseVisualStyleBackColor = true;
            // 
            // invoiceTimePicker
            // 
            this.invoiceTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.invoiceTimePicker.Location = new System.Drawing.Point(457, 69);
            this.invoiceTimePicker.Name = "invoiceTimePicker";
            this.invoiceTimePicker.Size = new System.Drawing.Size(154, 20);
            this.invoiceTimePicker.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date:";
            // 
            // invoiceClearButton
            // 
            this.invoiceClearButton.Location = new System.Drawing.Point(536, 497);
            this.invoiceClearButton.Name = "invoiceClearButton";
            this.invoiceClearButton.Size = new System.Drawing.Size(75, 23);
            this.invoiceClearButton.TabIndex = 13;
            this.invoiceClearButton.Text = "Clear";
            this.invoiceClearButton.UseVisualStyleBackColor = true;
            // 
            // invoiceSaveButton
            // 
            this.invoiceSaveButton.Location = new System.Drawing.Point(435, 497);
            this.invoiceSaveButton.Name = "invoiceSaveButton";
            this.invoiceSaveButton.Size = new System.Drawing.Size(75, 23);
            this.invoiceSaveButton.TabIndex = 12;
            this.invoiceSaveButton.Text = "Save";
            this.invoiceSaveButton.UseVisualStyleBackColor = true;
            // 
            // removeServiceButton
            // 
            this.removeServiceButton.Location = new System.Drawing.Point(496, 101);
            this.removeServiceButton.Name = "removeServiceButton";
            this.removeServiceButton.Size = new System.Drawing.Size(97, 23);
            this.removeServiceButton.TabIndex = 11;
            this.removeServiceButton.Text = "Remove Service";
            this.removeServiceButton.UseVisualStyleBackColor = true;
            // 
            // addServiceButton
            // 
            this.addServiceButton.Location = new System.Drawing.Point(415, 101);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(75, 23);
            this.addServiceButton.TabIndex = 10;
            this.addServiceButton.Text = "Add Service";
            this.addServiceButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Services:";
            // 
            // serviceListView
            // 
            this.serviceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.discHeader,
            this.priceHeader,
            this.qtyHeader,
            this.totalHeader});
            this.serviceListView.Location = new System.Drawing.Point(11, 143);
            this.serviceListView.Name = "serviceListView";
            this.serviceListView.Size = new System.Drawing.Size(620, 319);
            this.serviceListView.TabIndex = 8;
            this.serviceListView.UseCompatibleStateImageBehavior = false;
            this.serviceListView.View = System.Windows.Forms.View.Details;
            // 
            // discHeader
            // 
            this.discHeader.Text = "Discription";
            this.discHeader.Width = 400;
            // 
            // priceHeader
            // 
            this.priceHeader.Text = "Price";
            this.priceHeader.Width = 80;
            // 
            // qtyHeader
            // 
            this.qtyHeader.Text = "Qty";
            // 
            // totalHeader
            // 
            this.totalHeader.Text = "Total";
            this.totalHeader.Width = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Invoice #:";
            // 
            // invoiceTextBoxInvoiceNumber
            // 
            this.invoiceTextBoxInvoiceNumber.Enabled = false;
            this.invoiceTextBoxInvoiceNumber.Location = new System.Drawing.Point(457, 32);
            this.invoiceTextBoxInvoiceNumber.Name = "invoiceTextBoxInvoiceNumber";
            this.invoiceTextBoxInvoiceNumber.Size = new System.Drawing.Size(154, 20);
            this.invoiceTextBoxInvoiceNumber.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone Number:";
            // 
            // invoiceTextBoxPhone
            // 
            this.invoiceTextBoxPhone.Location = new System.Drawing.Point(91, 69);
            this.invoiceTextBoxPhone.Name = "invoiceTextBoxPhone";
            this.invoiceTextBoxPhone.Size = new System.Drawing.Size(286, 20);
            this.invoiceTextBoxPhone.TabIndex = 4;
            // 
            // invoiceTextBoxLastName
            // 
            this.invoiceTextBoxLastName.Location = new System.Drawing.Point(277, 32);
            this.invoiceTextBoxLastName.Name = "invoiceTextBoxLastName";
            this.invoiceTextBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.invoiceTextBoxLastName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(25, 35);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name:";
            // 
            // invoiceTextBoxFirstName
            // 
            this.invoiceTextBoxFirstName.Location = new System.Drawing.Point(91, 32);
            this.invoiceTextBoxFirstName.Name = "invoiceTextBoxFirstName";
            this.invoiceTextBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.invoiceTextBoxFirstName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preview";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 557);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.invoiceTab.ResumeLayout(false);
            this.invoiceTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage invoiceTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView customerListView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ColumnHeader firstNameHeader;
        private System.Windows.Forms.ColumnHeader lastNameHeader;
        private System.Windows.Forms.ColumnHeader phoneNumberHeader;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox invoiceTextBoxFirstName;
        private System.Windows.Forms.TextBox invoiceTextBoxLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeServiceButton;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView serviceListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox invoiceTextBoxInvoiceNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox invoiceTextBoxPhone;
        private System.Windows.Forms.ColumnHeader discHeader;
        private System.Windows.Forms.ColumnHeader priceHeader;
        private System.Windows.Forms.ColumnHeader qtyHeader;
        private System.Windows.Forms.ColumnHeader totalHeader;
        private System.Windows.Forms.Button invoiceClearButton;
        private System.Windows.Forms.Button invoiceSaveButton;
        private System.Windows.Forms.DateTimePicker invoiceTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader invoiceNumHeader;
        private System.Windows.Forms.ColumnHeader invoiceFirstName;
        private System.Windows.Forms.ColumnHeader invoiceLastName;
        private System.Windows.Forms.ColumnHeader invoicePrice;
    }
}

