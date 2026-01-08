using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class EstudyoAdmin : DevExpress.XtraEditors.XtraForm
    {
        public EstudyoAdmin()
        {
            InitializeComponent();
        }

        private void EstudyoAdmin_Load(object sender, EventArgs e)
        {
            ucAdminSubject subjectpage = new ucAdminSubject(this);
            pAdminDashBoard.Controls.Add(subjectpage);
        }
    }
}