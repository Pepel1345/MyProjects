using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public double Vvod(TextBox L)
        {
            return Convert.ToDouble(L.Text);
        }
        public void ris()
        {
            double x = Vvod(textBox1);
            double Resh = Math.Pow(x, x);
        }

        public void fus ()
        {
            StreamWriter tw = new StreamWriter("Text.txt");
            tw.WriteLine(DateTime.Now);
            tw.Close();
            
        }
        public void fis()
        {
           // StreamReader tr = new StreamReader("Text.txt");
            textBox2.Text = File.ReadAllText("Text.txt");
           //tr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fis();
        }
    }
}
