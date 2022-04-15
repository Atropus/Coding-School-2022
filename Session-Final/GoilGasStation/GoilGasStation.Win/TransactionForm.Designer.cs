namespace GoilGasStation.Win
{
    partial class TransactionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.grdTransactionLines = new System.Windows.Forms.DataGridView();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserSurname = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.bsTransactionSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNetValue = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountValue = new System.Windows.Forms.TextBox();
            this.txtTotalValue = new System.Windows.Forms.TextBox();
            this.spinQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.cmbDescription = new System.Windows.Forms.ComboBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvlProductCategory = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblNetValue = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.bsItemSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(34, 44);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(79, 15);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Customer Name";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(590, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(30, 15);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User";
            // 
            // grdTransactionLines
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTransactionLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTransactionLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTransactionLines.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdTransactionLines.Location = new System.Drawing.Point(12, 145);
            this.grdTransactionLines.Name = "grdTransactionLines";
            this.grdTransactionLines.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTransactionLines.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdTransactionLines.RowTemplate.Height = 25;
            this.grdTransactionLines.Size = new System.Drawing.Size(776, 222);
            this.grdTransactionLines.TabIndex = 4;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(119, 41);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(228, 23);
            this.txtCardNumber.TabIndex = 0;
            this.txtCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardNumber_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 416);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(632, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(119, 70);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(146, 23);
            this.txtCustomerName.TabIndex = 8;
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(271, 70);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.ReadOnly = true;
            this.txtCustomerSurname.Size = new System.Drawing.Size(175, 23);
            this.txtCustomerSurname.TabIndex = 9;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(428, 27);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(178, 23);
            this.txtUserName.TabIndex = 10;
            // 
            // txtUserSurname
            // 
            this.txtUserSurname.Location = new System.Drawing.Point(612, 27);
            this.txtUserSurname.Name = "txtUserSurname";
            this.txtUserSurname.ReadOnly = true;
            this.txtUserSurname.Size = new System.Drawing.Size(176, 23);
            this.txtUserSurname.TabIndex = 11;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(119, 12);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(228, 23);
            this.txtDate.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(82, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 15);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(601, 113);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(102, 23);
            this.txtPrice.TabIndex = 14;
            // 
            // txtNetValue
            // 
            this.txtNetValue.Location = new System.Drawing.Point(362, 386);
            this.txtNetValue.Name = "txtNetValue";
            this.txtNetValue.ReadOnly = true;
            this.txtNetValue.Size = new System.Drawing.Size(102, 23);
            this.txtNetValue.TabIndex = 16;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(470, 386);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(102, 23);
            this.txtDiscountPercent.TabIndex = 17;
            // 
            // txtDiscountValue
            // 
            this.txtDiscountValue.Location = new System.Drawing.Point(578, 386);
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.ReadOnly = true;
            this.txtDiscountValue.Size = new System.Drawing.Size(102, 23);
            this.txtDiscountValue.TabIndex = 18;
            // 
            // txtTotalValue
            // 
            this.txtTotalValue.Location = new System.Drawing.Point(686, 386);
            this.txtTotalValue.Name = "txtTotalValue";
            this.txtTotalValue.ReadOnly = true;
            this.txtTotalValue.Size = new System.Drawing.Size(102, 23);
            this.txtTotalValue.TabIndex = 19;
            // 
            // spinQuantity
            // 
            this.spinQuantity.Location = new System.Drawing.Point(470, 114);
            this.spinQuantity.Name = "spinQuantity";
            this.spinQuantity.Size = new System.Drawing.Size(120, 23);
            this.spinQuantity.TabIndex = 4;
            // 
            // cmbItemType
            // 
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(108, 114);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(121, 23);
            this.cmbItemType.TabIndex = 1;
            this.cmbItemType.SelectionChangeCommitted += new System.EventHandler(this.cmbItemType_SelectedIndexChanged);
            // 
            // cmbDescription
            // 
            this.cmbDescription.FormattingEnabled = true;
            this.cmbDescription.Location = new System.Drawing.Point(343, 114);
            this.cmbDescription.Name = "cmbDescription";
            this.cmbDescription.Size = new System.Drawing.Size(121, 23);
            this.cmbDescription.TabIndex = 3;
            this.cmbDescription.SelectedIndexChanged += new System.EventHandler(this.cmbDescription_SelectedIndexChanged);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(235, 386);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(121, 23);
            this.cmbPaymentMethod.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(713, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvlProductCategory
            // 
            this.lvlProductCategory.AutoSize = true;
            this.lvlProductCategory.Location = new System.Drawing.Point(119, 96);
            this.lvlProductCategory.Name = "lvlProductCategory";
            this.lvlProductCategory.Size = new System.Drawing.Size(100, 15);
            this.lvlProductCategory.TabIndex = 25;
            this.lvlProductCategory.Text = "Product Category";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(348, 96);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(112, 15);
            this.lblProductDescription.TabIndex = 26;
            this.lblProductDescription.Text = "Product Description";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(497, 96);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.TabIndex = 27;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(612, 96);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(78, 15);
            this.lblProductPrice.TabIndex = 28;
            this.lblProductPrice.Text = "Product Price";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(248, 368);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(99, 15);
            this.lblPaymentMethod.TabIndex = 29;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // lblNetValue
            // 
            this.lblNetValue.AutoSize = true;
            this.lblNetValue.Location = new System.Drawing.Point(370, 368);
            this.lblNetValue.Name = "lblNetValue";
            this.lblNetValue.Size = new System.Drawing.Size(85, 15);
            this.lblNetValue.TabIndex = 30;
            this.lblNetValue.Text = "Total Net Value";
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Location = new System.Drawing.Point(461, 368);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(116, 15);
            this.lblDiscountPercent.TabIndex = 31;
            this.lblDiscountPercent.Text = "Discount Percentage";
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.AutoSize = true;
            this.lblDiscountValue.Location = new System.Drawing.Point(583, 368);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(85, 15);
            this.lblDiscountValue.TabIndex = 32;
            this.lblDiscountValue.Text = "Discount Value";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(703, 368);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(63, 15);
            this.lblTotalValue.TabIndex = 33;
            this.lblTotalValue.Text = "Total Value";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(248, 96);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(80, 15);
            this.lblCode.TabIndex = 35;
            this.lblCode.Text = "Product Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(235, 114);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(102, 23);
            this.txtCode.TabIndex = 2;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(3, 1);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(46, 23);
            this.txtCustomerID.TabIndex = 36;
            this.txtCustomerID.Visible = false;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(583, 56);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(46, 23);
            this.txtEmployeeID.TabIndex = 37;
            this.txtEmployeeID.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(19, 373);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 26);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblDiscountValue);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.lblNetValue);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lvlProductCategory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.cmbDescription);
            this.Controls.Add(this.cmbItemType);
            this.Controls.Add(this.spinQuantity);
            this.Controls.Add(this.txtTotalValue);
            this.Controls.Add(this.txtDiscountValue);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtNetValue);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtUserSurname);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtCustomerSurname);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.grdTransactionLines);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCardNumber);
            this.Name = "TransactionForm";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCardNumber;
        private Label lblName;
        private Label lblUser;
        private DataGridView grdTransactionLines;
        private TextBox txtCardNumber;
        private Button btnClose;
        private Button btnSave;
        private TextBox txtCustomerName;
        private TextBox txtCustomerSurname;
        private TextBox txtUserName;
        private TextBox txtUserSurname;
        private TextBox txtDate;
        private Label lblDate;
        private BindingSource bsTransactionSource;
        private TextBox txtPrice;
        private TextBox txtNetValue;
        private TextBox txtDiscountPercent;
        private TextBox txtDiscountValue;
        private TextBox txtTotalValue;
        private NumericUpDown spinQuantity;
        private ComboBox cmbItemType;
        private ComboBox cmbDescription;
        private ComboBox cmbPaymentMethod;
        private Button btnAdd;
        private Label lvlProductCategory;
        private Label lblProductDescription;
        private Label lblQuantity;
        private Label lblProductPrice;
        private Label lblPaymentMethod;
        private Label lblNetValue;
        private Label lblDiscountPercent;
        private Label lblDiscountValue;
        private Label lblTotalValue;
        private Label lblCode;
        private TextBox txtCode;
        private TextBox txtCustomerID;
        private TextBox txtEmployeeID;
        private BindingSource bsItemSource;
        private Button btnDelete;
    }
}