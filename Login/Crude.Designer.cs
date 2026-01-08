namespace Login
{
    partial class Crude
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crude));
            this.btnAddQuestions = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.teSubjectName = new DevExpress.XtraEditors.TextEdit();
            this.lcSubjectName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.teSubjectName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddQuestions
            // 
            this.btnAddQuestions.Location = new System.Drawing.Point(12, 70);
            this.btnAddQuestions.Name = "btnAddQuestions";
            this.btnAddQuestions.Size = new System.Drawing.Size(95, 45);
            this.btnAddQuestions.TabIndex = 0;
            this.btnAddQuestions.Text = "Add Questions";
            this.btnAddQuestions.Click += new System.EventHandler(this.btnAddQuestions_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(144, 70);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 45);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(269, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // teSubjectName
            // 
            this.teSubjectName.Location = new System.Drawing.Point(125, 35);
            this.teSubjectName.Name = "teSubjectName";
            this.teSubjectName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teSubjectName.Properties.Appearance.Options.UseFont = true;
            this.teSubjectName.Size = new System.Drawing.Size(130, 26);
            this.teSubjectName.TabIndex = 3;
            // 
            // lcSubjectName
            // 
            this.lcSubjectName.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcSubjectName.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.lcSubjectName.Appearance.Options.UseFont = true;
            this.lcSubjectName.Appearance.Options.UseForeColor = true;
            this.lcSubjectName.Location = new System.Drawing.Point(130, 12);
            this.lcSubjectName.Name = "lcSubjectName";
            this.lcSubjectName.Size = new System.Drawing.Size(120, 18);
            this.lcSubjectName.TabIndex = 4;
            this.lcSubjectName.Text = "Subject Name Edit";
            // 
            // Crude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(376, 127);
            this.Controls.Add(this.lcSubjectName);
            this.Controls.Add(this.teSubjectName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Crude.IconOptions.Image")));
            this.Name = "Crude";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudyo";
            ((System.ComponentModel.ISupportInitialize)(this.teSubjectName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAddQuestions;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.TextEdit teSubjectName;
        private DevExpress.XtraEditors.LabelControl lcSubjectName;
    }
}