namespace Session78
{
    partial class ProfessorForm
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
            this.listviewProfessorForm = new System.Windows.Forms.ListView();
            this.lblProfessorList = new DevExpress.XtraEditors.LabelControl();
            this.txtProfessorID = new DevExpress.XtraEditors.TextEdit();
            this.txtProfessorName = new DevExpress.XtraEditors.TextEdit();
            this.txtProfessorAge = new DevExpress.XtraEditors.TextEdit();
            this.btnProfessorNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnProfessorDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnProfessorSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnProfessorClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfessorID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfessorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfessorAge.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listviewProfessorForm
            // 
            this.listviewProfessorForm.Location = new System.Drawing.Point(12, 36);
            this.listviewProfessorForm.Name = "listviewProfessorForm";
            this.listviewProfessorForm.Size = new System.Drawing.Size(226, 402);
            this.listviewProfessorForm.TabIndex = 0;
            this.listviewProfessorForm.UseCompatibleStateImageBehavior = false;
            this.listviewProfessorForm.SelectedIndexChanged += new System.EventHandler(this.listviewProfessorForm_SelectedIndexChanged);
            // 
            // lblProfessorList
            // 
            this.lblProfessorList.Location = new System.Drawing.Point(12, 12);
            this.lblProfessorList.Name = "lblProfessorList";
            this.lblProfessorList.Size = new System.Drawing.Size(65, 13);
            this.lblProfessorList.TabIndex = 1;
            this.lblProfessorList.Text = "Professor List";
            // 
            // txtProfessorID
            // 
            this.txtProfessorID.Location = new System.Drawing.Point(272, 37);
            this.txtProfessorID.Name = "txtProfessorID";
            this.txtProfessorID.Size = new System.Drawing.Size(68, 20);
            this.txtProfessorID.TabIndex = 2;
            // 
            // txtProfessorName
            // 
            this.txtProfessorName.Location = new System.Drawing.Point(272, 73);
            this.txtProfessorName.Name = "txtProfessorName";
            this.txtProfessorName.Size = new System.Drawing.Size(271, 20);
            this.txtProfessorName.TabIndex = 3;
            // 
            // txtProfessorAge
            // 
            this.txtProfessorAge.Location = new System.Drawing.Point(272, 109);
            this.txtProfessorAge.Name = "txtProfessorAge";
            this.txtProfessorAge.Size = new System.Drawing.Size(35, 20);
            this.txtProfessorAge.TabIndex = 4;
            // 
            // btnProfessorNew
            // 
            this.btnProfessorNew.Location = new System.Drawing.Point(265, 394);
            this.btnProfessorNew.Name = "btnProfessorNew";
            this.btnProfessorNew.Size = new System.Drawing.Size(75, 44);
            this.btnProfessorNew.TabIndex = 5;
            this.btnProfessorNew.Text = "New...";
            this.btnProfessorNew.Click += new System.EventHandler(this.btnProfessorNew_Click);
            // 
            // btnProfessorDelete
            // 
            this.btnProfessorDelete.Location = new System.Drawing.Point(346, 394);
            this.btnProfessorDelete.Name = "btnProfessorDelete";
            this.btnProfessorDelete.Size = new System.Drawing.Size(75, 44);
            this.btnProfessorDelete.TabIndex = 6;
            this.btnProfessorDelete.Text = "Delete";
            // 
            // btnProfessorSave
            // 
            this.btnProfessorSave.Location = new System.Drawing.Point(427, 394);
            this.btnProfessorSave.Name = "btnProfessorSave";
            this.btnProfessorSave.Size = new System.Drawing.Size(75, 44);
            this.btnProfessorSave.TabIndex = 7;
            this.btnProfessorSave.Text = "Save";
            this.btnProfessorSave.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btnProfessorClose
            // 
            this.btnProfessorClose.Location = new System.Drawing.Point(508, 394);
            this.btnProfessorClose.Name = "btnProfessorClose";
            this.btnProfessorClose.Size = new System.Drawing.Size(75, 44);
            this.btnProfessorClose.TabIndex = 8;
            this.btnProfessorClose.Text = "Close";
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.btnProfessorClose);
            this.Controls.Add(this.btnProfessorSave);
            this.Controls.Add(this.btnProfessorDelete);
            this.Controls.Add(this.btnProfessorNew);
            this.Controls.Add(this.txtProfessorAge);
            this.Controls.Add(this.txtProfessorName);
            this.Controls.Add(this.txtProfessorID);
            this.Controls.Add(this.lblProfessorList);
            this.Controls.Add(this.listviewProfessorForm);
            this.Name = "ProfessorForm";
            this.Text = "Professor";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtProfessorID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfessorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfessorAge.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ListView listviewProfessorForm;
        private DevExpress.XtraEditors.LabelControl lblProfessorList;
        private DevExpress.XtraEditors.TextEdit txtProfessorID;
        private DevExpress.XtraEditors.TextEdit txtProfessorName;
        private DevExpress.XtraEditors.TextEdit txtProfessorAge;
        private DevExpress.XtraEditors.SimpleButton btnProfessorNew;
        private DevExpress.XtraEditors.SimpleButton btnProfessorDelete;
        private DevExpress.XtraEditors.SimpleButton btnProfessorSave;
        private DevExpress.XtraEditors.SimpleButton btnProfessorClose;
    }
}