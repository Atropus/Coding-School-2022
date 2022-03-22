namespace Session_11
{
    partial class AddNewPetForm
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
            this.ctrlAnimalType = new DevExpress.XtraEditors.LabelControl();
            this.ctrlBreed = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmbAnimalType = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtBreed = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtCost = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBreed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlAnimalType
            // 
            this.ctrlAnimalType.Location = new System.Drawing.Point(14, 43);
            this.ctrlAnimalType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlAnimalType.Name = "ctrlAnimalType";
            this.ctrlAnimalType.Size = new System.Drawing.Size(67, 16);
            this.ctrlAnimalType.TabIndex = 6;
            this.ctrlAnimalType.Text = "AnimalType";
            // 
            // ctrlBreed
            // 
            this.ctrlBreed.Location = new System.Drawing.Point(14, 89);
            this.ctrlBreed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlBreed.Name = "ctrlBreed";
            this.ctrlBreed.Size = new System.Drawing.Size(33, 16);
            this.ctrlBreed.TabIndex = 7;
            this.ctrlBreed.Text = "Breed";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 143);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 16);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Status";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 299);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(217, 299);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Location = new System.Drawing.Point(107, 37);
            this.cmbAnimalType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(181, 28);
            this.cmbAnimalType.TabIndex = 12;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(107, 129);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(181, 28);
            this.cmbStatus.TabIndex = 13;
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(107, 80);
            this.txtBreed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(181, 22);
            this.txtBreed.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 197);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 16);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Price";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 245);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 16);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Cost";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(107, 188);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPrice.Size = new System.Drawing.Size(90, 22);
            this.txtPrice.TabIndex = 18;
            this.txtPrice.EditValueChanged += new System.EventHandler(this.txtPrice_EditValueChanged);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(107, 236);
            this.txtCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCost.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCost.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCost.Size = new System.Drawing.Size(90, 22);
            this.txtCost.TabIndex = 19;
            // 
            // AddNewPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 418);
            this.ControlBox = false;
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbAnimalType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.ctrlBreed);
            this.Controls.Add(this.ctrlAnimalType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewPetForm";
            this.Text = "New Pet";
            this.Load += new System.EventHandler(this.AddNewPetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBreed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl ctrlAnimalType;
        private DevExpress.XtraEditors.LabelControl ctrlBreed;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private ComboBox cmbAnimalType;
        private ComboBox cmbStatus;
        private DevExpress.XtraEditors.TextEdit txtBreed;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.TextEdit txtCost;
    }
}