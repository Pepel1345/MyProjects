using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void pork()
        {
            string str = "Я скажу'Не надо рая дайте родину мою' пошла родная"; //textBox1.Text;
            char[] ar = new char[str.Length];
            for (int i = 0,j=0; i < str.Length; i++)
            {
                if (str[i] == ('\''))
                {
                    i++;
                    while (str[i]!=('\'')) i++;
                    i++;                   
                }
                ar[j] = str[i];
                j++;
            }
            string pob = new string(ar);
            textBox2.Text = pob.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pork();
        }
    }
}
