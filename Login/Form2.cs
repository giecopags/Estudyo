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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {

        public Form2()
        {
            InitializeComponent();
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

        private void hlRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = teEmailLogin.Text.Trim();
            string password = btnePasswordLogin.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter email and password.");
                return;
            }

            bool isValidUser = ValidateUser(username, password);

            if (isValidUser)
            {
                EstudyoMain estudyoMain = new EstudyoMain();
                estudyoMain.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        private bool ValidateUser(string username, string password)
        {
            string connectionString = @"Data Source=PAGALING\SQLEXPRESS;Initial Catalog=dbRegistration;Integrated Security=True;Pooling=true;";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT COUNT (*) FROM [dbRegistration].[dbo].[Registration] WHERE [Email] = @Email AND [Password] = @Password";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.Parameters.AddWithValue("@Email", username);
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

        private void hlAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin admin = new AdminLogin();
            admin.BringToFront();
            admin.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

