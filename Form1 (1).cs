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
       
        public void Pork()
        {
            string str = textBox1.Text;
            char[] arr = new char[str.Length];
            string result=string.Empty;
            string LastResult = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = str[i];
            }

            foreach (char k in arr)
            {
                if (char.IsDigit(k))
                {
                    result += k;
                }
                     else
                     {
                          if (result.Length > LastResult.Length)
                          {
                             LastResult = result;                        
                          }
                          result = string.Empty;

                     }
               
            }
            if (result.Length > LastResult.Length)
            {
                LastResult = result;
            }
            result = string.Empty;
            textBox2.Text = Convert.ToString(LastResult.Length);
            textBox3.Text = LastResult;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pork();
        }
    }
}
