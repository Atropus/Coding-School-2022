namespace Session78
{
    partial class StudentForm
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
            this.listViewStudentForm = new System.Windows.Forms.ListView();
            this.lblStudentList = new DevExpress.XtraEditors.LabelControl();
            this.btnStudentNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnStudentDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnStudentSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnStudentClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtStudentAge = new DevExpress.XtraEditors.TextEdit();
            this.txtStudentName = new DevExpress.XtraEditors.TextEdit();
            this.txtStudentID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewStudentForm
            // 
            this.listViewStudentForm.Location = new System.Drawing.Point(12, 34);
            this.listViewStudentForm.Name = "listViewStudentForm";
            this.listViewStudentForm.Size = new System.Drawing.Size(242, 404);
            this.listViewStudentForm.TabIndex = 0;
            this.listViewStudentForm.UseCompatibleStateImageBehavior = false;
            // 
            // lblStudentList
            // 
            this.lblStudentList.Location = new System.Drawing.Point(12, 12);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(57, 13);
            this.lblStudentList.TabIndex = 1;
            this.lblStudentList.Text = "Student List";
            // 
            // btnStudentNew
            // 
            this.btnStudentNew.Location = new System.Drawing.Point(281, 394);
            this.btnStudentNew.Name = "btnStudentNew";
            this.btnStudentNew.Size = new System.Drawing.Size(75, 44);
            this.btnStudentNew.TabIndex = 6;
            this.btnStudentNew.Text = "New...";
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(362, 394);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(75, 44);
            this.btnStudentDelete.TabIndex = 7;
            this.btnStudentDelete.Text = "Delete";
            // 
            // btnStudentSave
            // 
            this.btnStudentSave.Location = new System.Drawing.Point(443, 394);
            this.btnStudentSave.Name = "btnStudentSave";
            this.btnStudentSave.Size = new System.Drawing.Size(75, 44);
            this.btnStudentSave.TabIndex = 8;
            this.btnStudentSave.Text = "Save";
            // 
            // btnStudentClose
            // 
            this.btnStudentClose.Location = new System.Drawing.Point(524, 394);
            this.btnStudentClose.Name = "btnStudentClose";
            this.btnStudentClose.Size = new System.Drawing.Size(75, 44);
            this.btnStudentClose.TabIndex = 9;
            this.btnStudentClose.Text = "Close";
            // 
            // txtStudentAge
            // 
            this.txtStudentAge.Location = new System.Drawing.Point(281, 106);
            this.txtStudentAge.Name = "txtStudentAge";
            this.txtStudentAge.Size = new System.Drawing.Size(35, 20);
            this.txtStudentAge.TabIndex = 12;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(281, 70);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(271, 20);
            this.txtStudentName.TabIndex = 11;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(281, 34);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(68, 20);
            this.txtStudentID.TabIndex = 10;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.txtStudentAge);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.btnStudentClose);
            this.Controls.Add(this.btnStudentSave);
            this.Controls.Add(this.btnStudentDelete);
            this.Controls.Add(this.btnStudentNew);
            this.Controls.Add(this.lblStudentList);
            this.Controls.Add(this.listViewStudentForm);
            this.Name = "StudentForm";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewStudentForm;
        private DevExpress.XtraEditors.LabelControl lblStudentList;
        private DevExpress.XtraEditors.SimpleButton btnStudentNew;
        private DevExpress.XtraEditors.SimpleButton btnStudentDelete;
        private DevExpress.XtraEditors.SimpleButton btnStudentSave;
        private DevExpress.XtraEditors.SimpleButton btnStudentClose;
        private DevExpress.XtraEditors.TextEdit txtStudentAge;
        private DevExpress.XtraEditors.TextEdit txtStudentName;
        private DevExpress.XtraEditors.TextEdit txtStudentID;
    }
}