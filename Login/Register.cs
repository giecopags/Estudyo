using DevExpress.XtraEditors;
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

    public partial class Register : DevExpress.XtraEditors.XtraForm
    {
        private List<UserRegistration> students = new List<UserRegistration>();

        private static SqlCommand sqlCommand;
        private static SqlDataReader sqlDataReader;
        private static SqlDataAdapter sqlDataAdapter;
        private static DataTable dataTable;

        private static StringBuilder stringBuilder;

        // Initialize connection
        private static SqlConnection sqlConnection = new SqlConnection(@"Data Source=PAGALING\SQLEXPRESS;Initial Catalog=dbRegistration;Integrated Security=True;");

        public Register()
        {
            InitializeComponent();
        }

        private void InsertDataToDB()
        {
            stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("INSERT INTO [dbRegistration].[dbo].[Registration] ");
            stringBuilder.AppendLine("([FirstName], [LastName], [Course], [Email], [Password])");
            stringBuilder.AppendLine("VALUES (@FirstName, @LastName, @Course, @Email, @Password) ");

            sqlCommand = new SqlCommand(stringBuilder.ToString(), sqlConnection);
            sqlCommand.Parameters.Add("@FirstName", teFirstName.Text);
            sqlCommand.Parameters.Add("@LastName", teLastName.Text);
            sqlCommand.Parameters.Add("@Course", cbCourse.Text);
            sqlCommand.Parameters.Add("@Email", teEmail.Text);
            sqlCommand.Parameters.Add("@Password", tePassword.Text);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = teFirstName.Text.Trim();
            string lastName = teLastName.Text.Trim();
            string course = cbCourse.Text.Trim();
            string email = teEmail.Text.Trim();
            string password = tePassword.Text.Trim();
            string confirmPassword = teConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(course) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all the details.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password does not match.");
                return;
            }

            UserRegistration newUser = new UserRegistration();

            //Initializing User
            newUser.FirstName = teFirstName.Text;
            newUser.LastName = teLastName.Text;
            newUser.Course = cbCourse.Text;
            newUser.Email = teEmail.Text;
            newUser.Password = tePassword.Text;

            students.Add(newUser);
            InsertDataToDB();
            MessageBox.Show("Registered Successfully!");

            Visible = false;
        }

        private void btnPassword_ButtonPressed_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var tagAction = tePassword.Tag.ToString();
            if (tagAction == "hide")
            {
                tePassword.Properties.Buttons[0].ImageOptions.Image = imageCollection2.Images[0];
                tePassword.Tag = "show";
                tePassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                tePassword.Properties.Buttons[0].ImageOptions.Image = imageCollection2.Images[1];
                tePassword.Tag = "hide";
                tePassword.Properties.UseSystemPasswordChar = true;
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
            AdminRegister admin = new AdminRegister();
            admin.BringToFront();
            admin.Show();
            Visible = false;
        }
    }
}