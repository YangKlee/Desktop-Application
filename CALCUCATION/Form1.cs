using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCUCATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isResultShow = false;
        int isUuTien(string phepToan)
        {
            if (phepToan == "*" || phepToan == "/")
                return 2;
            else if (phepToan == "+" || phepToan == "-")
                return 1;
            return 0;
        }
        List<String> splitBieuThuc(String rawData)
        {
            List<String> bieuThuc = new List<string>();
            string tmp = null;
            foreach (char c in rawData)
            {
                if (c == '+' || c == '-' || c == '*' || c == '/' || c == '(' || c == ')')
                {
                    if(tmp!= null)
                        bieuThuc.Add(tmp);
                    bieuThuc.Add(c.ToString());
                    tmp = null;
                }
                else
                {
                    tmp += c;
                }
            }
            if (tmp != null)
                bieuThuc.Add(tmp);
            return bieuThuc;
        }
        List<String> converntHauTo(List<String> trungTo)
        {
            List<String> hauTo =  new List<string>();
            Stack<String> tmp = new Stack<String>();
            foreach (String c in trungTo)
            {
                Console.WriteLine(c);
                if (c == "+" || c == "-"|| c == "*" || c == "/" )
                {
                    while(tmp.Count != 0 &&  isUuTien(tmp.Peek()) != 0 && (isUuTien(tmp.Peek()) >= isUuTien(c)) )
                    {
                        
                        hauTo.Add(tmp.Pop());
                    }
                    tmp.Push(c);
                }
                else if (c == "(")
                {
                    tmp.Push(c);
                }
                else if (c == ")")
                {
                    while (tmp.Peek() != "(")
                    {
                        hauTo.Add(tmp.Pop());

                    }
                    tmp.Pop();   
                }
                else
                    hauTo.Add(c);
            }
            while(tmp.Count != 0)
            {
                hauTo.Add(tmp.Pop());
            }
            return hauTo;
        }
        float tinhHauTo(List<String> hauTo) 
        {
            Stack<float> tmp = new Stack<float>();
            Stack<float> result = new Stack<float>();
            try
            {
                foreach (string c in hauTo)
                {
                    if (c == "+" || c == "-" || c == "*" || c == "/")
                    {
                        tmp.Push(result.Pop());
                        tmp.Push(result.Pop());


                        float a = tmp.Pop();
                        float b = tmp.Pop();
                        float kq = 0;
                        if (c == "+")
                        {
                            kq = a + b;
                        }
                        else if (c == "-")
                        {
                            kq = a - b;
                        }
                        else if (c == "*")
                        {
                            kq = a * b;
                        }
                        else if (c == "/")
                        {
                            kq = a / b;
                        }
                        result.Push(kq);
                    }
                    else
                    {
                        result.Push(float.Parse(c));
                    }
                }
                return result.Pop();
            }
            catch (Exception ex)
            {
                throw;
                return 0;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isResultShow)
            {
                screen_tb.Text = null;
                isResultShow = false;
            }
            screen_tb.Text += (sender as Button).Text;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            screen_tb.Text = null;
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (screen_tb.Text != "" && screen_tb.Text != null)
            {
                screen_tb.Text = screen_tb.Text.Remove(screen_tb.Text.Length - 1);
      
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //screen_tb.Text = " =" + tinhHauTo(converntHauTo(screen_tb.Text)).ToString();
            List<String> bieuThuc = splitBieuThuc(screen_tb.Text);
            List<String> hauTo = converntHauTo(bieuThuc);
            try
            {
                float kq = tinhHauTo(hauTo);

                screen_tb.Text = $"{screen_tb.Text} = {kq.ToString()}";
            }
            catch
            {
                screen_tb.Text = "SYSTAX ERROR";
            }
            isResultShow = true;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
