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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Login
{
    public partial class EstudyoMain : DevExpress.XtraEditors.XtraForm
    {

       
        public EstudyoMain()
        {
            InitializeComponent();
        }

        private void EstudyoMain_Load(object sender, EventArgs e)
        {
            MainPanel mainpage = new MainPanel(this);
            pDashBoard.Controls.Add(mainpage);
            mainpage.BringToFront();
            mainpage.Show();
        }

        private void lcLeaderboards_Click(object sender, EventArgs e)
        {
            LeaderBoards leaderBoards = new LeaderBoards();
            pDashBoard.Controls.Add(leaderBoards);
            leaderBoards.BringToFront();
            leaderBoards.Show();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            LeaderBoards leaderBoards = new LeaderBoards();
            pDashBoard.Controls.Add(leaderBoards);
            leaderBoards.BringToFront();
            leaderBoards.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainPanel mainpage = new MainPanel(this);
            pDashBoard.Controls.Add(mainpage);
            mainpage.BringToFront();
            mainpage.Show();
        }

        private void lcShop_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop(this);
            pDashBoard.Controls.Add(shop);
            shop.BringToFront();
            shop.Show();
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop(this);
            pDashBoard.Controls.Add(shop);
            shop.BringToFront();
            shop.Show();
        }

        private void lcAchievements_Click(object sender, EventArgs e)
        {
            Achievements achievements = new Achievements();
            pDashBoard.Controls.Add(achievements);
            achievements.BringToFront();
            achievements.Show();
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            Achievements achievements = new Achievements();
            pDashBoard.Controls.Add(achievements);
            achievements.BringToFront();
            achievements.Show();
        }

        private void pDashBoard_Paint(object sender, PaintEventArgs e)
        {
        }

        public void UpdateImgValue(Image value)
        {
            pictureEdit1.Image = value;
        }


    }
}