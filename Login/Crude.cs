using DevExpress.XtraEditors;
using Login.Models;
using QuizAppAttemp2;
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
    public partial class Crude : DevExpress.XtraEditors.XtraForm
    {
        private Teacher _selectedSubject;
        private ucAdminSubject _parentForm;

        public Crude(Teacher selectedSubject, ucAdminSubject parentForm)
        {
            InitializeComponent();
            _selectedSubject = selectedSubject;
            _parentForm = parentForm;
            teSubjectName.Text = _selectedSubject.SubjectName; // Populate subject name in text box
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=PAGALING\SQLEXPRESS;Initial Catalog=dbRegistration;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE [dbo].[Subject] SET SubjectName = @subjectName WHERE SubjectID = @subjectID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@subjectName", teSubjectName.Text); // Use text box value
                command.Parameters.AddWithValue("@subjectID", _selectedSubject.SubjectID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            _parentForm.LoadSubjects();
            this.Close();
        }

        private void btnAddQuestions_Click(object sender, EventArgs e)
        {
            questionEdit1 questionForm = new questionEdit1(_selectedSubject);
            questionForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=PAGALING\SQLEXPRESS;Initial Catalog=dbRegistration;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM [dbo].[Subject] WHERE SubjectID = @subjectID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@subjectID", _selectedSubject.SubjectID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            _parentForm.LoadSubjects(); // Refresh the grid control data source after deletion
            this.Close();
        }
    }
}