using DevExpress.XtraEditors;
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
    public partial class pConfirmation : DevExpress.XtraEditors.XtraUserControl
    {
        private string connectionString = @"Data Source=PAGALING\SQLEXPRESS;Initial Catalog=dbRegistration;Integrated Security=True;";

        private EstudyoMain _parentForm;
        private string _subjectName;

        public pConfirmation(EstudyoMain parentForm, string subjectName)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _subjectName = subjectName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainPanel mainpage = new MainPanel(_parentForm);
            _parentForm.pDashBoard.Controls.Add(mainpage);
            mainpage.BringToFront();
            mainpage.Show();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (AreQuestionsAvailable(_subjectName))
            {
                QuizApp quizApp = new QuizApp(_subjectName);
                quizApp.Show();
            }
            else
            {
                MessageBox.Show("No available questions for this subject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pConfirmation_Load(object sender, EventArgs e)
        {

        }
        private bool AreQuestionsAvailable(string subjectName)
        {
            string query = "SELECT COUNT(*) FROM Questions WHERE SubjectName = @SubjectName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SubjectName", subjectName);

                try
                {
                    connection.Open();
                    int questionCount = (int)command.ExecuteScalar();
                    return questionCount > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking for available questions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
