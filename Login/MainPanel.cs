using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
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
    public partial class MainPanel : DevExpress.XtraEditors.XtraUserControl
    {
        private string connectionString = @"Data Source=PAGALING\SQLEXPRESS;Initial Catalog=dbRegistration;Integrated Security=True;";

        private EstudyoMain _parentForm;
        public MainPanel(EstudyoMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            gcStudentSubjects.DataSource = GetAllTeacherSubjects();
            tvSubjects.ItemCustomize += tvSubjects_ItemCustomize_1;
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            gcStudentSubjects.DataSource = GetAllTeacherSubjects();
        }

        private void tvSubjects_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            // Get the subject name from the clicked item
            string subjectName = tvSubjects.GetFocusedRowCellValue("SubjectName").ToString();

            // Pass the subjectName to pConfirmation
            pConfirmation pconfirmation = new pConfirmation(_parentForm, subjectName);
            _parentForm.pDashBoard.Controls.Add(pconfirmation);
            pconfirmation.lcSubjectName.Text = subjectName;
            pconfirmation.lcLastName.Text = tvSubjects.GetFocusedRowCellValue("LastName").ToString();
            pconfirmation.lcFirstName.Text = tvSubjects.GetFocusedRowCellValue("FirstName").ToString();
            pconfirmation.Show();
            pconfirmation.BringToFront();
        }

        private List<Teacher> GetAllTeacherSubjects()
        {
            List<Teacher> teacherSubs = new List<Teacher>();

            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"SELECT t.[TeacherID]
                                  ,t.[FirstName]
                                  ,t.[LastName]
	                              ,s.[SubjectID]
	                              ,s.[SubjectName]
                                  ,ISNULL(r.[Percentage], 0) AS [Percentage]
                              FROM [dbRegistration].[dbo].[Teacher] t
                              JOIN [dbRegistration].[dbo].[Subject] s
                              ON t.TeacherSchoolID = s.TeacherSchoolID
                              LEFT JOIN [dbRegistration].[dbo].[Results] r
                              ON s.SubjectName = r.SubjectName";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Teacher teacherSub = new Teacher();
                teacherSub.TeacherID = Convert.ToInt32(reader["TeacherID"]);
                teacherSub.FirstName = Convert.ToString(reader["FirstName"]);
                teacherSub.LastName = Convert.ToString(reader["LastName"]);
                teacherSub.SubjectID = Convert.ToInt32(reader["SubjectID"]);
                teacherSub.SubjectName = Convert.ToString(reader["SubjectName"]);
                teacherSub.Percentage = Convert.ToInt32(reader["Percentage"]);

                teacherSubs.Add(teacherSub);
            }
            return teacherSubs;
        }

        private void tvSubjects_ItemCustomize_1(object sender, TileViewItemCustomizeEventArgs e)
        {
            TileView view = sender as TileView;
            var percentageObj = view.GetRowCellValue(e.RowHandle, "Percentage");

            if (percentageObj == DBNull.Value || percentageObj == null)
            {
                foreach (TileViewItemElement element in e.Item.Elements)
                {
                    if (element.Column != null && element.Column.FieldName == "Percentage")
                    {
                        element.Text = string.Empty;  // Set it to empty if no percentage
                    }
                }
                return;
            }

            int percentage = Convert.ToInt32(percentageObj);

            if (percentage <= 49 && percentage >= 1)
            {
                e.Item.AppearanceItem.Normal.BackColor = Color.Red;
            }
            else if (percentage <= 74 && percentage >= 50)
            {
                e.Item.AppearanceItem.Normal.BackColor = Color.Orange;

            }
            else if (percentage <= 99 && percentage >= 75)
            {
                e.Item.AppearanceItem.Normal.BackColor = Color.Green;
            }
            else if (percentage == 100)
            {
                e.Item.AppearanceItem.Normal.BackColor = Color.SkyBlue;
            }
            else
            {
                e.Item.AppearanceItem.Normal.BackColor = Color.Gray;
            }
        }
    }
}
