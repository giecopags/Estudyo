namespace Login
{
    partial class EstudyoAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstudyoAdmin));
            this.pAdminDashBoard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pAdminDashBoard
            // 
            this.pAdminDashBoard.Location = new System.Drawing.Point(-1, 159);
            this.pAdminDashBoard.Name = "pAdminDashBoard";
            this.pAdminDashBoard.Size = new System.Drawing.Size(1920, 840);
            this.pAdminDashBoard.TabIndex = 24;
            // 
            // EstudyoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1918, 998);
            this.Controls.Add(this.pAdminDashBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("EstudyoAdmin.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "EstudyoAdmin";
            this.Text = "EstudyoAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EstudyoAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pAdminDashBoard;
    }
}