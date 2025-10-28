using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace Lab02
{
    public partial class Lab02_Bai04 : Form
    {
        [Serializable]
        public class Student
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public string Phone { get; set; }
            public int Score1 { get; set; }
            public int Score2 { get; set; }
            public int Score3 { get; set; }
            public double AvgScore { get; set; }
            public Student() { }
            public Student(string name, string id, string phone, string score1, string score2, string score3)
            {
                Name = name;
                try
                {
                    if (id.ToString().Length != 8 || !int.TryParse(id.ToString(), out int idVal))
                        throw new Exception("Mã số sinh viên phải là một số có 8 chữ số.");
                    ID = int.Parse(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    bool isValid = false;
                    while (!isValid)
                    {
                        string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập lại mã số sinh viên (8 chữ số):", "Lỗi mã số sinh viên");
                        if (int.TryParse(input, out int newId) && input.Length == 8)
                        {
                            ID = newId;
                            isValid = true;
                        }
                        else
                        {
                            MessageBox.Show("Mã số sinh viên phải là một số có 8 chữ số.");
                        }
                    }
                }

                try
                {
                    if (phone.Length != 10 || !phone.StartsWith("0") || !long.TryParse(phone, out long phoneVal))
                        throw new Exception("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0.");
                    Phone = phone;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    bool isValid = false;
                    while (!isValid)
                    {
                        string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập lại số điện thoại (10 chữ số, bắt đầu bằng 0):", "Lỗi số điện thoại");
                        if (input.Length == 10 && input.StartsWith("0") && long.TryParse(input, out long newPhone))
                        {
                            Phone = input;
                            isValid = true;
                        }
                        else
                        {
                            MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0.");
                        }
                    }
                }

                try
                {
                    if (!int.TryParse(score1, out int s1Val) || s1Val < 0 || s1Val > 10)
                        throw new Exception("Điểm phải là số nguyên từ 0 đến 10.");
                    Score1 = int.Parse(score1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    bool isValid = false;
                    while (!isValid)
                    {
                        string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập lại điểm 1 (0-10):", "Lỗi điểm số");
                        if (int.TryParse(input, out int newScore1) && newScore1 >= 0 && newScore1 <= 10)
                        {
                            Score1 = newScore1;
                            isValid = true;
                        }
                        else
                        {
                            MessageBox.Show("Điểm phải là số nguyên từ 0 đến 10.");
                        }
                    }
                }

                try
                {
                    if (!int.TryParse(score2, out int s2Val) || s2Val < 0 || s2Val > 10)
                        throw new Exception("Điểm phải là số nguyên từ 0 đến 10.");
                    Score2 = int.Parse(score2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    bool isValid = false;
                    while (!isValid)
                    {
                        string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập lại điểm 2 (0-10):", "Lỗi điểm số");
                        if (int.TryParse(input, out int newScore2) && newScore2 >= 0 && newScore2 <= 10)
                        {
                            Score2 = newScore2;
                            isValid = true;
                        }
                        else
                        {
                            MessageBox.Show("Điểm phải là số nguyên từ 0 đến 10.");
                        }
                    }
                }

                try
                {
                    if (!int.TryParse(score3, out int s3Val) || s3Val < 0 || s3Val > 10)
                        throw new Exception("Điểm phải là số nguyên từ 0 đến 10.");
                    Score3 = int.Parse(score3);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    bool isValid = false;
                    while (!isValid)
                    {
                        string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập lại điểm 3 (0-10):", "Lỗi điểm số");
                        if (int.TryParse(input, out int newScore3) && newScore3 >= 0 && newScore3 <= 10)
                        {
                            Score3 = newScore3;
                            isValid = true;
                        }
                        else
                        {
                            MessageBox.Show("Điểm phải là số nguyên từ 0 đến 10.");
                        }
                    }
                }
            }
        }

        public Lab02_Bai04()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private int curStudent = 0;
        private List<Student> students = new List<Student>();

        private void btn_Read_Click(object sender, EventArgs e)
        {
            string[] datas = rtb.Text.Trim('\n').Split(new string[] { "\n\n" }, StringSplitOptions.None);
            if (string.IsNullOrWhiteSpace(rtb.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu sinh viên vào ô bên dưới.");
                return;
            }
            else
            {
                foreach (string data in datas)
                {
                    try
                    {
                        string[] stif = data.Trim().Split('\n');
                        string name = stif[0].Trim();
                        string id = stif[1].Trim();
                        string phone = stif[2].Trim();
                        string score1 = stif[3].Trim();
                        string score2 = stif[4].Trim();
                        string score3 = stif[5].Trim();
                        Student student = new Student(name, id, phone, score1, score2, score3);
                        students.Add(student);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi đọc dữ liệu sinh viên:\n{ex.Message}");
                        return;
                    }
                }
                string filePath = @"E:\NT106-TH-24520669\Lab02\input4.txt";
                string json = JsonSerializer.Serialize(students, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(filePath, json);
                string readJson = File.ReadAllText(filePath);
                List<Student> loadedStudents = JsonSerializer.Deserialize<List<Student>>(readJson);
                if (loadedStudents != null && loadedStudents.Count > 0)
                {
                    students = loadedStudents;
                    curStudent = 0;
                    ShowStudentInfo1(curStudent);
                }
            }
        }

        private void ShowStudentInfo1(int index)
        {
            Student st = students[index];
            tb_Name_Read.Text = st.Name;
            tb_ID_Read.Text = st.ID.ToString();
            tb_Phone_Read.Text = st.Phone;
            tb_Course1_Read.Text = st.Score1.ToString();
            tb_Course2_Read.Text = st.Score2.ToString();
            tb_Course3_Read.Text = st.Score3.ToString();
            tb_Average_Read.Text = null;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (curStudent < students.Count - 1)
            {
                curStudent++;
                ShowStudentInfo1(curStudent);
                lb_Page.Text = (curStudent + 1).ToString();

            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (curStudent > 0)
            {
                curStudent--;
                ShowStudentInfo1(curStudent);
                lb_Page.Text = (curStudent + 1).ToString();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Quay về menu chính
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void ShowStudentInfo2(int index)
        {
            Student st = students[index];
            tb_Name_Write.Text = st.Name;
            tb_ID_Write.Text = st.ID.ToString();
            tb_Phone_Write.Text = st.Phone;
            tb_Course1_Write.Text = st.Score1.ToString();
            tb_Course2_Write.Text = st.Score2.ToString();
            tb_Course3_Write.Text = st.Score3.ToString();
            double avg = (st.Score1 + st.Score2 + st.Score3) / 3.0;
            tb_Average_Write.Text = avg.ToString("F2");
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            ShowStudentInfo2(curStudent);
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            string FilePath = @"E:\NT106-TH-24520669\Lab02\output4.txt";
            FileStream fs1 = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
            if (students.Count == 0)
            {
                MessageBox.Show("Chưa có sinh viên nào để ghi.");
                return;
            }
            sw.WriteLine("Name: " + tb_Name_Write.Text + "\nID: " + tb_ID_Write.Text + "\nPhone: " + tb_Phone_Write.Text +
                "\nCourse 1: " + tb_Course1_Write.Text + "\nCourse 2: " + tb_Course2_Write.Text +
                "\nCourse 3: " + tb_Course3_Write.Text + "\nAverage Score: " + tb_Average_Write.Text + "\n\n");
            MessageBox.Show("Ghi thông tin thành công!");
            sw.Close();
            fs1.Close();
        }
    }
}
