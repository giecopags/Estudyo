namespace Login
{
    partial class AdminLogin
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lcID = new DevExpress.XtraEditors.LabelControl();
            this.lcPassword = new DevExpress.XtraEditors.LabelControl();
            this.teIDLogin = new DevExpress.XtraEditors.TextEdit();
            this.btnePasswordLogin = new DevExpress.XtraEditors.ButtonEdit();
            this.btnLogin = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.teIDLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnePasswordLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcID
            // 
            this.lcID.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcID.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcID.Appearance.Options.UseFont = true;
            this.lcID.Appearance.Options.UseForeColor = true;
            this.lcID.Location = new System.Drawing.Point(58, 12);
            this.lcID.Name = "lcID";
            this.lcID.Size = new System.Drawing.Size(18, 18);
            this.lcID.TabIndex = 0;
            this.lcID.Text = "ID";
            // 
            // lcPassword
            // 
            this.lcPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcPassword.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.lcPassword.Appearance.Options.UseFont = true;
            this.lcPassword.Appearance.Options.UseForeColor = true;
            this.lcPassword.Location = new System.Drawing.Point(58, 100);
            this.lcPassword.Name = "lcPassword";
            this.lcPassword.Size = new System.Drawing.Size(73, 18);
            this.lcPassword.TabIndex = 1;
            this.lcPassword.Text = "Password";
            // 
            // teIDLogin
            // 
            this.teIDLogin.Location = new System.Drawing.Point(58, 33);
            this.teIDLogin.Name = "teIDLogin";
            this.teIDLogin.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.teIDLogin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teIDLogin.Properties.Appearance.Options.UseBorderColor = true;
            this.teIDLogin.Properties.Appearance.Options.UseFont = true;
            this.teIDLogin.Properties.AutoHeight = false;
            this.teIDLogin.Size = new System.Drawing.Size(282, 45);
            this.teIDLogin.TabIndex = 3;
            // 
            // btnePasswordLogin
            // 
            this.btnePasswordLogin.Location = new System.Drawing.Point(58, 122);
            this.btnePasswordLogin.Name = "btnePasswordLogin";
            this.btnePasswordLogin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnePasswordLogin.Properties.Appearance.Options.UseFont = true;
            this.btnePasswordLogin.Properties.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnePasswordLogin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnePasswordLogin.Properties.UseSystemPasswordChar = true;
            this.btnePasswordLogin.Size = new System.Drawing.Size(282, 45);
            this.btnePasswordLogin.TabIndex = 4;
            this.btnePasswordLogin.Tag = "hide";
            this.btnePasswordLogin.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnePasswordLogin_ButtonPressed);
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor = System.Drawing.Color.White;
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLogin.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLogin.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogin.CheckedImage = null;
            this.btnLogin.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Image = null;
            this.btnLogin.ImageSize = new System.Drawing.Size(52, 52);
            this.btnLogin.LineColor = System.Drawing.Color.Transparent;
            this.btnLogin.Location = new System.Drawing.Point(109, 181);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.LightCoral;
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.LightCoral;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnLogin.OnPressedColor = System.Drawing.Color.IndianRed;
            this.btnLogin.Radius = 13;
            this.btnLogin.Size = new System.Drawing.Size(182, 32);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "hide_16x16.png");
            this.imageCollection1.Images.SetKeyName(1, "show_16x16.png");
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(398, 228);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnePasswordLogin);
            this.Controls.Add(this.teIDLogin);
            this.Controls.Add(this.lcPassword);
            this.Controls.Add(this.lcID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("AdminLogin.IconOptions.Image")));
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudyo";
            ((System.ComponentModel.ISupportInitialize)(this.teIDLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnePasswordLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lcID;
        private DevExpress.XtraEditors.LabelControl lcPassword;
        private DevExpress.XtraEditors.TextEdit teIDLogin;
        private DevExpress.XtraEditors.ButtonEdit btnePasswordLogin;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnLogin;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}