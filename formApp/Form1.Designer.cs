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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.invoiceTab = new System.Windows.Forms.TabPage();
            this.invoiceTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.invoiceClearButton = new System.Windows.Forms.Button();
            this.invoiceSaveButton = new System.Windows.Forms.Button();
            this.removeServiceButton = new System.Windows.Forms.Button();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.invoiceTextBoxInvoiceNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.invoiceTextBoxPhone = new System.Windows.Forms.TextBox();
            this.invoiceTextBoxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.invoiceTextBoxFirstName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.applicationDatabase = new formApp.ApplicationDatabase();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new formApp.ApplicationDatabaseTableAdapters.CustomerTableAdapter();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serviceListView = new System.Windows.Forms.ListView();
            this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new formApp.ApplicationDatabaseTableAdapters.InvoiceTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.invoiceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
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
            this.tabPage3.Controls.Add(this.customerDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(313, 524);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Customer Directory";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.invoiceDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(313, 524);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Past Invoices";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.RowHeadersWidth = 40;
            this.customerDataGridView.Size = new System.Drawing.Size(307, 518);
            this.customerDataGridView.TabIndex = 0;
            // 
            // applicationDatabase
            // 
            this.applicationDatabase.DataSetName = "ApplicationDatabase";
            this.applicationDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.applicationDatabase;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
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
            // invoiceDataGridView
            // 
            this.invoiceDataGridView.AllowUserToAddRows = false;
            this.invoiceDataGridView.AllowUserToDeleteRows = false;
            this.invoiceDataGridView.AutoGenerateColumns = false;
            this.invoiceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.invoiceDataGridView.ColumnHeadersHeight = 21;
            this.invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.invoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.totalPriceDataGridViewTextBoxColumn});
            this.invoiceDataGridView.DataSource = this.invoiceBindingSource;
            this.invoiceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceDataGridView.Location = new System.Drawing.Point(3, 3);
            this.invoiceDataGridView.Name = "invoiceDataGridView";
            this.invoiceDataGridView.ReadOnly = true;
            this.invoiceDataGridView.RowHeadersVisible = false;
            this.invoiceDataGridView.Size = new System.Drawing.Size(307, 518);
            this.invoiceDataGridView.TabIndex = 0;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.applicationDatabase;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 81.21828F;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.FillWeight = 106.2606F;
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.FillWeight = 106.2606F;
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.FillWeight = 106.2606F;
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total Price";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 557);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage invoiceTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox invoiceTextBoxFirstName;
        private System.Windows.Forms.TextBox invoiceTextBoxLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeServiceButton;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox invoiceTextBoxInvoiceNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox invoiceTextBoxPhone;
        private System.Windows.Forms.Button invoiceClearButton;
        private System.Windows.Forms.Button invoiceSaveButton;
        private System.Windows.Forms.DateTimePicker invoiceTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private ApplicationDatabase applicationDatabase;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private ApplicationDatabaseTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView invoiceDataGridView;
        private System.Windows.Forms.ListView serviceListView;
        private System.Windows.Forms.ColumnHeader discHeader;
        private System.Windows.Forms.ColumnHeader priceHeader;
        private System.Windows.Forms.ColumnHeader qtyHeader;
        private System.Windows.Forms.ColumnHeader totalHeader;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private ApplicationDatabaseTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}

