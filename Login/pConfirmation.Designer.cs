namespace Login
{
    partial class pConfirmation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pConfirmation));
            this.btnProceed = new Guna.UI.WinForms.GunaButton();
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.lcSubjectName = new DevExpress.XtraEditors.LabelControl();
            this.lcLastName = new DevExpress.XtraEditors.LabelControl();
            this.lcFirstName = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btnProceed
            // 
            this.btnProceed.AnimationHoverSpeed = 0.07F;
            this.btnProceed.AnimationSpeed = 0.03F;
            this.btnProceed.BackColor = System.Drawing.Color.Transparent;
            this.btnProceed.BaseColor = System.Drawing.Color.LimeGreen;
            this.btnProceed.BorderColor = System.Drawing.Color.Black;
            this.btnProceed.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProceed.FocusedColor = System.Drawing.Color.Empty;
            this.btnProceed.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Image = null;
            this.btnProceed.ImageSize = new System.Drawing.Size(20, 20);
            this.btnProceed.Location = new System.Drawing.Point(940, 641);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.OnHoverBaseColor = System.Drawing.Color.ForestGreen;
            this.btnProceed.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProceed.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProceed.OnHoverImage = null;
            this.btnProceed.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnProceed.Radius = 65;
            this.btnProceed.Size = new System.Drawing.Size(260, 125);
            this.btnProceed.TabIndex = 0;
            this.btnProceed.Text = "READY!";
            this.btnProceed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.Brown;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(1315, 641);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.Firebrick;
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnCancel.Radius = 65;
            this.btnCancel.Size = new System.Drawing.Size(260, 125);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "I\'LL REVIEW FIRST";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lcSubjectName
            // 
            this.lcSubjectName.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcSubjectName.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.lcSubjectName.Appearance.Options.UseFont = true;
            this.lcSubjectName.Appearance.Options.UseForeColor = true;
            this.lcSubjectName.Appearance.Options.UseTextOptions = true;
            this.lcSubjectName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lcSubjectName.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.lcSubjectName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lcSubjectName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lcSubjectName.Location = new System.Drawing.Point(299, 335);
            this.lcSubjectName.MaximumSize = new System.Drawing.Size(360, 0);
            this.lcSubjectName.Name = "lcSubjectName";
            this.lcSubjectName.Size = new System.Drawing.Size(360, 67);
            this.lcSubjectName.TabIndex = 2;
            this.lcSubjectName.Text = "Subject Name";
            // 
            // lcLastName
            // 
            this.lcLastName.Appearance.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcLastName.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.lcLastName.Appearance.Options.UseFont = true;
            this.lcLastName.Appearance.Options.UseForeColor = true;
            this.lcLastName.Location = new System.Drawing.Point(384, 645);
            this.lcLastName.Name = "lcLastName";
            this.lcLastName.Size = new System.Drawing.Size(130, 26);
            this.lcLastName.TabIndex = 3;
            this.lcLastName.Text = "Last Name";
            // 
            // lcFirstName
            // 
            this.lcFirstName.Appearance.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcFirstName.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.lcFirstName.Appearance.Options.UseFont = true;
            this.lcFirstName.Appearance.Options.UseForeColor = true;
            this.lcFirstName.Location = new System.Drawing.Point(384, 674);
            this.lcFirstName.Name = "lcFirstName";
            this.lcFirstName.Size = new System.Drawing.Size(137, 26);
            this.lcFirstName.TabIndex = 4;
            this.lcFirstName.Text = "First Name";
            // 
            // pConfirmation
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.lcFirstName);
            this.Controls.Add(this.lcLastName);
            this.Controls.Add(this.lcSubjectName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProceed);
            this.Name = "pConfirmation";
            this.Size = new System.Drawing.Size(1920, 840);
            this.Load += new System.EventHandler(this.pConfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnProceed;
        private Guna.UI.WinForms.GunaButton btnCancel;
        public DevExpress.XtraEditors.LabelControl lcSubjectName;
        public DevExpress.XtraEditors.LabelControl lcLastName;
        public DevExpress.XtraEditors.LabelControl lcFirstName;
    }
}
