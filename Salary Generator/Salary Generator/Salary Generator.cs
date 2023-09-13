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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            int UpperLetters = 0;
            int LowerLetters = 0;
            int Numbers = 0;
            int specials = 0;

            string passwordKey = maskedTextBox1.Text;
            if (passwordKey.Length < 8)
            {
                
                label1.ForeColor = Color.DarkRed;
                label1.Text = "Password lenght is less than 8 characters";


            }
            else
            {
                for (int j = 0; j < passwordKey.Length; j++)
                {

                    if (char.IsUpper(passwordKey[j]))
                        UpperLetters++;

                    else if (char.IsLower(passwordKey[j]))
                        LowerLetters++;
                    else if (char.IsDigit(passwordKey[j]))
                        Numbers++;
                    else if (char.IsPunctuation(passwordKey[j]))
                        specials++;


                }


                string message = "";
                if (UpperLetters == 0)
                    message += "Password should contain at least one UPPERCASE letter" + Environment.NewLine;

                if (LowerLetters == 0)
                    message += "Password should contain at least one LOWERCASE letter" + Environment.NewLine;

                if (Numbers == 0)
                    message += "Password should contain at least one number" + Environment.NewLine;
                if (specials == 0)
                    message += "Password should contain at least one special character" + Environment.NewLine;
                label1.ForeColor = Color.DarkRed;
                label1.Text = message;

            }
            if (label1.Text == "")
            {
                label1.ForeColor = Color.DarkRed;
                label1.Text = "Password is acceptable";
                tree mytreeform = new tree();
                mytreeform.ShowDialog();
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
