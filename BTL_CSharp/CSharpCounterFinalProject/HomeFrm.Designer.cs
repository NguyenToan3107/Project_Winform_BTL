﻿namespace CSharpCounterFinalProject
{
    partial class HomeFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeFrm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabItem = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericItemTo = new System.Windows.Forms.NumericUpDown();
            this.numericItemFrom = new System.Windows.Forms.NumericUpDown();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSearchItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioSortItemByProductDate = new System.Windows.Forms.RadioButton();
            this.radioSortItemByQuantity = new System.Windows.Forms.RadioButton();
            this.radioSortItemByName = new System.Windows.Forms.RadioButton();
            this.radioSortItemByPriceDESC = new System.Windows.Forms.RadioButton();
            this.radioSortItemByPriceASC = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFreshItem = new System.Windows.Forms.Button();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.tblItem = new System.Windows.Forms.DataGridView();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblItemEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblItemRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboSearchCustomer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioSortCustomerByCreatedDate = new System.Windows.Forms.RadioButton();
            this.radioSortCustomerByPoint = new System.Windows.Forms.RadioButton();
            this.radioSortCustomerByBirthDate = new System.Windows.Forms.RadioButton();
            this.radioSortCustomerByName = new System.Windows.Forms.RadioButton();
            this.radioSortCustomerById = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRefreshCustomer = new System.Windows.Forms.Button();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.tblCustomer = new System.Windows.Forms.DataGridView();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCustomerEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblCustomerRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabDiscount = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnSearchDiscount = new System.Windows.Forms.Button();
            this.txtSearchDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboSearchDiscount = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnRefreshDiscount = new System.Windows.Forms.Button();
            this.btnAddNeuDiscount = new System.Windows.Forms.Button();
            this.tblDiscount = new System.Windows.Forms.DataGridView();
            this.Discount_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPriceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinPriceToUseDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDiscountEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblDiscountRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnSearchBill = new System.Windows.Forms.Button();
            this.txtSearchBill = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboSearchBill = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnRefreshBill = new System.Windows.Forms.Button();
            this.btnAddNewBill = new System.Windows.Forms.Button();
            this.tblBill = new System.Windows.Forms.DataGridView();
            this.Bill_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTimeBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabStat = new System.Windows.Forms.TabPage();
            this.tbl_month_bestsold = new System.Windows.Forms.DataGridView();
            this.Month_bestsold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_revenue_month = new System.Windows.Forms.DataGridView();
            this.revenue_month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStatCustomer = new System.Windows.Forms.DataGridView();
            this.stat_customer_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stat_customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stat_customer_times = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stat_customer_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stat_customer_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStatItem = new System.Windows.Forms.DataGridView();
            this.inven_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inven_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inven_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inven_revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.btnStatResult = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboStat = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thaoTácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mAddDiscount = new System.Windows.Forms.ToolStripMenuItem();
            this.mAddBill = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemTab = new System.Windows.Forms.ToolStripMenuItem();
            this.mCustomerTab = new System.Windows.Forms.ToolStripMenuItem();
            this.mDiscountTab = new System.Windows.Forms.ToolStripMenuItem();
            this.mBillTab = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabItem.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemFrom)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblItem)).BeginInit();
            this.tabCustomer.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomer)).BeginInit();
            this.tabDiscount.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiscount)).BeginInit();
            this.tabBill.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBill)).BeginInit();
            this.tabStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_month_bestsold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_revenue_month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStatCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStatItem)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabItem);
            this.tabControl1.Controls.Add(this.tabCustomer);
            this.tabControl1.Controls.Add(this.tabDiscount);
            this.tabControl1.Controls.Add(this.tabBill);
            this.tabControl1.Controls.Add(this.tabStat);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 687);
            this.tabControl1.TabIndex = 0;
            // 
            // tabItem
            // 
            this.tabItem.Controls.Add(this.groupBox3);
            this.tabItem.Controls.Add(this.groupBox2);
            this.tabItem.Controls.Add(this.groupBox1);
            this.tabItem.Controls.Add(this.tblItem);
            this.tabItem.Location = new System.Drawing.Point(4, 26);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabItem.Size = new System.Drawing.Size(1065, 657);
            this.tabItem.TabIndex = 0;
            this.tabItem.Text = "QL Mặt Hàng";
            this.tabItem.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericItemTo);
            this.groupBox3.Controls.Add(this.numericItemFrom);
            this.groupBox3.Controls.Add(this.btnSearchItem);
            this.groupBox3.Controls.Add(this.txtSearchItem);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboSearchItem);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(739, 469);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 191);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // numericItemTo
            // 
            this.numericItemTo.Location = new System.Drawing.Point(226, 107);
            this.numericItemTo.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericItemTo.Name = "numericItemTo";
            this.numericItemTo.Size = new System.Drawing.Size(76, 24);
            this.numericItemTo.TabIndex = 8;
            // 
            // numericItemFrom
            // 
            this.numericItemFrom.Location = new System.Drawing.Point(95, 105);
            this.numericItemFrom.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericItemFrom.Name = "numericItemFrom";
            this.numericItemFrom.Size = new System.Drawing.Size(72, 24);
            this.numericItemFrom.TabIndex = 7;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Image = global::CSharpCounterFinalProject.Properties.Resources.search;
            this.btnSearchItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchItem.Location = new System.Drawing.Point(95, 138);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(150, 47);
            this.btnSearchItem.TabIndex = 6;
            this.btnSearchItem.Text = "Tìm kiếm";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            this.btnSearchItem.Click += new System.EventHandler(this.BtnSearchItemClick);
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Location = new System.Drawing.Point(95, 71);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(205, 24);
            this.txtSearchItem.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nội dung";
            // 
            // comboSearchItem
            // 
            this.comboSearchItem.FormattingEnabled = true;
            this.comboSearchItem.Items.AddRange(new object[] {
            "Tìm theo tên mặt hàng.",
            "Tìm theo khoảng giá a-b.",
            "Tìm theo loại mặt hàng.",
            "Tìm theo hãng sản xuất.",
            "Theo số lượng khoảng a-b."});
            this.comboSearchItem.Location = new System.Drawing.Point(95, 28);
            this.comboSearchItem.Name = "comboSearchItem";
            this.comboSearchItem.Size = new System.Drawing.Size(205, 25);
            this.comboSearchItem.TabIndex = 1;
            this.comboSearchItem.SelectedIndexChanged += new System.EventHandler(this.ComboSearchItemSelectefIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu chí";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioSortItemByProductDate);
            this.groupBox2.Controls.Add(this.radioSortItemByQuantity);
            this.groupBox2.Controls.Add(this.radioSortItemByName);
            this.groupBox2.Controls.Add(this.radioSortItemByPriceDESC);
            this.groupBox2.Controls.Add(this.radioSortItemByPriceASC);
            this.groupBox2.Location = new System.Drawing.Point(346, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 202);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp xếp theo";
            // 
            // radioSortItemByProductDate
            // 
            this.radioSortItemByProductDate.AutoSize = true;
            this.radioSortItemByProductDate.Location = new System.Drawing.Point(219, 101);
            this.radioSortItemByProductDate.Name = "radioSortItemByProductDate";
            this.radioSortItemByProductDate.Size = new System.Drawing.Size(182, 22);
            this.radioSortItemByProductDate.TabIndex = 4;
            this.radioSortItemByProductDate.TabStop = true;
            this.radioSortItemByProductDate.Text = "Ngày sản xuất tăng dần";
            this.radioSortItemByProductDate.UseVisualStyleBackColor = true;
            this.radioSortItemByProductDate.CheckedChanged += new System.EventHandler(this.SortItemHandler);
            // 
            // radioSortItemByQuantity
            // 
            this.radioSortItemByQuantity.AutoSize = true;
            this.radioSortItemByQuantity.Location = new System.Drawing.Point(219, 53);
            this.radioSortItemByQuantity.Name = "radioSortItemByQuantity";
            this.radioSortItemByQuantity.Size = new System.Drawing.Size(152, 22);
            this.radioSortItemByQuantity.TabIndex = 3;
            this.radioSortItemByQuantity.TabStop = true;
            this.radioSortItemByQuantity.Text = "Số lượng giảm dần";
            this.radioSortItemByQuantity.UseVisualStyleBackColor = true;
            this.radioSortItemByQuantity.CheckedChanged += new System.EventHandler(this.SortItemHandler);
            // 
            // radioSortItemByName
            // 
            this.radioSortItemByName.AutoSize = true;
            this.radioSortItemByName.Location = new System.Drawing.Point(34, 150);
            this.radioSortItemByName.Name = "radioSortItemByName";
            this.radioSortItemByName.Size = new System.Drawing.Size(144, 22);
            this.radioSortItemByName.TabIndex = 2;
            this.radioSortItemByName.TabStop = true;
            this.radioSortItemByName.Text = "Tên mặt hàng a-z";
            this.radioSortItemByName.UseVisualStyleBackColor = true;
            this.radioSortItemByName.CheckedChanged += new System.EventHandler(this.SortItemHandler);
            // 
            // radioSortItemByPriceDESC
            // 
            this.radioSortItemByPriceDESC.AutoSize = true;
            this.radioSortItemByPriceDESC.Location = new System.Drawing.Point(34, 101);
            this.radioSortItemByPriceDESC.Name = "radioSortItemByPriceDESC";
            this.radioSortItemByPriceDESC.Size = new System.Drawing.Size(179, 22);
            this.radioSortItemByPriceDESC.TabIndex = 1;
            this.radioSortItemByPriceDESC.TabStop = true;
            this.radioSortItemByPriceDESC.Text = "Giá niêm yếu giảm dần";
            this.radioSortItemByPriceDESC.UseVisualStyleBackColor = true;
            this.radioSortItemByPriceDESC.CheckedChanged += new System.EventHandler(this.SortItemHandler);
            // 
            // radioSortItemByPriceASC
            // 
            this.radioSortItemByPriceASC.AutoSize = true;
            this.radioSortItemByPriceASC.Location = new System.Drawing.Point(34, 53);
            this.radioSortItemByPriceASC.Name = "radioSortItemByPriceASC";
            this.radioSortItemByPriceASC.Size = new System.Drawing.Size(171, 22);
            this.radioSortItemByPriceASC.TabIndex = 0;
            this.radioSortItemByPriceASC.TabStop = true;
            this.radioSortItemByPriceASC.Text = "Giá niêm yết tăng dần";
            this.radioSortItemByPriceASC.UseVisualStyleBackColor = true;
            this.radioSortItemByPriceASC.CheckedChanged += new System.EventHandler(this.SortItemHandler);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFreshItem);
            this.groupBox1.Controls.Add(this.btnAddNewItem);
            this.groupBox1.Location = new System.Drawing.Point(0, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hành động";
            // 
            // btnFreshItem
            // 
            this.btnFreshItem.Image = global::CSharpCounterFinalProject.Properties.Resources.refresh;
            this.btnFreshItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFreshItem.Location = new System.Drawing.Point(177, 81);
            this.btnFreshItem.Name = "btnFreshItem";
            this.btnFreshItem.Size = new System.Drawing.Size(150, 40);
            this.btnFreshItem.TabIndex = 1;
            this.btnFreshItem.Text = "Làm mới";
            this.btnFreshItem.UseVisualStyleBackColor = true;
            this.btnFreshItem.Click += new System.EventHandler(this.BtnRefreshClick);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Image = global::CSharpCounterFinalProject.Properties.Resources.plus;
            this.btnAddNewItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewItem.Location = new System.Drawing.Point(21, 81);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(150, 40);
            this.btnAddNewItem.TabIndex = 0;
            this.btnAddNewItem.Text = "Thêm mới";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.BtnAddNewClick);
            // 
            // tblItem
            // 
            this.tblItem.AllowUserToAddRows = false;
            this.tblItem.AllowUserToDeleteRows = false;
            this.tblItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblItem.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_ID,
            this.ItemName,
            this.ItemType,
            this.Quantity,
            this.Brand,
            this.ReleaseDate,
            this.Price,
            this.Name,
            this.Image,
            this.tblItemEdit,
            this.tblItemRemove});
            this.tblItem.Location = new System.Drawing.Point(-4, 0);
            this.tblItem.Name = "tblItem";
            this.tblItem.RowHeadersWidth = 51;
            this.tblItem.RowTemplate.Height = 24;
            this.tblItem.Size = new System.Drawing.Size(1065, 469);
            this.tblItem.TabIndex = 0;
            this.tblItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblItemCellClick);
            this.tblItem.Click += new System.EventHandler(this.BtnAddNewClick);
            // 
            // Item_ID
            // 
            this.Item_ID.FillWeight = 123.5178F;
            this.Item_ID.HeaderText = "Mã MH";
            this.Item_ID.MinimumWidth = 6;
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ItemName
            // 
            this.ItemName.FillWeight = 116.3809F;
            this.ItemName.HeaderText = "Tên Mh";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ItemType
            // 
            this.ItemType.FillWeight = 110.1256F;
            this.ItemType.HeaderText = "Loại MH";
            this.ItemType.MinimumWidth = 6;
            this.ItemType.Name = "ItemType";
            this.ItemType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 104.6429F;
            this.Quantity.HeaderText = "Số Lượng";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Brand
            // 
            this.Brand.FillWeight = 99.83739F;
            this.Brand.HeaderText = "Hãng SX";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.FillWeight = 95.62546F;
            this.ReleaseDate.HeaderText = "Ngày SX";
            this.ReleaseDate.MinimumWidth = 6;
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.FillWeight = 91.93377F;
            this.Price.HeaderText = "Giá bán";
            this.Price.MaxInputLength = 999999999;
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Name
            // 
            this.Name.FillWeight = 88.69806F;
            this.Name.HeaderText = "Khuyến Mãi";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tblItemEdit
            // 
            this.tblItemEdit.FillWeight = 85.86203F;
            this.tblItemEdit.HeaderText = "Sửa";
            this.tblItemEdit.MinimumWidth = 6;
            this.tblItemEdit.Name = "tblItemEdit";
            this.tblItemEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tblItemEdit.Text = "Sửa";
            this.tblItemEdit.UseColumnTextForButtonValue = true;
            // 
            // tblItemRemove
            // 
            this.tblItemRemove.HeaderText = "Xóa";
            this.tblItemRemove.MinimumWidth = 6;
            this.tblItemRemove.Name = "tblItemRemove";
            this.tblItemRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tblItemRemove.Text = "Xóa";
            this.tblItemRemove.UseColumnTextForButtonValue = true;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.groupBox4);
            this.tabCustomer.Controls.Add(this.groupBox5);
            this.tabCustomer.Controls.Add(this.groupBox6);
            this.tabCustomer.Controls.Add(this.tblCustomer);
            this.tabCustomer.Location = new System.Drawing.Point(4, 26);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(1065, 657);
            this.tabCustomer.TabIndex = 1;
            this.tabCustomer.Text = "QL Khách Hàng";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearchCustomer);
            this.groupBox4.Controls.Add(this.txtSearchCustomer);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.comboSearchCustomer);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(741, 466);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 202);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Image = global::CSharpCounterFinalProject.Properties.Resources.search;
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.Location = new System.Drawing.Point(95, 124);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(150, 47);
            this.btnSearchCustomer.TabIndex = 6;
            this.btnSearchCustomer.Text = "Tìm kiếm";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.BtnSearchCustomerClick);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(95, 71);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(205, 24);
            this.txtSearchCustomer.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nội dung";
            // 
            // comboSearchCustomer
            // 
            this.comboSearchCustomer.FormattingEnabled = true;
            this.comboSearchCustomer.Items.AddRange(new object[] {
            "Tên khách hàng gần đúng",
            "Mã khách hàng",
            "Loại khách hàng",
            "Địa chỉ",
            "Số điện thoại"});
            this.comboSearchCustomer.Location = new System.Drawing.Point(95, 28);
            this.comboSearchCustomer.Name = "comboSearchCustomer";
            this.comboSearchCustomer.Size = new System.Drawing.Size(205, 25);
            this.comboSearchCustomer.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tiêu chí";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioSortCustomerByCreatedDate);
            this.groupBox5.Controls.Add(this.radioSortCustomerByPoint);
            this.groupBox5.Controls.Add(this.radioSortCustomerByBirthDate);
            this.groupBox5.Controls.Add(this.radioSortCustomerByName);
            this.groupBox5.Controls.Add(this.radioSortCustomerById);
            this.groupBox5.Location = new System.Drawing.Point(348, 466);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(395, 202);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sắp xếp theo";
            // 
            // radioSortCustomerByCreatedDate
            // 
            this.radioSortCustomerByCreatedDate.AutoSize = true;
            this.radioSortCustomerByCreatedDate.Location = new System.Drawing.Point(219, 101);
            this.radioSortCustomerByCreatedDate.Name = "radioSortCustomerByCreatedDate";
            this.radioSortCustomerByCreatedDate.Size = new System.Drawing.Size(152, 22);
            this.radioSortCustomerByCreatedDate.TabIndex = 4;
            this.radioSortCustomerByCreatedDate.TabStop = true;
            this.radioSortCustomerByCreatedDate.Text = "Ngày tạo tài khoản";
            this.radioSortCustomerByCreatedDate.UseVisualStyleBackColor = true;
            this.radioSortCustomerByCreatedDate.CheckedChanged += new System.EventHandler(this.RadioSortCustomerCheckedChanged);
            // 
            // radioSortCustomerByPoint
            // 
            this.radioSortCustomerByPoint.AutoSize = true;
            this.radioSortCustomerByPoint.Location = new System.Drawing.Point(219, 53);
            this.radioSortCustomerByPoint.Name = "radioSortCustomerByPoint";
            this.radioSortCustomerByPoint.Size = new System.Drawing.Size(173, 22);
            this.radioSortCustomerByPoint.TabIndex = 3;
            this.radioSortCustomerByPoint.TabStop = true;
            this.radioSortCustomerByPoint.Text = "Diểm tích lũy tăng dần";
            this.radioSortCustomerByPoint.UseVisualStyleBackColor = true;
            this.radioSortCustomerByPoint.CheckedChanged += new System.EventHandler(this.RadioSortCustomerCheckedChanged);
            // 
            // radioSortCustomerByBirthDate
            // 
            this.radioSortCustomerByBirthDate.AutoSize = true;
            this.radioSortCustomerByBirthDate.Location = new System.Drawing.Point(34, 150);
            this.radioSortCustomerByBirthDate.Name = "radioSortCustomerByBirthDate";
            this.radioSortCustomerByBirthDate.Size = new System.Drawing.Size(154, 22);
            this.radioSortCustomerByBirthDate.TabIndex = 2;
            this.radioSortCustomerByBirthDate.TabStop = true;
            this.radioSortCustomerByBirthDate.Text = "Ngày sinh tăng dần";
            this.radioSortCustomerByBirthDate.UseVisualStyleBackColor = true;
            this.radioSortCustomerByBirthDate.CheckedChanged += new System.EventHandler(this.RadioSortCustomerCheckedChanged);
            // 
            // radioSortCustomerByName
            // 
            this.radioSortCustomerByName.AutoSize = true;
            this.radioSortCustomerByName.Location = new System.Drawing.Point(34, 101);
            this.radioSortCustomerByName.Name = "radioSortCustomerByName";
            this.radioSortCustomerByName.Size = new System.Drawing.Size(194, 22);
            this.radioSortCustomerByName.TabIndex = 1;
            this.radioSortCustomerByName.TabStop = true;
            this.radioSortCustomerByName.Text = "Tên khách hàng tăng dần";
            this.radioSortCustomerByName.UseVisualStyleBackColor = true;
            this.radioSortCustomerByName.CheckedChanged += new System.EventHandler(this.RadioSortCustomerCheckedChanged);
            // 
            // radioSortCustomerById
            // 
            this.radioSortCustomerById.AutoSize = true;
            this.radioSortCustomerById.Location = new System.Drawing.Point(34, 53);
            this.radioSortCustomerById.Name = "radioSortCustomerById";
            this.radioSortCustomerById.Size = new System.Drawing.Size(190, 22);
            this.radioSortCustomerById.TabIndex = 0;
            this.radioSortCustomerById.TabStop = true;
            this.radioSortCustomerById.Text = "Mã khách hàng tăng dần";
            this.radioSortCustomerById.UseVisualStyleBackColor = true;
            this.radioSortCustomerById.CheckedChanged += new System.EventHandler(this.RadioSortCustomerCheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnRefreshCustomer);
            this.groupBox6.Controls.Add(this.btnAddNewCustomer);
            this.groupBox6.Location = new System.Drawing.Point(2, 466);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(348, 202);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hành động";
            // 
            // btnRefreshCustomer
            // 
            this.btnRefreshCustomer.Image = global::CSharpCounterFinalProject.Properties.Resources.refresh;
            this.btnRefreshCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshCustomer.Location = new System.Drawing.Point(177, 81);
            this.btnRefreshCustomer.Name = "btnRefreshCustomer";
            this.btnRefreshCustomer.Size = new System.Drawing.Size(150, 40);
            this.btnRefreshCustomer.TabIndex = 1;
            this.btnRefreshCustomer.Text = "Làm mới";
            this.btnRefreshCustomer.UseVisualStyleBackColor = true;
            this.btnRefreshCustomer.Click += new System.EventHandler(this.BtnRefreshClick);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Image = global::CSharpCounterFinalProject.Properties.Resources.plus;
            this.btnAddNewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(21, 81);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(150, 40);
            this.btnAddNewCustomer.TabIndex = 0;
            this.btnAddNewCustomer.Text = "Thêm mới";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.BtnAddNewCustomerClick);
            // 
            // tblCustomer
            // 
            this.tblCustomer.AllowUserToAddRows = false;
            this.tblCustomer.AllowUserToDeleteRows = false;
            this.tblCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_ID,
            this.FullName,
            this.BirthDate,
            this.Address,
            this.PhoneNumber,
            this.CustomerType,
            this.Point,
            this.CreateTime,
            this.Email,
            this.tblCustomerEdit,
            this.tblCustomerRemove});
            this.tblCustomer.Location = new System.Drawing.Point(-10, 0);
            this.tblCustomer.Name = "tblCustomer";
            this.tblCustomer.RowHeadersWidth = 51;
            this.tblCustomer.RowTemplate.Height = 24;
            this.tblCustomer.Size = new System.Drawing.Size(1071, 442);
            this.tblCustomer.TabIndex = 4;
            this.tblCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblCustomerCellClick);
            // 
            // Customer_ID
            // 
            this.Customer_ID.HeaderText = "Ma KH";
            this.Customer_ID.MinimumWidth = 6;
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Họ tên KH";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Ngày sinh";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Số ĐT";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomerType
            // 
            this.CustomerType.HeaderText = "Loại KH";
            this.CustomerType.MinimumWidth = 6;
            this.CustomerType.Name = "CustomerType";
            this.CustomerType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Point
            // 
            this.Point.HeaderText = "Điểm TL";
            this.Point.MinimumWidth = 6;
            this.Point.Name = "Point";
            this.Point.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CreateTime
            // 
            this.CreateTime.HeaderText = "Ngày tạo TK";
            this.CreateTime.MinimumWidth = 6;
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tblCustomerEdit
            // 
            this.tblCustomerEdit.HeaderText = "Sửa";
            this.tblCustomerEdit.MinimumWidth = 6;
            this.tblCustomerEdit.Name = "tblCustomerEdit";
            this.tblCustomerEdit.Text = "Sửa";
            this.tblCustomerEdit.UseColumnTextForButtonValue = true;
            // 
            // tblCustomerRemove
            // 
            this.tblCustomerRemove.HeaderText = "Xóa";
            this.tblCustomerRemove.MinimumWidth = 6;
            this.tblCustomerRemove.Name = "tblCustomerRemove";
            this.tblCustomerRemove.Text = "Xóa";
            this.tblCustomerRemove.UseColumnTextForButtonValue = true;
            // 
            // tabDiscount
            // 
            this.tabDiscount.Controls.Add(this.groupBox7);
            this.tabDiscount.Controls.Add(this.groupBox9);
            this.tabDiscount.Controls.Add(this.tblDiscount);
            this.tabDiscount.Location = new System.Drawing.Point(4, 26);
            this.tabDiscount.Name = "tabDiscount";
            this.tabDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiscount.Size = new System.Drawing.Size(1065, 657);
            this.tabDiscount.TabIndex = 2;
            this.tabDiscount.Text = "QL Khuyết Mãi ";
            this.tabDiscount.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnSearchDiscount);
            this.groupBox7.Controls.Add(this.txtSearchDiscount);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.comboSearchDiscount);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(549, 466);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(514, 202);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tìm kiếm";
            // 
            // btnSearchDiscount
            // 
            this.btnSearchDiscount.Image = global::CSharpCounterFinalProject.Properties.Resources.search;
            this.btnSearchDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchDiscount.Location = new System.Drawing.Point(157, 126);
            this.btnSearchDiscount.Name = "btnSearchDiscount";
            this.btnSearchDiscount.Size = new System.Drawing.Size(150, 47);
            this.btnSearchDiscount.TabIndex = 6;
            this.btnSearchDiscount.Text = "Tìm kiếm";
            this.btnSearchDiscount.UseVisualStyleBackColor = true;
            this.btnSearchDiscount.Click += new System.EventHandler(this.BtnSearchDiscountClick);
            // 
            // txtSearchDiscount
            // 
            this.txtSearchDiscount.Location = new System.Drawing.Point(157, 73);
            this.txtSearchDiscount.Name = "txtSearchDiscount";
            this.txtSearchDiscount.Size = new System.Drawing.Size(274, 24);
            this.txtSearchDiscount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nội dung";
            // 
            // comboSearchDiscount
            // 
            this.comboSearchDiscount.FormattingEnabled = true;
            this.comboSearchDiscount.Items.AddRange(new object[] {
            "Tên khuyến mãi gần đúng",
            "Mã khuyến mãi",
            "Loại khuyến mãi",
            "Số tiền KM"});
            this.comboSearchDiscount.Location = new System.Drawing.Point(157, 30);
            this.comboSearchDiscount.Name = "comboSearchDiscount";
            this.comboSearchDiscount.Size = new System.Drawing.Size(274, 25);
            this.comboSearchDiscount.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tiêu chí";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnRefreshDiscount);
            this.groupBox9.Controls.Add(this.btnAddNeuDiscount);
            this.groupBox9.Location = new System.Drawing.Point(2, 466);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(550, 202);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Hành động";
            // 
            // btnRefreshDiscount
            // 
            this.btnRefreshDiscount.Image = global::CSharpCounterFinalProject.Properties.Resources.refresh;
            this.btnRefreshDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshDiscount.Location = new System.Drawing.Point(301, 73);
            this.btnRefreshDiscount.Name = "btnRefreshDiscount";
            this.btnRefreshDiscount.Size = new System.Drawing.Size(211, 48);
            this.btnRefreshDiscount.TabIndex = 1;
            this.btnRefreshDiscount.Text = "Làm mới";
            this.btnRefreshDiscount.UseVisualStyleBackColor = true;
            this.btnRefreshDiscount.Click += new System.EventHandler(this.BtnRefreshClick);
            // 
            // btnAddNeuDiscount
            // 
            this.btnAddNeuDiscount.Image = global::CSharpCounterFinalProject.Properties.Resources.plus;
            this.btnAddNeuDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNeuDiscount.Location = new System.Drawing.Point(39, 73);
            this.btnAddNeuDiscount.Name = "btnAddNeuDiscount";
            this.btnAddNeuDiscount.Size = new System.Drawing.Size(211, 48);
            this.btnAddNeuDiscount.TabIndex = 0;
            this.btnAddNeuDiscount.Text = "Thêm mới";
            this.btnAddNeuDiscount.UseVisualStyleBackColor = true;
            this.btnAddNeuDiscount.Click += new System.EventHandler(this.BtnAddNewDiscountClick);
            // 
            // tblDiscount
            // 
            this.tblDiscount.AllowUserToAddRows = false;
            this.tblDiscount.AllowUserToDeleteRows = false;
            this.tblDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblDiscount.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDiscount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDiscount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Discount_ID,
            this.NameDiscount,
            this.StartTime,
            this.EndTime,
            this.DiscountType,
            this.DiscountPercent,
            this.DiscountPriceAmount,
            this.MinPriceToUseDiscount,
            this.tblDiscountEdit,
            this.tblDiscountRemove});
            this.tblDiscount.Location = new System.Drawing.Point(-4, 0);
            this.tblDiscount.Name = "tblDiscount";
            this.tblDiscount.RowHeadersWidth = 51;
            this.tblDiscount.RowTemplate.Height = 24;
            this.tblDiscount.Size = new System.Drawing.Size(1065, 460);
            this.tblDiscount.TabIndex = 8;
            this.tblDiscount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblDiscountCellClick);
            // 
            // Discount_ID
            // 
            this.Discount_ID.HeaderText = "Mã KM";
            this.Discount_ID.MinimumWidth = 6;
            this.Discount_ID.Name = "Discount_ID";
            this.Discount_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NameDiscount
            // 
            this.NameDiscount.HeaderText = "Tên KM";
            this.NameDiscount.MinimumWidth = 6;
            this.NameDiscount.Name = "NameDiscount";
            this.NameDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "TG bắt đầu";
            this.StartTime.MinimumWidth = 6;
            this.StartTime.Name = "StartTime";
            this.StartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "TG kết thúc";
            this.EndTime.MinimumWidth = 6;
            this.EndTime.Name = "EndTime";
            this.EndTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DiscountType
            // 
            this.DiscountType.HeaderText = "Loại KM";
            this.DiscountType.MinimumWidth = 6;
            this.DiscountType.Name = "DiscountType";
            this.DiscountType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DiscountPercent
            // 
            this.DiscountPercent.HeaderText = "% KM";
            this.DiscountPercent.MinimumWidth = 6;
            this.DiscountPercent.Name = "DiscountPercent";
            this.DiscountPercent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DiscountPriceAmount
            // 
            this.DiscountPriceAmount.HeaderText = "Số tiền KM";
            this.DiscountPriceAmount.MinimumWidth = 6;
            this.DiscountPriceAmount.Name = "DiscountPriceAmount";
            this.DiscountPriceAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MinPriceToUseDiscount
            // 
            this.MinPriceToUseDiscount.HeaderText = "Giá tối thiểu";
            this.MinPriceToUseDiscount.MinimumWidth = 6;
            this.MinPriceToUseDiscount.Name = "MinPriceToUseDiscount";
            this.MinPriceToUseDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tblDiscountEdit
            // 
            this.tblDiscountEdit.HeaderText = "Sửa";
            this.tblDiscountEdit.MinimumWidth = 6;
            this.tblDiscountEdit.Name = "tblDiscountEdit";
            this.tblDiscountEdit.Text = "Sửa";
            this.tblDiscountEdit.UseColumnTextForButtonValue = true;
            // 
            // tblDiscountRemove
            // 
            this.tblDiscountRemove.HeaderText = "Xóa";
            this.tblDiscountRemove.MinimumWidth = 6;
            this.tblDiscountRemove.Name = "tblDiscountRemove";
            this.tblDiscountRemove.Text = "Xóa";
            this.tblDiscountRemove.UseColumnTextForButtonValue = true;
            // 
            // tabBill
            // 
            this.tabBill.Controls.Add(this.groupBox8);
            this.tabBill.Controls.Add(this.groupBox10);
            this.tabBill.Controls.Add(this.tblBill);
            this.tabBill.Location = new System.Drawing.Point(4, 26);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabBill.Size = new System.Drawing.Size(1065, 657);
            this.tabBill.TabIndex = 3;
            this.tabBill.Text = "QL Hóa Đơn";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnSearchBill);
            this.groupBox8.Controls.Add(this.txtSearchBill);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.comboSearchBill);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Location = new System.Drawing.Point(549, 466);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(512, 198);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Tìm kiếm";
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.Image = global::CSharpCounterFinalProject.Properties.Resources.search;
            this.btnSearchBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchBill.Location = new System.Drawing.Point(157, 126);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(150, 47);
            this.btnSearchBill.TabIndex = 6;
            this.btnSearchBill.Text = "Tìm kiếm";
            this.btnSearchBill.UseVisualStyleBackColor = true;
            this.btnSearchBill.Click += new System.EventHandler(this.BtnSearchBillClick);
            // 
            // txtSearchBill
            // 
            this.txtSearchBill.Location = new System.Drawing.Point(157, 73);
            this.txtSearchBill.Name = "txtSearchBill";
            this.txtSearchBill.Size = new System.Drawing.Size(274, 24);
            this.txtSearchBill.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nội dung";
            // 
            // comboSearchBill
            // 
            this.comboSearchBill.FormattingEnabled = true;
            this.comboSearchBill.Items.AddRange(new object[] {
            "Tìm theo số lượng hàng",
            "Tìm theo tên khách hàng.",
            "Tìm theo trạng thái hóa đơn.",
            "Tìm theo tên nhân viên"});
            this.comboSearchBill.Location = new System.Drawing.Point(157, 30);
            this.comboSearchBill.Name = "comboSearchBill";
            this.comboSearchBill.Size = new System.Drawing.Size(274, 25);
            this.comboSearchBill.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tiêu chí";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnRefreshBill);
            this.groupBox10.Controls.Add(this.btnAddNewBill);
            this.groupBox10.Location = new System.Drawing.Point(-8, 466);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(560, 202);
            this.groupBox10.TabIndex = 13;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Hành động";
            // 
            // btnRefreshBill
            // 
            this.btnRefreshBill.Image = global::CSharpCounterFinalProject.Properties.Resources.refresh;
            this.btnRefreshBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshBill.Location = new System.Drawing.Point(301, 73);
            this.btnRefreshBill.Name = "btnRefreshBill";
            this.btnRefreshBill.Size = new System.Drawing.Size(211, 48);
            this.btnRefreshBill.TabIndex = 1;
            this.btnRefreshBill.Text = "Làm mới";
            this.btnRefreshBill.UseVisualStyleBackColor = true;
            this.btnRefreshBill.Click += new System.EventHandler(this.BtnRefreshClick);
            // 
            // btnAddNewBill
            // 
            this.btnAddNewBill.Image = global::CSharpCounterFinalProject.Properties.Resources.plus;
            this.btnAddNewBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewBill.Location = new System.Drawing.Point(39, 73);
            this.btnAddNewBill.Name = "btnAddNewBill";
            this.btnAddNewBill.Size = new System.Drawing.Size(211, 48);
            this.btnAddNewBill.TabIndex = 0;
            this.btnAddNewBill.Text = "Thêm mới";
            this.btnAddNewBill.UseVisualStyleBackColor = true;
            this.btnAddNewBill.Click += new System.EventHandler(this.BtnAddNewBillClick);
            // 
            // tblBill
            // 
            this.tblBill.AllowUserToAddRows = false;
            this.tblBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblBill.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tblBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bill_ID,
            this.FullNameBill,
            this.StaffName,
            this.CreateTimeBill,
            this.TotalItem,
            this.SubTotal,
            this.TotalDiscountAmount,
            this.TotalAmount,
            this.Status,
            this.Column9});
            this.tblBill.Location = new System.Drawing.Point(-2, -8);
            this.tblBill.Name = "tblBill";
            this.tblBill.RowHeadersWidth = 51;
            this.tblBill.RowTemplate.Height = 24;
            this.tblBill.Size = new System.Drawing.Size(1065, 469);
            this.tblBill.TabIndex = 12;
            // 
            // Bill_ID
            // 
            this.Bill_ID.HeaderText = "Mã HĐ";
            this.Bill_ID.MinimumWidth = 6;
            this.Bill_ID.Name = "Bill_ID";
            this.Bill_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FullNameBill
            // 
            this.FullNameBill.HeaderText = "Tên KH";
            this.FullNameBill.MinimumWidth = 6;
            this.FullNameBill.Name = "FullNameBill";
            this.FullNameBill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StaffName
            // 
            this.StaffName.HeaderText = "Tên NV";
            this.StaffName.MinimumWidth = 6;
            this.StaffName.Name = "StaffName";
            this.StaffName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CreateTimeBill
            // 
            this.CreateTimeBill.HeaderText = "TG lập HĐ";
            this.CreateTimeBill.MinimumWidth = 6;
            this.CreateTimeBill.Name = "CreateTimeBill";
            this.CreateTimeBill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalItem
            // 
            this.TotalItem.HeaderText = "Tổng SL hàng";
            this.TotalItem.MinimumWidth = 6;
            this.TotalItem.Name = "TotalItem";
            this.TotalItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Tạm tính";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalDiscountAmount
            // 
            this.TotalDiscountAmount.HeaderText = "Tổng KM";
            this.TotalDiscountAmount.MinimumWidth = 6;
            this.TotalDiscountAmount.Name = "TotalDiscountAmount";
            this.TotalDiscountAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Tổng tiền ";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Chi tiết";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Text = "Xem";
            this.Column9.UseColumnTextForButtonValue = true;
            // 
            // tabStat
            // 
            this.tabStat.Controls.Add(this.tbl_month_bestsold);
            this.tabStat.Controls.Add(this.tbl_revenue_month);
            this.tabStat.Controls.Add(this.tblStatCustomer);
            this.tabStat.Controls.Add(this.tblStatItem);
            this.tabStat.Controls.Add(this.groupBox11);
            this.tabStat.Location = new System.Drawing.Point(4, 26);
            this.tabStat.Name = "tabStat";
            this.tabStat.Padding = new System.Windows.Forms.Padding(3);
            this.tabStat.Size = new System.Drawing.Size(1065, 657);
            this.tabStat.TabIndex = 4;
            this.tabStat.Text = "Thống Kê";
            this.tabStat.UseVisualStyleBackColor = true;
            // 
            // tbl_month_bestsold
            // 
            this.tbl_month_bestsold.AllowUserToAddRows = false;
            this.tbl_month_bestsold.AllowUserToDeleteRows = false;
            this.tbl_month_bestsold.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_month_bestsold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_month_bestsold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month_bestsold});
            this.tbl_month_bestsold.Location = new System.Drawing.Point(793, 0);
            this.tbl_month_bestsold.Name = "tbl_month_bestsold";
            this.tbl_month_bestsold.RowHeadersWidth = 51;
            this.tbl_month_bestsold.RowTemplate.Height = 24;
            this.tbl_month_bestsold.Size = new System.Drawing.Size(270, 122);
            this.tbl_month_bestsold.TabIndex = 18;
            // 
            // Month_bestsold
            // 
            this.Month_bestsold.HeaderText = "Ngày bán chạy nhất của tháng";
            this.Month_bestsold.MinimumWidth = 6;
            this.Month_bestsold.Name = "Month_bestsold";
            // 
            // tbl_revenue_month
            // 
            this.tbl_revenue_month.AllowUserToAddRows = false;
            this.tbl_revenue_month.AllowUserToDeleteRows = false;
            this.tbl_revenue_month.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_revenue_month.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_revenue_month.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.revenue_month});
            this.tbl_revenue_month.Location = new System.Drawing.Point(793, 117);
            this.tbl_revenue_month.Name = "tbl_revenue_month";
            this.tbl_revenue_month.RowHeadersWidth = 51;
            this.tbl_revenue_month.RowTemplate.Height = 24;
            this.tbl_revenue_month.Size = new System.Drawing.Size(272, 133);
            this.tbl_revenue_month.TabIndex = 17;
            // 
            // revenue_month
            // 
            this.revenue_month.HeaderText = "Danh thu ";
            this.revenue_month.MinimumWidth = 6;
            this.revenue_month.Name = "revenue_month";
            // 
            // tblStatCustomer
            // 
            this.tblStatCustomer.AllowUserToAddRows = false;
            this.tblStatCustomer.AllowUserToDeleteRows = false;
            this.tblStatCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblStatCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblStatCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stat_customer_Id,
            this.stat_customer_name,
            this.stat_customer_times,
            this.stat_customer_quantity,
            this.stat_customer_total});
            this.tblStatCustomer.Location = new System.Drawing.Point(0, 248);
            this.tblStatCustomer.Name = "tblStatCustomer";
            this.tblStatCustomer.RowHeadersWidth = 51;
            this.tblStatCustomer.RowTemplate.Height = 24;
            this.tblStatCustomer.Size = new System.Drawing.Size(1065, 244);
            this.tblStatCustomer.TabIndex = 16;
            // 
            // stat_customer_Id
            // 
            this.stat_customer_Id.HeaderText = "Mã KH";
            this.stat_customer_Id.MinimumWidth = 6;
            this.stat_customer_Id.Name = "stat_customer_Id";
            this.stat_customer_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // stat_customer_name
            // 
            this.stat_customer_name.HeaderText = "Tên KH";
            this.stat_customer_name.MinimumWidth = 6;
            this.stat_customer_name.Name = "stat_customer_name";
            this.stat_customer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // stat_customer_times
            // 
            this.stat_customer_times.HeaderText = "Số lần mua hàng";
            this.stat_customer_times.MinimumWidth = 6;
            this.stat_customer_times.Name = "stat_customer_times";
            this.stat_customer_times.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // stat_customer_quantity
            // 
            this.stat_customer_quantity.HeaderText = "Số mặt hàng đã mua";
            this.stat_customer_quantity.MinimumWidth = 6;
            this.stat_customer_quantity.Name = "stat_customer_quantity";
            // 
            // stat_customer_total
            // 
            this.stat_customer_total.HeaderText = "Tổng tiền đã mua ";
            this.stat_customer_total.MinimumWidth = 6;
            this.stat_customer_total.Name = "stat_customer_total";
            // 
            // tblStatItem
            // 
            this.tblStatItem.AllowUserToAddRows = false;
            this.tblStatItem.AllowUserToDeleteRows = false;
            this.tblStatItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblStatItem.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblStatItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tblStatItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblStatItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inven_id,
            this.inven_name,
            this.inven_quantity,
            this.inven_revenue});
            this.tblStatItem.Location = new System.Drawing.Point(0, 0);
            this.tblStatItem.Name = "tblStatItem";
            this.tblStatItem.RowHeadersWidth = 51;
            this.tblStatItem.RowTemplate.Height = 24;
            this.tblStatItem.Size = new System.Drawing.Size(792, 250);
            this.tblStatItem.TabIndex = 15;
            // 
            // inven_id
            // 
            this.inven_id.HeaderText = "Mã MH";
            this.inven_id.MinimumWidth = 6;
            this.inven_id.Name = "inven_id";
            this.inven_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // inven_name
            // 
            this.inven_name.HeaderText = "Tên mặt hàng";
            this.inven_name.MinimumWidth = 6;
            this.inven_name.Name = "inven_name";
            this.inven_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // inven_quantity
            // 
            this.inven_quantity.HeaderText = "Số lượng";
            this.inven_quantity.MinimumWidth = 6;
            this.inven_quantity.Name = "inven_quantity";
            this.inven_quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // inven_revenue
            // 
            this.inven_revenue.HeaderText = "Tổng doanh thu ";
            this.inven_revenue.MinimumWidth = 6;
            this.inven_revenue.Name = "inven_revenue";
            this.inven_revenue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button2);
            this.groupBox11.Controls.Add(this.button1);
            this.groupBox11.Controls.Add(this.nudYear);
            this.groupBox11.Controls.Add(this.nudMonth);
            this.groupBox11.Controls.Add(this.nudDay);
            this.groupBox11.Controls.Add(this.btnStatResult);
            this.groupBox11.Controls.Add(this.label14);
            this.groupBox11.Controls.Add(this.label13);
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Controls.Add(this.comboStat);
            this.groupBox11.Controls.Add(this.label12);
            this.groupBox11.Location = new System.Drawing.Point(0, 498);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1063, 170);
            this.groupBox11.TabIndex = 14;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Thống kê theo tiêu chí";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "Vẽ biểu đồ tròn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnCreateChartPieClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Vẽ biểu đồ cột";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnCreateChartColumnClick);
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(573, 91);
            this.nudYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(80, 24);
            this.nudYear.TabIndex = 16;
            // 
            // nudMonth
            // 
            this.nudMonth.Location = new System.Drawing.Point(381, 91);
            this.nudMonth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(80, 24);
            this.nudMonth.TabIndex = 15;
            // 
            // nudDay
            // 
            this.nudDay.Location = new System.Drawing.Point(158, 91);
            this.nudDay.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(80, 24);
            this.nudDay.TabIndex = 14;
            // 
            // btnStatResult
            // 
            this.btnStatResult.Location = new System.Drawing.Point(850, 61);
            this.btnStatResult.Name = "btnStatResult";
            this.btnStatResult.Size = new System.Drawing.Size(128, 54);
            this.btnStatResult.TabIndex = 7;
            this.btnStatResult.Text = "Xem kết quả";
            this.btnStatResult.UseVisualStyleBackColor = true;
            this.btnStatResult.Click += new System.EventHandler(this.BtnSearchStatClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(308, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 18);
            this.label14.TabIndex = 5;
            this.label14.Text = "Tháng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(510, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "Năm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Ngày:";
            // 
            // comboStat
            // 
            this.comboStat.FormattingEnabled = true;
            this.comboStat.Items.AddRange(new object[] {
            "Các mặt hàng có danh thu tốt nhất",
            "Các khách hàng mua nhiều hàng nhất",
            "Những ngày của tháng bán được nhiều hàng nhất",
            "Danh thu theo tháng của năm cho trước",
            "Danh thu theo ngày của tháng cho trước"});
            this.comboStat.Location = new System.Drawing.Point(158, 45);
            this.comboStat.Name = "comboStat";
            this.comboStat.Size = new System.Drawing.Size(495, 25);
            this.comboStat.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tiêu chí";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thaoTácToolStripMenuItem,
            this.xemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thaoTácToolStripMenuItem
            // 
            this.thaoTácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMớiToolStripMenuItem,
            this.btn_SaveFile,
            this.toolStripSeparator1,
            this.thoátToolStripMenuItem});
            this.thaoTácToolStripMenuItem.Image = global::CSharpCounterFinalProject.Properties.Resources.action;
            this.thaoTácToolStripMenuItem.Name = "thaoTácToolStripMenuItem";
            this.thaoTácToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.thaoTácToolStripMenuItem.Text = "Thao tác";
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAddItem,
            this.mAddCustomer,
            this.mAddDiscount,
            this.mAddBill});
            this.thêmMớiToolStripMenuItem.Image = global::CSharpCounterFinalProject.Properties.Resources.plus;
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thêmMớiToolStripMenuItem.Text = "Thêm mới";
            // 
            // mAddItem
            // 
            this.mAddItem.Image = global::CSharpCounterFinalProject.Properties.Resources.shopping_bag;
            this.mAddItem.Name = "mAddItem";
            this.mAddItem.Size = new System.Drawing.Size(169, 26);
            this.mAddItem.Text = "Mặt hàng";
            this.mAddItem.Click += new System.EventHandler(this.MenuAddView);
            // 
            // mAddCustomer
            // 
            this.mAddCustomer.Image = global::CSharpCounterFinalProject.Properties.Resources.rating;
            this.mAddCustomer.Name = "mAddCustomer";
            this.mAddCustomer.Size = new System.Drawing.Size(169, 26);
            this.mAddCustomer.Text = "Khách hàng";
            this.mAddCustomer.Click += new System.EventHandler(this.MenuAddView);
            // 
            // mAddDiscount
            // 
            this.mAddDiscount.Image = global::CSharpCounterFinalProject.Properties.Resources.discount;
            this.mAddDiscount.Name = "mAddDiscount";
            this.mAddDiscount.Size = new System.Drawing.Size(169, 26);
            this.mAddDiscount.Text = "Khuyến mãi";
            this.mAddDiscount.Click += new System.EventHandler(this.MenuAddView);
            // 
            // mAddBill
            // 
            this.mAddBill.Image = global::CSharpCounterFinalProject.Properties.Resources.bill;
            this.mAddBill.Name = "mAddBill";
            this.mAddBill.Size = new System.Drawing.Size(169, 26);
            this.mAddBill.Text = "Hóa đơn";
            this.mAddBill.Click += new System.EventHandler(this.MenuAddView);
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.Image = global::CSharpCounterFinalProject.Properties.Resources.floppy_disk;
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Size = new System.Drawing.Size(224, 26);
            this.btn_SaveFile.Text = "Lưu file";
            this.btn_SaveFile.Click += new System.EventHandler(this.btnInHDClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::CSharpCounterFinalProject.Properties.Resources.remove;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.BtnCloseApp);
            // 
            // xemToolStripMenuItem
            // 
            this.xemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemTab,
            this.mCustomerTab,
            this.mDiscountTab,
            this.mBillTab});
            this.xemToolStripMenuItem.Image = global::CSharpCounterFinalProject.Properties.Resources.research_center;
            this.xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            this.xemToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.xemToolStripMenuItem.Text = "Xem";
            // 
            // mItemTab
            // 
            this.mItemTab.Image = global::CSharpCounterFinalProject.Properties.Resources.shopping_bag;
            this.mItemTab.Name = "mItemTab";
            this.mItemTab.Size = new System.Drawing.Size(169, 26);
            this.mItemTab.Text = "Mặt hàng";
            this.mItemTab.Click += new System.EventHandler(this.MenuItemViewTabClick);
            // 
            // mCustomerTab
            // 
            this.mCustomerTab.Image = global::CSharpCounterFinalProject.Properties.Resources.rating;
            this.mCustomerTab.Name = "mCustomerTab";
            this.mCustomerTab.Size = new System.Drawing.Size(169, 26);
            this.mCustomerTab.Text = "Khách hàng";
            this.mCustomerTab.Click += new System.EventHandler(this.MenuItemViewTabClick);
            // 
            // mDiscountTab
            // 
            this.mDiscountTab.Image = global::CSharpCounterFinalProject.Properties.Resources.discount;
            this.mDiscountTab.Name = "mDiscountTab";
            this.mDiscountTab.Size = new System.Drawing.Size(169, 26);
            this.mDiscountTab.Text = "Khuyến mãi";
            this.mDiscountTab.Click += new System.EventHandler(this.MenuItemViewTabClick);
            // 
            // mBillTab
            // 
            this.mBillTab.Image = global::CSharpCounterFinalProject.Properties.Resources.bill;
            this.mBillTab.Name = "mBillTab";
            this.mBillTab.Size = new System.Drawing.Size(169, 26);
            this.mBillTab.Text = "Hóa đơn";
            this.mBillTab.Click += new System.EventHandler(this.MenuItemViewTabClick);
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 717);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Quản Lý Bán Hàng";
            this.Load += new System.EventHandler(this.HomeFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabItem.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemFrom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblItem)).EndInit();
            this.tabCustomer.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomer)).EndInit();
            this.tabDiscount.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblDiscount)).EndInit();
            this.tabBill.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblBill)).EndInit();
            this.tabStat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_month_bestsold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_revenue_month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStatCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStatItem)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabItem;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabDiscount;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.TabPage tabStat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tblItem;
        private System.Windows.Forms.Button btnFreshItem;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.RadioButton radioSortItemByProductDate;
        private System.Windows.Forms.RadioButton radioSortItemByQuantity;
        private System.Windows.Forms.RadioButton radioSortItemByName;
        private System.Windows.Forms.RadioButton radioSortItemByPriceDESC;
        private System.Windows.Forms.RadioButton radioSortItemByPriceASC;
        private System.Windows.Forms.ComboBox comboSearchItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericItemFrom;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericItemTo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboSearchCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioSortCustomerByCreatedDate;
        private System.Windows.Forms.RadioButton radioSortCustomerByPoint;
        private System.Windows.Forms.RadioButton radioSortCustomerByBirthDate;
        private System.Windows.Forms.RadioButton radioSortCustomerByName;
        private System.Windows.Forms.RadioButton radioSortCustomerById;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnRefreshCustomer;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.DataGridView tblCustomer;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnSearchDiscount;
        private System.Windows.Forms.TextBox txtSearchDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboSearchDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnRefreshDiscount;
        private System.Windows.Forms.Button btnAddNeuDiscount;
        private System.Windows.Forms.DataGridView tblDiscount;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnSearchBill;
        private System.Windows.Forms.TextBox txtSearchBill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboSearchBill;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnRefreshBill;
        private System.Windows.Forms.Button btnAddNewBill;
        private System.Windows.Forms.DataGridView tblBill;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox comboStat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewButtonColumn tblCustomerEdit;
        private System.Windows.Forms.DataGridViewButtonColumn tblCustomerRemove;
        private System.Windows.Forms.DataGridView tblStatItem;
        private System.Windows.Forms.Button btnStatResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPriceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinPriceToUseDiscount;
        private System.Windows.Forms.DataGridViewButtonColumn tblDiscountEdit;
        private System.Windows.Forms.DataGridViewButtonColumn tblDiscountRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTimeBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDiscountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thaoTácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAddItem;
        private System.Windows.Forms.ToolStripMenuItem mAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem mAddDiscount;
        private System.Windows.Forms.ToolStripMenuItem mAddBill;
        private System.Windows.Forms.ToolStripMenuItem btn_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem xemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemTab;
        private System.Windows.Forms.ToolStripMenuItem mCustomerTab;
        private System.Windows.Forms.ToolStripMenuItem mDiscountTab;
        private System.Windows.Forms.ToolStripMenuItem mBillTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.DataGridViewButtonColumn tblItemEdit;
        private System.Windows.Forms.DataGridViewButtonColumn tblItemRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn inven_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn inven_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn inven_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn inven_revenue;
        private System.Windows.Forms.DataGridView tblStatCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn stat_customer_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stat_customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stat_customer_times;
        private System.Windows.Forms.DataGridViewTextBoxColumn stat_customer_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn stat_customer_total;
        private System.Windows.Forms.DataGridView tbl_month_bestsold;
        private System.Windows.Forms.DataGridView tbl_revenue_month;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenue_month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month_bestsold;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

