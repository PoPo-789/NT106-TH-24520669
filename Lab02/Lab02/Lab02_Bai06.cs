using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02
{
    public partial class Lab02_Bai06 : Form
    {
        public Lab02_Bai06()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SQLiteConnection.CreateFile("DataBai06.db");
            string connectionString = "Data Source=DataBai06.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sqlNguoiDung = @"
                    CREATE TABLE IF NOT EXISTS NguoiDung (
                        IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                        HoVaTen TEXT NOT NULL,
                        QuyenHan TEXT
                    );";

                string sqlMonAn = @"
                    CREATE TABLE IF NOT EXISTS MonAn (
                        IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                        TenMonAn TEXT NOT NULL,
                        HinhAnh TEXT,
                        IDNCC INTEGER,
                        FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC)
                    );";

                using (SQLiteCommand cmd1 = new SQLiteCommand(sqlNguoiDung, conn))
                    cmd1.ExecuteNonQuery();

                using (SQLiteCommand cmd2 = new SQLiteCommand(sqlMonAn, conn))
                    cmd2.ExecuteNonQuery();

                MessageBox.Show("Kết nối CSDL thành công");
            }
        }

        private void Lab02_Bai06_Load(object sender, EventArgs e)
        {
            listViewDish.View = View.Details;
            listViewDish.Columns.Add("ID", 50);
            listViewDish.Columns.Add("Tên món ăn", 150);
            listViewDish.Columns.Add("Nhà cung cấp", 100);
            listViewUser.View = View.Details;
            listViewUser.Columns.Add("ID", 50);
            listViewUser.Columns.Add("Họ và tên", 180);
            listViewUser.Columns.Add("Quyền hạn", 120);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SQLiteConnection("Data Source=DataBai06.db;Version=3;"))
                {
                    conn.Open();
                    string sql = "INSERT INTO NguoiDung (IDNCC, HoVaTen, QuyenHan) VALUES (@ID, @ten, @quyen)";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", tbIDUser.Text);
                        cmd.Parameters.AddWithValue("@ten", tbNameUser.Text);
                        cmd.Parameters.AddWithValue("@quyen", tbAthorUser.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm người dùng thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thêm người dùng được");
            }
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SQLiteConnection("Data Source=DataBai06.db;Version=3;"))
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
                        cmd.ExecuteNonQuery();

                    string sql = "INSERT INTO MonAn (IDMA, TenMonAn, HinhAnh, IDNCC) VALUES (@IDMA, @TenMonAn, @HinhAnh, @IDNCC)";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDMA", tbIDDish.Text);
                        cmd.Parameters.AddWithValue("@TenMonAn", tbNameDish.Text);
                        cmd.Parameters.AddWithValue("@HinhAnh", tbPicDish.Text);
                        cmd.Parameters.AddWithValue("@IDNCC", tbIDUser.Text);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("Thêm món ăn thành công");
                    }
                }
            }
            catch (SQLiteException ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                    MessageBox.Show("Lỗi không tồn tại id người dùng trong CSDL");
                else
                {
                    MessageBox.Show("Lỗi chưa kết nối với CSDL");
                }
            }
        }

        private void btnAddPicDish_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Hình ảnh (*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbPicDish.Text = ofd.FileName;
            }
        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SQLiteConnection("Data Source=DataBai06.db;Version=3;"))
                {
                    conn.Open();
                    string sql = "SELECT * FROM MonAn ORDER BY RANDOM() LIMIT 1;";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string ten = reader["TenMonAn"].ToString();
                            string hinhanh = reader["HinhAnh"].ToString();

                            string idNguoi = reader["IDNCC"].ToString();

                            string tenNguoi = "Không rõ";
                            using (var cmd2 = new SQLiteCommand("SELECT HoVaTen FROM NguoiDung WHERE IDNCC=@id", conn))
                            {
                                cmd2.Parameters.AddWithValue("@id", idNguoi);
                                object result = cmd2.ExecuteScalar();
                                if (result != null)
                                    tenNguoi = result.ToString();
                            }

                            FrmShowDish frm = new FrmShowDish(ten, tenNguoi, hinhanh);
                            frm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu nào trong bảng Món ăn");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khác");
            }

        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            listViewDish.Items.Clear();
            listViewUser.Items.Clear();


            using (var conn = new SQLiteConnection("Data Source=DataBai06.db;Version=3;"))
            {
                conn.Open();

                string sql = "SELECT IDMA, TenMonAn, IDNCC FROM MonAn";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["IDMA"].ToString());
                        item.SubItems.Add(reader["TenMonAn"].ToString());
                        item.SubItems.Add(reader["IDNCC"].ToString());
                        listViewDish.Items.Add(item);
                    }
                }

                string sql2 = "SELECT IDNCC, HoVaTen, QuyenHan FROM NguoiDung";
                using (var cmd = new SQLiteCommand(sql2, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["IDNCC"].ToString());
                        item.SubItems.Add(reader["HoVaTen"].ToString());
                        item.SubItems.Add(reader["QuyenHan"].ToString());
                        listViewUser.Items.Add(item);
                    }
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Quay về menu chính
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }
    }
}
