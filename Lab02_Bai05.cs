using Microsoft.VisualBasic.Devices;
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
    public partial class Lab02_Bai05 : Form
    {
        public class Movie
        {
            public string Name { get; set; }
            public double BasePrice { get; set; }
            public List<int> Rooms { get; set; } = new List<int>();
            public int Sold { get; set; } = 0;
            public double Revenue { get; set; } = 0;
        }

        List<TabPage> allTabs = new List<TabPage>();
        Dictionary<string, Movie> movies = new Dictionary<string, Movie>();
        HashSet<string> soldSeats = new HashSet<string>();

        public Lab02_Bai05()
        {
            InitializeComponent();

            foreach (TabPage tab in tabControl1.TabPages)
                allTabs.Add(tab);

            foreach (TabPage tab in tabControl1.TabPages)
            {
                foreach (Control ctrl in tab.Controls)
                {
                    if (ctrl is CheckBox cb)
                        cb.CheckedChanged += Ghe_CheckedChanged;
                }
            }

            progressBar1.Value = 0;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                movies.Clear();
                string[] lines = File.ReadAllLines(ofd.FileName);
                for (int i = 0; i < lines.Length; i += 3)
                {
                    string name = lines[i];
                    double price = double.Parse(lines[i + 1]);
                    List<int> rooms = lines[i + 2].Split(' ').Select(int.Parse).ToList();
                    movies[name] = new Movie { Name = name, BasePrice = price, Rooms = rooms };
                }

                cbFilm.DataSource = movies.Keys.ToList();
                MessageBox.Show("Đã nhận dữ liệu");
            }
        }

        private void cbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilm.SelectedItem == null) return;
            string movieName = cbFilm.SelectedItem.ToString();
            if (!movies.ContainsKey(movieName)) return;

            var mv = movies[movieName];
            tabControl1.TabPages.Clear();
            foreach (int r in mv.Rooms)
                tabControl1.TabPages.Add(allTabs[r - 1]);

            foreach (TabPage tab in tabControl1.TabPages)
                foreach (CheckBox cb in tab.Controls.OfType<CheckBox>())
                    cb.Checked = false;
        }

        private void Ghe_CheckedChanged(object sender, EventArgs e)
        {
            int soPhongCoGhe = 0;
            int tongGhe = 0;

            foreach (TabPage tab in tabControl1.TabPages)
            {
                int gheTrongPhong = tab.Controls.OfType<CheckBox>().Count(cb => cb.Checked);
                if (gheTrongPhong > 0)
                    soPhongCoGhe++;
                tongGhe += gheTrongPhong;
            }

            if (soPhongCoGhe > 1 && tongGhe > 2)
            {
                CheckBox cb = sender as CheckBox;
                cb.Checked = false;
                MessageBox.Show("Chỉ được chọn tối đa 2 ghế khi chọn nhiều phòng!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!");
                return;
            }

            if (movies.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu phim! Vui lòng nhấn 'Nhận dữ liệu' trước.");
                return;
            }

            string movieName = cbFilm.SelectedItem.ToString();
            var mv = movies[movieName];

            List<(int room, string seat)> gheDaChon = new List<(int, string)>();

            foreach (TabPage tab in tabControl1.TabPages)
            {
                int roomIndex = allTabs.IndexOf(tab) + 1;

                foreach (CheckBox cb in tab.Controls.OfType<CheckBox>())
                {
                    if (cb.Checked)
                    {
                        string key = $"{roomIndex}-{cb.Text}";
                        if (soldSeats.Contains(key))
                        {
                            MessageBox.Show($"Ghế {cb.Text} ở phòng {roomIndex} đã được mua!");
                            return;
                        }
                        gheDaChon.Add((roomIndex, cb.Text));
                    }
                }
            }

            if (gheDaChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế!");
                return;
            }

            double tongTien = 0;

            foreach (var (room, seat) in gheDaChon)
            {
                double price = mv.BasePrice;
                if (new[] { "A1", "A5", "C1", "C5" }.Contains(seat))
                    price *= 0.25;
                else if (new[] { "B2", "B3", "B4" }.Contains(seat))
                    price *= 2;

                tongTien += price;
                mv.Sold++;
                mv.Revenue += price;
                soldSeats.Add($"{room}-{seat}");
            }

            var gheTheoPhong = gheDaChon
                .GroupBy(g => g.room)
                .Select(g => $"Phòng {g.Key}: {string.Join(", ", g.Select(x => x.seat))}")
                .ToList();

            MessageBox.Show(
                $"Khách hàng: {tbName.Text}\nPhim: {movieName}\n" +
                $"{string.Join("\n", gheTheoPhong)}\n" +
                $"Tổng tiền: {tongTien:#,##0}đ",
                "Thanh toán thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Vô hiệu hóa ghế đã mua
            foreach (TabPage tab in tabControl1.TabPages)
            {
                int roomIndex = allTabs.IndexOf(tab) + 1;
                foreach (CheckBox cb in tab.Controls.OfType<CheckBox>())
                {
                    string key = $"{roomIndex}-{cb.Text}";
                    if (soldSeats.Contains(key))
                    {
                        cb.Enabled = false;
                        cb.Checked = false;
                    }
                }
            }
        }
        private async void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text file|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    int total = movies.Count;
                    int done = 0;
                    progressBar1.Value = 0;

                    var sorted = movies.Values.OrderByDescending(m => m.Revenue).ToList();

                    int rank = 1;
                    foreach (var mv in sorted)
                    {
                        int tongGhe = 30 * mv.Rooms.Count;        
                        int veTon = tongGhe - mv.Sold;           
                        double rate = (mv.Sold / (double)tongGhe) * 100;

                        await sw.WriteLineAsync($"Xếp hạng: {rank}");
                        await sw.WriteLineAsync($"Phim: {mv.Name}");
                        await sw.WriteLineAsync($"Giá vé chuẩn: {mv.BasePrice:#,##0}đ");
                        await sw.WriteLineAsync($"Phòng chiếu: {string.Join(", ", mv.Rooms)}");
                        await sw.WriteLineAsync($"Số vé bán: {mv.Sold}");
                        await sw.WriteLineAsync($"Số vé tồn: {veTon}");
                        await sw.WriteLineAsync($"Tỷ lệ bán vé: {rate:0.0}%");
                        await sw.WriteLineAsync($"Doanh thu: {mv.Revenue:#,##0}đ");
                        await sw.WriteLineAsync(new string('-', 40));

                        rank++;
                        done++;
                        progressBar1.Value = done * 100 / total;

                        await Task.Delay(400);
                    }
                }
                MessageBox.Show("Đã xuất dữ liệu ra file thành công!");
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
