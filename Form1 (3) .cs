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
            string str = "Вот закрылся занавес за еще одной историей.Прошла вечность.Мимолетные мечты исчезли вдалеке.Всe"+ 
                         "что осталось сейчас это я и мои воспоминания.Но я уверен,что мы встретимся снова когда-нибудь,"+
                         "ты и я,в другом месте в другое время,и может быть мы даже не сможем понять,что ты это ты,а я это я."+
                         "Давай откроем дверь в великую неизвестность,пройдем сквозь другую действительность,проживем другой день,ведь даже"+ 
                         "тогда,когда история рассказана,жизнь продолжается,и,пока мы не встретимся снова,пожалуйста,береги себя,мой друг";//textBox1.Text;"
            string[] ar;
            int jesus = 0;
            
            ar = str.Split(' ', ',', '.');
            for (int i = 0; i < ar.Length - 1; i++)
            {
                string poz = ar[i];
                if (poz[0] == poz[poz.Length-1]) jesus++;
            }
            textBox2.Text = Convert.ToString(jesus);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            pork();
        }
    }
}
