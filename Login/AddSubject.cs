using DevExpress.XtraEditors;
using Login.Models;
using Login.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class AddSubject : DevExpress.XtraEditors.XtraForm
    {
        // Initialize connection
        private string connectionString = @"Data Source=PAGALING\SQLEXPRESS;Initial Catalog=dbRegistration;Integrated Security=True;";

        public AddSubject()
        {
            InitializeComponent();
        }

        private void InsertTeacherSubjectToDB(Teacher teacher)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"INSERT INTO [dbRegistration].[dbo].[Subject]
                            ([SubjectName], [TeacherSchoolID])
                            VALUES (@SubjectName, @TeacherSchoolID)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SubjectName", teacher.SubjectName);
            command.Parameters.AddWithValue("@TeacherSchoolID", teacher.TeacherSchoolID);

            connection.Open();
            command.ExecuteNonQuery();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Teacher teacherSub = new Teacher();
            teacherSub.SubjectName = teSubjectName.Text.Trim();
            teacherSub.TeacherSchoolID = Settings.Default.CurrentTeacherSchoolID;

            if (string.IsNullOrEmpty(teSubjectName.Text.Trim()))
            {
                MessageBox.Show("Please input a subject name.");
                return;
            }


            InsertTeacherSubjectToDB(teacherSub);

            this.DialogResult = DialogResult.OK;
        }
    }
}