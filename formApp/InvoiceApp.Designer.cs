namespace formApp
{
    partial class InvoiceApp
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
            this.sideTabControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationDatabase = new formApp.ApplicationDatabase();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.fKInvoiceDeinvoi3C69FB99BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.invoiceTab = new System.Windows.Forms.TabPage();
            this.autoFillButton = new System.Windows.Forms.Button();
            this.InvoiceTextBoxCustomerId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.invoiceTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.invoiceClearButton = new System.Windows.Forms.Button();
            this.invoiceSaveButton = new System.Windows.Forms.Button();
            this.editServiceButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.serviceListView = new System.Windows.Forms.ListView();
            this.discHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.invoiceTextBoxInvoiceNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.invoiceTextBoxPhone = new System.Windows.Forms.TextBox();
            this.invoiceTextBoxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.invoiceTextBoxFirstName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fKInvoiceCustome47DBAE45BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKInvoiceCustome47DBAE45BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new formApp.ApplicationDatabaseTableAdapters.CustomerTableAdapter();
            this.invoiceTableAdapter = new formApp.ApplicationDatabaseTableAdapters.InvoiceTableAdapter();
            this.firstNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lastNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.fKInvoiceDeinvoi3C69FB99BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDetailsTableAdapter = new formApp.ApplicationDatabaseTableAdapters.InvoiceDetailsTableAdapter();
            this.invoiceCustViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceCustViewTableAdapter = new formApp.ApplicationDatabaseTableAdapters.InvoiceCustViewTableAdapter();
            this.invoiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.sideTabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDatabase)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKInvoiceDeinvoi3C69FB99BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.invoiceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKInvoiceCustome47DBAE45BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKInvoiceCustome47DBAE45BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKInvoiceDeinvoi3C69FB99BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceCustViewBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.sideTabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mainTabControl);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 557);
            this.splitContainer1.SplitterDistance = 479;
            this.splitContainer1.TabIndex = 0;
            // 
            // sideTabControl
            // 
            this.sideTabControl.Controls.Add(this.tabPage3);
            this.sideTabControl.Controls.Add(this.tabPage4);
            this.sideTabControl.Location = new System.Drawing.Point(3, 3);
            this.sideTabControl.Name = "sideTabControl";
            this.sideTabControl.SelectedIndex = 0;
            this.sideTabControl.Size = new System.Drawing.Size(473, 550);
            this.sideTabControl.TabIndex = 0;
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
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.phoneNumberDataGridViewTextBoxColumn1});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.RowHeadersWidth = 40;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(307, 518);
            this.customerDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn1
            // 
            this.phoneNumberDataGridViewTextBoxColumn1.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn1.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn1.Name = "phoneNumberDataGridViewTextBoxColumn1";
            this.phoneNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.applicationDatabase;
            // 
            // applicationDatabase
            // 
            this.applicationDatabase.DataSetName = "ApplicationDatabase";
            this.applicationDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.invoiceDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(465, 524);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Past Invoices";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.invoiceIdDataGridViewTextBoxColumn,
            this.custIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.totalDataGridViewTextBoxColumn});
            this.invoiceDataGridView.DataSource = this.invoiceCustViewBindingSource;
            this.invoiceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceDataGridView.Location = new System.Drawing.Point(3, 3);
            this.invoiceDataGridView.Name = "invoiceDataGridView";
            this.invoiceDataGridView.ReadOnly = true;
            this.invoiceDataGridView.RowHeadersVisible = false;
            this.invoiceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoiceDataGridView.Size = new System.Drawing.Size(459, 518);
            this.invoiceDataGridView.TabIndex = 0;
            // 
            // fKInvoiceDeinvoi3C69FB99BindingSource1
            // 
            this.fKInvoiceDeinvoi3C69FB99BindingSource1.DataMember = "FK__InvoiceDe__invoi__3C69FB99";
            this.fKInvoiceDeinvoi3C69FB99BindingSource1.DataSource = this.invoiceBindingSource;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.applicationDatabase;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.invoiceTab);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Location = new System.Drawing.Point(3, 3);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(657, 554);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // invoiceTab
            // 
            this.invoiceTab.Controls.Add(this.autoFillButton);
            this.invoiceTab.Controls.Add(this.InvoiceTextBoxCustomerId);
            this.invoiceTab.Controls.Add(this.label6);
            this.invoiceTab.Controls.Add(this.invoiceTimePicker);
            this.invoiceTab.Controls.Add(this.label5);
            this.invoiceTab.Controls.Add(this.invoiceClearButton);
            this.invoiceTab.Controls.Add(this.invoiceSaveButton);
            this.invoiceTab.Controls.Add(this.editServiceButton);
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
            this.invoiceTab.Size = new System.Drawing.Size(649, 528);
            this.invoiceTab.TabIndex = 0;
            this.invoiceTab.Text = "Invoices";
            this.invoiceTab.UseVisualStyleBackColor = true;
            // 
            // autoFillButton
            // 
            this.autoFillButton.Location = new System.Drawing.Point(277, 101);
            this.autoFillButton.Name = "autoFillButton";
            this.autoFillButton.Size = new System.Drawing.Size(100, 23);
            this.autoFillButton.TabIndex = 18;
            this.autoFillButton.Text = "Autofill";
            this.autoFillButton.UseVisualStyleBackColor = true;
            this.autoFillButton.Click += new System.EventHandler(this.autoFillButton_Click);
            // 
            // InvoiceTextBoxCustomerId
            // 
            this.InvoiceTextBoxCustomerId.Location = new System.Drawing.Point(91, 103);
            this.InvoiceTextBoxCustomerId.Name = "InvoiceTextBoxCustomerId";
            this.InvoiceTextBoxCustomerId.Size = new System.Drawing.Size(160, 20);
            this.InvoiceTextBoxCustomerId.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Customer ID:";
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
            this.invoiceClearButton.Click += new System.EventHandler(this.invoiceClearButton_Click);
            // 
            // invoiceSaveButton
            // 
            this.invoiceSaveButton.Location = new System.Drawing.Point(435, 497);
            this.invoiceSaveButton.Name = "invoiceSaveButton";
            this.invoiceSaveButton.Size = new System.Drawing.Size(75, 23);
            this.invoiceSaveButton.TabIndex = 12;
            this.invoiceSaveButton.Text = "Save";
            this.invoiceSaveButton.UseVisualStyleBackColor = true;
            this.invoiceSaveButton.Click += new System.EventHandler(this.invoiceSaveButton_Click);
            // 
            // editServiceButton
            // 
            this.editServiceButton.Location = new System.Drawing.Point(457, 101);
            this.editServiceButton.Name = "editServiceButton";
            this.editServiceButton.Size = new System.Drawing.Size(154, 23);
            this.editServiceButton.TabIndex = 10;
            this.editServiceButton.Text = "Add/Remove Service";
            this.editServiceButton.UseVisualStyleBackColor = true;
            this.editServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Services:";
            // 
            // serviceListView
            // 
            this.serviceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.discHeader,
            this.idHeader,
            this.priceHeader});
            this.serviceListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceListView.Location = new System.Drawing.Point(11, 160);
            this.serviceListView.Name = "serviceListView";
            this.serviceListView.Size = new System.Drawing.Size(620, 302);
            this.serviceListView.TabIndex = 8;
            this.serviceListView.UseCompatibleStateImageBehavior = false;
            this.serviceListView.View = System.Windows.Forms.View.Details;
            // 
            // discHeader
            // 
            this.discHeader.Text = "Discription";
            this.discHeader.Width = 456;
            // 
            // idHeader
            // 
            this.idHeader.Text = "Item ID";
            this.idHeader.Width = 80;
            // 
            // priceHeader
            // 
            this.priceHeader.Text = "Price";
            this.priceHeader.Width = 80;
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
            this.invoiceTextBoxInvoiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 72);
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
            // fKInvoiceCustome47DBAE45BindingSource
            // 
            this.fKInvoiceCustome47DBAE45BindingSource.DataMember = "FK__Invoice__Custome__47DBAE45";
            this.fKInvoiceCustome47DBAE45BindingSource.DataSource = this.customerBindingSource;
            // 
            // fKInvoiceCustome47DBAE45BindingSource1
            // 
            this.fKInvoiceCustome47DBAE45BindingSource1.DataMember = "FK__Invoice__Custome__47DBAE45";
            this.fKInvoiceCustome47DBAE45BindingSource1.DataSource = this.customerBindingSource;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // firstNameErrorProvider
            // 
            this.firstNameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.firstNameErrorProvider.ContainerControl = this;
            // 
            // lastNameErrorProvider
            // 
            this.lastNameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.lastNameErrorProvider.ContainerControl = this;
            // 
            // phoneErrorProvider
            // 
            this.phoneErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.phoneErrorProvider.ContainerControl = this;
            // 
            // fKInvoiceDeinvoi3C69FB99BindingSource
            // 
            this.fKInvoiceDeinvoi3C69FB99BindingSource.DataMember = "FK__InvoiceDe__invoi__3C69FB99";
            this.fKInvoiceDeinvoi3C69FB99BindingSource.DataSource = this.invoiceBindingSource;
            // 
            // invoiceDetailsTableAdapter
            // 
            this.invoiceDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceCustViewBindingSource
            // 
            this.invoiceCustViewBindingSource.DataMember = "InvoiceCustView";
            this.invoiceCustViewBindingSource.DataSource = this.applicationDatabase;
            // 
            // invoiceCustViewTableAdapter
            // 
            this.invoiceCustViewTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            this.invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.FillWeight = 81.90491F;
            this.invoiceIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            this.invoiceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "custID";
            this.custIDDataGridViewTextBoxColumn.FillWeight = 76.14214F;
            this.custIDDataGridViewTextBoxColumn.HeaderText = "Cust ID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "firstname";
            this.dataGridViewTextBoxColumn2.FillWeight = 113.9843F;
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lastname";
            this.dataGridViewTextBoxColumn3.FillWeight = 113.9843F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.FillWeight = 113.9843F;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // InvoiceApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 557);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "InvoiceApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.sideTabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDatabase)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKInvoiceDeinvoi3C69FB99BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.invoiceTab.ResumeLayout(false);
            this.invoiceTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKInvoiceCustome47DBAE45BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKInvoiceCustome47DBAE45BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKInvoiceDeinvoi3C69FB99BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceCustViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage invoiceTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl sideTabControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox invoiceTextBoxFirstName;
        private System.Windows.Forms.TextBox invoiceTextBoxLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editServiceButton;
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
        private System.Windows.Forms.DataGridView invoiceDataGridView;
        private System.Windows.Forms.ListView serviceListView;
        private System.Windows.Forms.ColumnHeader discHeader;
        private System.Windows.Forms.ColumnHeader priceHeader;
        private System.Windows.Forms.ColumnHeader idHeader;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private ApplicationDatabaseTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.BindingSource fKInvoiceCustome47DBAE45BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKInvoiceCustome47DBAE45BindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InvoiceTextBoxCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button autoFillButton;
        private System.Windows.Forms.ErrorProvider firstNameErrorProvider;
        private System.Windows.Forms.ErrorProvider lastNameErrorProvider;
        private System.Windows.Forms.ErrorProvider phoneErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKInvoiceDeinvoi3C69FB99BindingSource;
        private ApplicationDatabaseTableAdapters.InvoiceDetailsTableAdapter invoiceDetailsTableAdapter;
        private System.Windows.Forms.BindingSource fKInvoiceDeinvoi3C69FB99BindingSource1;
        private System.Windows.Forms.BindingSource invoiceCustViewBindingSource;
        private ApplicationDatabaseTableAdapters.InvoiceCustViewTableAdapter invoiceCustViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}

