using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STRING_DATABASE
{
    public partial class tree : Form
    {
        public tree()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Prevent errors
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                label5.ForeColor = Color.Red;
                label5.Text = "*";

                label6.ForeColor = Color.Red;
                label6.Text = "*";

                label7.ForeColor = Color.Red;
                label7.Text = "*";

                label8.ForeColor = Color.Red;
                label8.Text = "*";

                MessageBox.Show("Information has been left out please fill information in fields required");
            }

            else
            {
                try
                {
                    string name = textBox1.Text;
                    double workhrs = Math.Round(double.Parse(textBox2.Text));
                    double overtimehrs = double.Parse(textBox3.Text);
                    double overmin = double.Parse(textBox4.Text);





                    double wkhrs = workhrs * 50;
                    double min = overmin / 60;
                    double totalovertime = overtimehrs + min;
                    double Costovertime = totalovertime * 50;
                    double totalsalarybeforetax = wkhrs + Costovertime;
                    double salary = totalsalarybeforetax;
                    double totalvat = totalsalarybeforetax * 0.15;
                    double finalpay = salary - totalvat;


                    //Salary Slip

                    textBox5.Text = "Employee Name:" + name + Environment.NewLine +
                     "Normal Pay:" + wkhrs.ToString() + Environment.NewLine +
                     "Overtime Pay:" + Costovertime.ToString("n2") + Environment.NewLine +
                     "Tax Deduction:" + totalvat.ToString("n2") + Environment.NewLine +
                     "Final Salary:" + finalpay.ToString("n2");
                }
                catch
                {
                    MessageBox.Show("Invalid input", "Error", MessageBoxButtons.RetryCancel);
                }


            }
        }

        private void tree_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    }

