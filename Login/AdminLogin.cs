using DevExpress.XtraEditors;
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
   
    public partial class AdminLogin : DevExpress.XtraEditors.XtraForm
    {
        private Form2 login = new Form2();

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ID = teIDLogin.Text.Trim();
            string password = btnePasswordLogin.Text.Trim();

            if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter ID and password.");
                return;
            }

            bool isValidUser = ValidateUser(ID, password);

            if (isValidUser)
            {
                // Store admin information sa settings sa app
                Settings.Default.CurrentTeacherSchoolID = teIDLogin.Text.Trim();

                MessageBox.Show("Login successful!");
                login.Hide();

                EstudyoAdmin estudyoAdmin = new EstudyoAdmin();
                estudyoAdmin.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid ID or password.");
            }
        }

        private bool ValidateUser(string teacherSchoolID, string password)
        {
            string connectionString = @"Data Source=PAGALING\SQLEXPRESS;Initial Catalog=dbRegistration;Integrated Security=True;Pooling=true;";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT COUNT (*) FROM [dbRegistration].[dbo].[Teacher] WHERE [TeacherSchoolID] = @TeacherSchoolID AND [Password] = @Password";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@TeacherSchoolID", teacherSchoolID);
                    command.Parameters.AddWithValue("@Password", password);

                    sqlConnection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int count = Convert.ToInt32(result);
                        return count > 0;
                    }
                    else
                    {
                        // No matching record found
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        private void btnePasswordLogin_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var tagAction = btnePasswordLogin.Tag.ToString();
            if (tagAction == "hide")
            {
                btnePasswordLogin.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[1];
                btnePasswordLogin.Tag = "show";
                btnePasswordLogin.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                btnePasswordLogin.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[0];
                btnePasswordLogin.Tag = "hide";
                btnePasswordLogin.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}