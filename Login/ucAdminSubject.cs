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
    public partial class ucAdminSubject : DevExpress.XtraEditors.XtraUserControl
    {
        // Initialize connection
        private string connectionString = @"Data Source=PAGALING\SQLEXPRESS;Initial Catalog=dbRegistration;Integrated Security=True;";

        private EstudyoAdmin _parentAdminForm;
        public ucAdminSubject(EstudyoAdmin parentAdminForm)
        {
            InitializeComponent();
            _parentAdminForm = parentAdminForm;
        }

        private void ucAdminSubject_Load(object sender, EventArgs e)
        {
            gcSubjects.DataSource = GetSubjectsByTeacherSchoolID(Settings.Default.CurrentTeacherSchoolID);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddSubject addSubject = new AddSubject();

            if(addSubject.ShowDialog() == DialogResult.OK)
            {
                gcSubjects.DataSource = GetSubjectsByTeacherSchoolID(Settings.Default.CurrentTeacherSchoolID);
            }
        }

        private List<Teacher> GetSubjectsByTeacherSchoolID(string teacherSchoolID)
        {
            List<Teacher> teacherSubs = new List<Teacher>();

            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"SELECT t.[TeacherID]
                                   ,t.[FirstName]
                                   ,t.[LastName]
	                               ,s.[SubjectID]
	                               ,s.[SubjectName]
                              FROM [dbRegistration].[dbo].[Teacher] t
                              JOIN [dbRegistration].[dbo].[Subject] s
                              ON t.TeacherSchoolID = s.TeacherSchoolID
                              WHERE t.[TeacherSchoolID] = @teacherSchoolID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@teacherSchoolID", teacherSchoolID);

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

                teacherSubs.Add(teacherSub);
            }

            return teacherSubs;
        }

        private void tvSubjects_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            var selectedRow = (Teacher)tvSubjects.GetRow(e.Item.RowHandle);
            Crude crud = new Crude(selectedRow, this);
            crud.BringToFront();
            crud.Show();
        }
        public void LoadSubjects()
        {
            gcSubjects.DataSource = GetSubjectsByTeacherSchoolID(Settings.Default.CurrentTeacherSchoolID);
        }
    }
}
