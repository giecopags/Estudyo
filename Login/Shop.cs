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
    public partial class Shop : DevExpress.XtraEditors.XtraUserControl
    {

        private EstudyoMain _parentForm;

        public Shop(EstudyoMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            ucItem ucitem = new ucItem();
            pProfile.Controls.Add(ucitem);
            ucitem.BringToFront();
            ucitem.Show();

            lcCoins.Text = "50";
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            _parentForm.pictureEdit1.Image = Image.FromFile("C:\\Users\\Blaze\\Downloads\\image-80x80.jpg");
        }
    }
}
