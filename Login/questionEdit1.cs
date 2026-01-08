using DevExpress.XtraPrinting;
using QuizAppAttemp2.Properties;
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
using Login.Models;
using QuizAppAttemp2;


namespace Login
{
    public partial class questionEdit1 : Form
    {
        private List<QuizProp> quiz = new List<QuizProp>();
        private Teacher _selectedSubject;

        public questionEdit1(Teacher selectedSubject)
        {
            InitializeComponent();
            _selectedSubject = selectedSubject;
        }

        private string connectionString = @"Data Source=PAGALING\SQLEXPRESS;Initial Catalog=dbRegistration;Integrated Security=True;";

        private void InsertQuestionsToDB(QuizProp quiz)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"INSERT INTO Questions (SubjectName, QuestionID, Question, optionA, optionB, optionC, optionD, Answer) 
                                 VALUES (@SubjectName, @QuestionID, @Question, @optionA, @optionB, @optionC, @optionD, @Answer)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SubjectName", quiz.SubjectName);
            command.Parameters.AddWithValue("@QuestionID", quiz.QuestionID);
            command.Parameters.AddWithValue("@Question", quiz.Question);
            command.Parameters.AddWithValue("@optionA", quiz.optionA);
            command.Parameters.AddWithValue("@optionB", quiz.optionB);
            command.Parameters.AddWithValue("@optionC", quiz.optionC);
            command.Parameters.AddWithValue("@optionD", quiz.optionD);
            command.Parameters.AddWithValue("@Answer", quiz.Answer);

            connection.Open();
            command.ExecuteNonQuery();
        }

        

        public void clearAll()
        {
            txtquestionId.Clear();
            txtquestion.Clear();
            txtoptionA.Clear();
            txtoptionB.Clear();
            txtoptionC.Clear();
            txtoptionD.Clear();
            txtanswer.Clear();
        }

        private List<QuizProp> GetQuestions()
        {
            List<QuizProp> questions = new List<QuizProp>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Questions WHERE SubjectName = @SubjectName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SubjectName", _selectedSubject.SubjectName);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                QuizProp question = new QuizProp
                {
                    SubjectName = Convert.ToString(reader["SubjectName"]),
                    QuestionID = Convert.ToInt32(reader["QuestionID"]),
                    Question = Convert.ToString(reader["Question"]),
                    optionA = Convert.ToString(reader["optionA"]),
                    optionB = Convert.ToString(reader["optionB"]),
                    optionC = Convert.ToString(reader["optionC"]),
                    optionD = Convert.ToString(reader["optionD"]),
                    Answer = Convert.ToString(reader["Answer"])
                };

                questions.Add(question);
            }

            return questions;
        }

        private void UpdateQuestionInDB(QuizProp quiz)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Questions 
                         SET Question = @Question, 
                             optionA = @optionA, 
                             optionB = @optionB, 
                             optionC = @optionC, 
                             optionD = @optionD, 
                             Answer = @Answer
                         WHERE QuestionID = @QuestionID AND SubjectName = @SubjectName";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@SubjectName", quiz.SubjectName);
                command.Parameters.AddWithValue("@QuestionID", quiz.QuestionID);
                command.Parameters.AddWithValue("@Question", quiz.Question);
                command.Parameters.AddWithValue("@optionA", quiz.optionA);
                command.Parameters.AddWithValue("@optionB", quiz.optionB);
                command.Parameters.AddWithValue("@optionC", quiz.optionC);
                command.Parameters.AddWithValue("@optionD", quiz.optionD);
                command.Parameters.AddWithValue("@Answer", quiz.Answer);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void DeleteQuestionFromDB(int questionID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"DELETE FROM Questions WHERE QuestionID = @QuestionID AND SubjectName = @SubjectName";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@QuestionID", questionID);
                command.Parameters.AddWithValue("@SubjectName", _selectedSubject.SubjectName);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void Insert_Click_1(object sender, EventArgs e)
        {
            int QuestionID = Convert.ToInt32(txtquestionId.Text.Trim());
            string Question = txtquestion.Text.Trim();
            string optionA = txtoptionA.Text.Trim();
            string optionB = txtoptionB.Text.Trim();
            string optionC = txtoptionC.Text.Trim();
            string optionD = txtoptionD.Text.Trim();
            string Answer = txtanswer.Text.Trim();

            if (string.IsNullOrEmpty(txtquestionId.Text.Trim()) || string.IsNullOrEmpty(Question) || string.IsNullOrEmpty(optionA) || string.IsNullOrEmpty(optionB) || string.IsNullOrEmpty(optionC) || string.IsNullOrEmpty(optionD) || string.IsNullOrEmpty(Answer))
            {
                MessageBox.Show("Please fill in all the details.");
                return;
            }

            QuizProp updatedQuestion = new QuizProp
            {
                SubjectName = _selectedSubject.SubjectName, // Use the selected subject name
                QuestionID = QuestionID,
                Question = Question,
                optionA = optionA,
                optionB = optionB,
                optionC = optionC,
                optionD = optionD,
                Answer = Answer
            };

            InsertQuestionsToDB(updatedQuestion);
            gcQuestions.DataSource = GetQuestions();

            clearAll();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtquestionId.Text.Trim()))
            {
                MessageBox.Show("Please enter the Question ID to delete.");
                return;
            }

            int QuestionID = Convert.ToInt32(txtquestionId.Text.Trim());

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this question?", "Delete Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteQuestionFromDB(QuestionID);
                MessageBox.Show("Deleted Successfully!");
                gcQuestions.DataSource = GetQuestions();

                clearAll();
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            int QuestionID = Convert.ToInt32(txtquestionId.Text.Trim());
            string Question = txtquestion.Text.Trim();
            string optionA = txtoptionA.Text.Trim();
            string optionB = txtoptionB.Text.Trim();
            string optionC = txtoptionC.Text.Trim();
            string optionD = txtoptionD.Text.Trim();
            string Answer = txtanswer.Text.Trim();

            if (string.IsNullOrEmpty(txtquestionId.Text.Trim()) || string.IsNullOrEmpty(Question) || string.IsNullOrEmpty(optionA) || string.IsNullOrEmpty(optionB) || string.IsNullOrEmpty(optionC) || string.IsNullOrEmpty(optionD) || string.IsNullOrEmpty(Answer))
            {
                MessageBox.Show("Please fill in all the details.");
                return;
            }

            QuizProp updatedQuestion = new QuizProp
            {
                SubjectName = _selectedSubject.SubjectName, // Use the selected subject name
                QuestionID = QuestionID,
                Question = Question,
                optionA = optionA,
                optionB = optionB,
                optionC = optionC,
                optionD = optionD,
                Answer = Answer
            };

            UpdateQuestionInDB(updatedQuestion);
            MessageBox.Show("Updated Successfully!");
            gcQuestions.DataSource = GetQuestions();

            clearAll();
        }

        private void questionEdit1_Load(object sender, EventArgs e)
        {
            gcQuestions.DataSource = GetQuestions();
        }
    }
}
