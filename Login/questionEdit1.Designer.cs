namespace Login
{
    partial class questionEdit1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(questionEdit1));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcQuestions = new DevExpress.XtraGrid.GridControl();
            this.txtquestionId = new System.Windows.Forms.TextBox();
            this.questionIdLable = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.txtoptionD = new System.Windows.Forms.TextBox();
            this.txtoptionC = new System.Windows.Forms.TextBox();
            this.txtoptionB = new System.Windows.Forms.TextBox();
            this.txtoptionA = new System.Windows.Forms.TextBox();
            this.txtquestion = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.optiondLabel = new System.Windows.Forms.Label();
            this.optioncLabel = new System.Windows.Forms.Label();
            this.optionbLabel = new System.Windows.Forms.Label();
            this.optionaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcQuestions;
            this.gridView1.Name = "gridView1";
            // 
            // gcQuestions
            // 
            this.gcQuestions.Location = new System.Drawing.Point(0, 389);
            this.gcQuestions.MainView = this.gridView1;
            this.gcQuestions.Name = "gcQuestions";
            this.gcQuestions.Size = new System.Drawing.Size(799, 316);
            this.gcQuestions.TabIndex = 42;
            this.gcQuestions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // txtquestionId
            // 
            this.txtquestionId.Location = new System.Drawing.Point(281, 34);
            this.txtquestionId.Name = "txtquestionId";
            this.txtquestionId.Size = new System.Drawing.Size(374, 20);
            this.txtquestionId.TabIndex = 41;
            // 
            // questionIdLable
            // 
            this.questionIdLable.AutoSize = true;
            this.questionIdLable.BackColor = System.Drawing.Color.Transparent;
            this.questionIdLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionIdLable.Location = new System.Drawing.Point(167, 34);
            this.questionIdLable.Name = "questionIdLable";
            this.questionIdLable.Size = new System.Drawing.Size(96, 21);
            this.questionIdLable.TabIndex = 40;
            this.questionIdLable.Text = "QuestionID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(580, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(432, 334);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(281, 334);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 37;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click_1);
            // 
            // txtanswer
            // 
            this.txtanswer.Location = new System.Drawing.Point(281, 281);
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.Size = new System.Drawing.Size(374, 20);
            this.txtanswer.TabIndex = 36;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.BackColor = System.Drawing.Color.Transparent;
            this.answerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(167, 281);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(66, 21);
            this.answerLabel.TabIndex = 35;
            this.answerLabel.Text = "Answer";
            // 
            // txtoptionD
            // 
            this.txtoptionD.Location = new System.Drawing.Point(281, 240);
            this.txtoptionD.Name = "txtoptionD";
            this.txtoptionD.Size = new System.Drawing.Size(374, 20);
            this.txtoptionD.TabIndex = 34;
            // 
            // txtoptionC
            // 
            this.txtoptionC.Location = new System.Drawing.Point(281, 198);
            this.txtoptionC.Name = "txtoptionC";
            this.txtoptionC.Size = new System.Drawing.Size(374, 20);
            this.txtoptionC.TabIndex = 33;
            // 
            // txtoptionB
            // 
            this.txtoptionB.Location = new System.Drawing.Point(281, 156);
            this.txtoptionB.Name = "txtoptionB";
            this.txtoptionB.Size = new System.Drawing.Size(374, 20);
            this.txtoptionB.TabIndex = 32;
            // 
            // txtoptionA
            // 
            this.txtoptionA.Location = new System.Drawing.Point(281, 114);
            this.txtoptionA.Name = "txtoptionA";
            this.txtoptionA.Size = new System.Drawing.Size(374, 20);
            this.txtoptionA.TabIndex = 31;
            // 
            // txtquestion
            // 
            this.txtquestion.Location = new System.Drawing.Point(281, 72);
            this.txtquestion.Name = "txtquestion";
            this.txtquestion.Size = new System.Drawing.Size(374, 20);
            this.txtquestion.TabIndex = 30;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(167, 72);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(79, 21);
            this.questionLabel.TabIndex = 29;
            this.questionLabel.Text = "Question";
            // 
            // optiondLabel
            // 
            this.optiondLabel.AutoSize = true;
            this.optiondLabel.BackColor = System.Drawing.Color.Transparent;
            this.optiondLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optiondLabel.Location = new System.Drawing.Point(166, 240);
            this.optiondLabel.Name = "optiondLabel";
            this.optiondLabel.Size = new System.Drawing.Size(77, 21);
            this.optiondLabel.TabIndex = 28;
            this.optiondLabel.Text = "option D";
            // 
            // optioncLabel
            // 
            this.optioncLabel.AutoSize = true;
            this.optioncLabel.BackColor = System.Drawing.Color.Transparent;
            this.optioncLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optioncLabel.Location = new System.Drawing.Point(167, 198);
            this.optioncLabel.Name = "optioncLabel";
            this.optioncLabel.Size = new System.Drawing.Size(75, 21);
            this.optioncLabel.TabIndex = 27;
            this.optioncLabel.Text = "option C";
            // 
            // optionbLabel
            // 
            this.optionbLabel.AutoSize = true;
            this.optionbLabel.BackColor = System.Drawing.Color.Transparent;
            this.optionbLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionbLabel.Location = new System.Drawing.Point(166, 156);
            this.optionbLabel.Name = "optionbLabel";
            this.optionbLabel.Size = new System.Drawing.Size(75, 21);
            this.optionbLabel.TabIndex = 26;
            this.optionbLabel.Text = "option B";
            // 
            // optionaLabel
            // 
            this.optionaLabel.AutoSize = true;
            this.optionaLabel.BackColor = System.Drawing.Color.Transparent;
            this.optionaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionaLabel.Location = new System.Drawing.Point(166, 114);
            this.optionaLabel.Name = "optionaLabel";
            this.optionaLabel.Size = new System.Drawing.Size(76, 21);
            this.optionaLabel.TabIndex = 25;
            this.optionaLabel.Text = "option A";
            // 
            // questionEdit1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 704);
            this.Controls.Add(this.gcQuestions);
            this.Controls.Add(this.txtquestionId);
            this.Controls.Add(this.questionIdLable);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.txtoptionD);
            this.Controls.Add(this.txtoptionC);
            this.Controls.Add(this.txtoptionB);
            this.Controls.Add(this.txtoptionA);
            this.Controls.Add(this.txtquestion);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.optiondLabel);
            this.Controls.Add(this.optioncLabel);
            this.Controls.Add(this.optionbLabel);
            this.Controls.Add(this.optionaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "questionEdit1";
            this.Text = "Estudyo";
            this.Load += new System.EventHandler(this.questionEdit1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcQuestions;
        private System.Windows.Forms.TextBox txtquestionId;
        private System.Windows.Forms.Label questionIdLable;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox txtoptionD;
        private System.Windows.Forms.TextBox txtoptionC;
        private System.Windows.Forms.TextBox txtoptionB;
        private System.Windows.Forms.TextBox txtoptionA;
        private System.Windows.Forms.TextBox txtquestion;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label optiondLabel;
        private System.Windows.Forms.Label optioncLabel;
        private System.Windows.Forms.Label optionbLabel;
        private System.Windows.Forms.Label optionaLabel;
    }
}