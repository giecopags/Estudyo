using DevExpress.XtraEditors;
using Login.Models;
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
    public partial class AdminRegister : DevExpress.XtraEditors.XtraForm
    {
        private List<Teacher> admin = new List<Teacher>();

        private string connectionString = @"Data Source=PAGALING\SQLEXPRESS;Initial Catalog=dbRegistration;Integrated Security=True;";
        public AdminRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = teFirstName.Text.Trim();
            string lastName = teLastName.Text.Trim();
            string ID = teID.Text.Trim();
            string password = btnePassword.Text.Trim();
            string confirmPassword = teConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all the details.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password does not match.");
                return;
            }

            Teacher newTeacher = new Teacher();

            //Initializing User
            newTeacher.FirstName = teFirstName.Text;
            newTeacher.LastName = teLastName.Text;
            newTeacher.TeacherSchoolID = teID.Text;
            newTeacher.Password = btnePassword.Text;

            admin.Add(newTeacher);
            InsertTeacherToDB(newTeacher);
            MessageBox.Show("Registered Successfully!");

            Visible = false;
        }

        private void InsertTeacherToDB(Teacher teacher)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"INSERT INTO Teacher (FirstName, LastName, TeacherSchoolID, Password) 
                                 VALUES (@FirstName, @LastName, @TeacherSchoolID, @Password)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", teacher.FirstName);
            command.Parameters.AddWithValue("@LastName", teacher.LastName);
            command.Parameters.AddWithValue("@TeacherSchoolID", teacher.TeacherSchoolID);
            command.Parameters.AddWithValue("@Password", teacher.Password);

            connection.Open();
            command.ExecuteNonQuery();
        }

        private void btnePassword_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var tagAction = btnePassword.Tag.ToString();
            if (tagAction == "hide")
            {
                btnePassword.Properties.Buttons[0].ImageOptions.Image = imageCollection2.Images[0];
                btnePassword.Tag = "show";
                btnePassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                btnePassword.Properties.Buttons[0].ImageOptions.Image = imageCollection2.Images[1];
                btnePassword.Tag = "hide";
                btnePassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void teConfirmPassword_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var tagAction = teConfirmPassword.Tag.ToString();
            if (tagAction == "hide")
            {
                teConfirmPassword.Properties.Buttons[0].ImageOptions.Image = imageCollection2.Images[0];
                teConfirmPassword.Tag = "show";
                teConfirmPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                teConfirmPassword.Properties.Buttons[0].ImageOptions.Image = imageCollection2.Images[1];
                teConfirmPassword.Tag = "hide";
                teConfirmPassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void hlRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            Visible = false;
        }
    }
}