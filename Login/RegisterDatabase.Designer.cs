namespace Login
{
    partial class RegisterDatabase
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
            this.gcUserDatabase = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcUserDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUserDatabase
            // 
            this.gcUserDatabase.Location = new System.Drawing.Point(28, 49);
            this.gcUserDatabase.MainView = this.gridView1;
            this.gcUserDatabase.Name = "gcUserDatabase";
            this.gcUserDatabase.Size = new System.Drawing.Size(548, 443);
            this.gcUserDatabase.TabIndex = 0;
            this.gcUserDatabase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcUserDatabase;
            this.gridView1.Name = "gridView1";
            // 
            // RegisterDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcUserDatabase);
            this.Name = "RegisterDatabase";
            this.Size = new System.Drawing.Size(606, 620);
            ((System.ComponentModel.ISupportInitialize)(this.gcUserDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcUserDatabase;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
