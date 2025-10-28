using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class FrmShowDish : Form
    {
        public FrmShowDish(string tenMon, string tenNguoi, string pathHinh)
        {
            InitializeComponent();
            lblMonAn.Text = $"Hôm nay ăn món: {tenMon}";
            lblNguoi.Text = $"Người góp món: {tenNguoi}";

            if (System.IO.File.Exists(pathHinh))
            {
                picMonAn.Image = Image.FromFile(pathHinh);
                picMonAn.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMonAn_Click(object sender, EventArgs e)
        {

        }
    }
}
