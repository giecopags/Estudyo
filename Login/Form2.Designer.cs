namespace Login
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.hlRegister = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teEmailLogin = new DevExpress.XtraEditors.TextEdit();
            this.btnePasswordLogin = new DevExpress.XtraEditors.ButtonEdit();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.filteringUIContext1 = new DevExpress.Utils.Filtering.FilteringUIContext(this.components);
            this.btnLogin = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.hlAdminLogin = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.teEmailLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnePasswordLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // hlRegister
            // 
            this.hlRegister.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hlRegister.Appearance.ForeColor = System.Drawing.Color.White;
            this.hlRegister.Appearance.LinkColor = System.Drawing.Color.White;
            this.hlRegister.Appearance.Options.UseFont = true;
            this.hlRegister.Appearance.Options.UseForeColor = true;
            this.hlRegister.Appearance.Options.UseLinkColor = true;
            this.hlRegister.AppearanceHovered.ForeColor = System.Drawing.Color.LightCoral;
            this.hlRegister.AppearanceHovered.LinkColor = System.Drawing.Color.Salmon;
            this.hlRegister.AppearanceHovered.Options.UseForeColor = true;
            this.hlRegister.AppearanceHovered.Options.UseLinkColor = true;
            this.hlRegister.AppearanceHovered.Options.UsePressedColor = true;
            this.hlRegister.AppearanceHovered.PressedColor = System.Drawing.Color.IndianRed;
            this.hlRegister.AppearancePressed.ForeColor = System.Drawing.Color.IndianRed;
            this.hlRegister.AppearancePressed.LinkColor = System.Drawing.Color.LightCoral;
            this.hlRegister.AppearancePressed.Options.UseForeColor = true;
            this.hlRegister.AppearancePressed.Options.UseLinkColor = true;
            this.hlRegister.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.hlRegister.Location = new System.Drawing.Point(374, 172);
            this.hlRegister.Name = "hlRegister";
            this.hlRegister.Size = new System.Drawing.Size(68, 23);
            this.hlRegister.TabIndex = 0;
            this.hlRegister.Text = "Register";
            this.hlRegister.Click += new System.EventHandler(this.hlRegister_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(94, 172);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(209, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "A Mock Exam Application";
            // 
            // teEmailLogin
            // 
            this.teEmailLogin.Location = new System.Drawing.Point(94, 290);
            this.teEmailLogin.Name = "teEmailLogin";
            this.teEmailLogin.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.teEmailLogin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teEmailLogin.Properties.Appearance.Options.UseBorderColor = true;
            this.teEmailLogin.Properties.Appearance.Options.UseFont = true;
            this.teEmailLogin.Properties.AutoHeight = false;
            this.teEmailLogin.Size = new System.Drawing.Size(348, 45);
            this.teEmailLogin.TabIndex = 2;
            // 
            // btnePasswordLogin
            // 
            this.btnePasswordLogin.Location = new System.Drawing.Point(94, 407);
            this.btnePasswordLogin.Name = "btnePasswordLogin";
            this.btnePasswordLogin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnePasswordLogin.Properties.Appearance.Options.UseFont = true;
            this.btnePasswordLogin.Properties.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnePasswordLogin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnePasswordLogin.Properties.UseSystemPasswordChar = true;
            this.btnePasswordLogin.Size = new System.Drawing.Size(348, 45);
            this.btnePasswordLogin.TabIndex = 3;
            this.btnePasswordLogin.Tag = "hide";
            this.btnePasswordLogin.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnePasswordLogin_ButtonPressed);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "hide_16x16.png");
            this.imageCollection1.Images.SetKeyName(1, "show_16x16.png");
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
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Image = null;
            this.btnLogin.ImageSize = new System.Drawing.Size(52, 52);
            this.btnLogin.LineColor = System.Drawing.Color.Transparent;
            this.btnLogin.Location = new System.Drawing.Point(94, 540);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.LightCoral;
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.LightCoral;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnLogin.OnPressedColor = System.Drawing.Color.IndianRed;
            this.btnLogin.Radius = 13;
            this.btnLogin.Size = new System.Drawing.Size(348, 60);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // hlAdminLogin
            // 
            this.hlAdminLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hlAdminLogin.Appearance.ForeColor = System.Drawing.Color.White;
            this.hlAdminLogin.Appearance.LinkColor = System.Drawing.Color.White;
            this.hlAdminLogin.Appearance.Options.UseFont = true;
            this.hlAdminLogin.Appearance.Options.UseForeColor = true;
            this.hlAdminLogin.Appearance.Options.UseLinkColor = true;
            this.hlAdminLogin.AppearanceHovered.ForeColor = System.Drawing.Color.LightCoral;
            this.hlAdminLogin.AppearanceHovered.LinkColor = System.Drawing.Color.Salmon;
            this.hlAdminLogin.AppearanceHovered.Options.UseForeColor = true;
            this.hlAdminLogin.AppearanceHovered.Options.UseLinkColor = true;
            this.hlAdminLogin.AppearanceHovered.Options.UsePressedColor = true;
            this.hlAdminLogin.AppearanceHovered.PressedColor = System.Drawing.Color.IndianRed;
            this.hlAdminLogin.AppearancePressed.ForeColor = System.Drawing.Color.IndianRed;
            this.hlAdminLogin.AppearancePressed.LinkColor = System.Drawing.Color.LightCoral;
            this.hlAdminLogin.AppearancePressed.Options.UseForeColor = true;
            this.hlAdminLogin.AppearancePressed.Options.UseLinkColor = true;
            this.hlAdminLogin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.hlAdminLogin.Location = new System.Drawing.Point(390, 248);
            this.hlAdminLogin.Name = "hlAdminLogin";
            this.hlAdminLogin.Size = new System.Drawing.Size(52, 23);
            this.hlAdminLogin.TabIndex = 5;
            this.hlAdminLogin.Text = "Admin";
            this.hlAdminLogin.Click += new System.EventHandler(this.hlAdminLogin_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1278, 804);
            this.Controls.Add(this.hlAdminLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnePasswordLogin);
            this.Controls.Add(this.teEmailLogin);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.hlRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Form2.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudyo";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teEmailLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnePasswordLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.HyperlinkLabelControl hlRegister;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teEmailLogin;
        private DevExpress.XtraEditors.ButtonEdit btnePasswordLogin;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.Utils.Filtering.FilteringUIContext filteringUIContext1;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnLogin;
        private DevExpress.XtraEditors.HyperlinkLabelControl hlAdminLogin;
    }
}