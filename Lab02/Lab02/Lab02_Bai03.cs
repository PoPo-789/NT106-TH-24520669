using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Quay về menu chính
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            string inputPath = @"E:\NT106-TH-24520669\Lab02\input3.txt";
            FileStream fs = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadToEnd();
            rtbOut.Text = s;
            fs.Close();
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            string inputPath = @"E:\NT106-TH-24520669\Lab02\input3.txt";
            string outputPath = @"E:\NT106-TH-24520669\Lab02\output3.txt";
            string[] lines = File.ReadAllLines(inputPath);
            List<string> res = new List<string>();
            foreach (string line in lines)
            {
                string st = line.Trim();
                if (string.IsNullOrEmpty(st))
                    continue;

                try
                {
                    double ans = Evaluate(st);
                    res.Add($"{st} = {ans}");
                }
                catch (Exception ex)
                {
                    res.Add($"{st} = Error: {ex.Message}");
                }
            }
            File.WriteAllLines(outputPath, res);
            rtbOut.Clear();
            foreach (string line in res)
                rtbOut.AppendText(line + Environment.NewLine);
        }
        private double Evaluate(string st)
        {
            List<string> postfix = InfixToPostfix(st);
            Stack<double> stack = new Stack<double>();

            foreach (string token in postfix)
            {
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                {
                    stack.Push(num);
                }
                else
                {
                    double b = stack.Pop();
                    double a = stack.Pop();

                    switch (token)
                    {
                        case "+":
                            stack.Push(a + b);
                            break;
                        case "-":
                            stack.Push(a - b);
                            break;
                        case "*":
                            stack.Push(a * b);
                            break;
                        case "/":
                            if (b == 0)
                                throw new Exception("Chia cho 0");
                            stack.Push(a / b);
                            break;
                        default:
                            throw new Exception($"Ký tự không hợp lệ: {token}");
                    }
                }
            }
            return stack.Pop();
        }

        private List<string> InfixToPostfix(string st)
        {
            List<string> res = new List<string>();
            Stack<string> stack = new Stack<string>();

            string[] tokens = st.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> prec = new Dictionary<string, int>
            {
                { "+", 1 },
                { "-", 1 },
                { "*", 2 },
                { "/", 2 }
            };

            foreach (string token in tokens)
            {
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
                {
                    res.Add(token);
                }
                else if (prec.ContainsKey(token))
                {
                    while (stack.Count > 0 && prec.ContainsKey(stack.Peek()) && prec[stack.Peek()] >= prec[token])
                        res.Add(stack.Pop());
                    stack.Push(token);
                }
                else if (token == "(")
                {
                    stack.Push(token);
                }
                else if (token == ")")
                {
                    while (stack.Count > 0 && stack.Peek() != "(")
                        res.Add(stack.Pop());
                    if (stack.Count > 0 && stack.Peek() == "(")
                        stack.Pop();
                    else
                        throw new Exception("Số lượng ngoặc không cân bằng");
                }
                else
                    throw new Exception($"Ký tự không hợp lệ: {token}");
            }
            while (stack.Count > 0)
            {
                if (stack.Peek() == "(" || stack.Peek() == ")")
                    throw new Exception("Số lượng ngoặc không cân bằng");
                res.Add(stack.Pop());
            }
            return res;
        }
    }
}
