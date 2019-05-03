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
        public void meat()
        {
            int i = 0;
            int numberOne = 0;
            int numberTwo = 0;
            string str = "Не бойтесь прыгать с утеса,а пока летите вниз отращивайте крылья,";//textBox1.Text
            char[] ar = new char[str.Length];
            for (i = 0; i < str.Length; i++)
            {
                ar[i] = str[i];
            }
            i = 0;
            while (ar[i] != (','))
            {
                i++;
            }
            numberOne = i;
            i = 0;
            while (ar[(str.Length-1)-i] != (','))
            {
                i++;
            }
            numberTwo = str.Length - i;
            textBox2.Text = Convert.ToString(numberOne);
            textBox3.Text = Convert.ToString(numberTwo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meat();
        }
    }
}
