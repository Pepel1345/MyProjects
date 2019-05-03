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
            string str = "Не бойтесь прыгать с утеса,а пока летите вниз отращивайте крылья";  //textBox1.Text; //Вводим текст
            char[] ar = new char[str.Length]; //Задаем размер массива
            string Alphabeta = "абвгдеёжзийклмнопрстуфхсчшщьыъэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХСЧШЩЬЫЪЭЮЯ ,.";//Массив алфавита

            for (int i = 0; i < str.Length; i++)   //цикл заполнения массива типа char
            {
                ar[i] = str[i];
            }
            for (int i = 0; i < str.Length-1; i++) // шифр
            {
                int j = 0;
                while (ar[i] != Alphabeta[j])  // доводим алфавит до нужного нам значение
                {
                    j++;
                }
                
                if(char.IsLetter(ar[i]))if(ar[i]!= Alphabeta[65]) if (ar[i] != Alphabeta[66]) if (ar[i] != Alphabeta[67]) ar[i] = Alphabeta[j + 1]; // если буква(чтобы пропустить пробелы) то проверяем на последню букву Я(чтобы вернуть к а)
                if (ar[i] == Alphabeta[32]) ar[i] = Alphabeta[0]; //циклируем буквы нижнего регистра
                if (ar[i] == Alphabeta[65]) ar[i] = Alphabeta[33]; //циклируем буквы верхнего регистра
                
                if (Char.IsUpper(ar[i])) { char.ToLower(ar[i]); } // переводим нижний в верхний 
                if (Char.IsLower(ar[i])) { char.ToUpper(ar[i]); } // переводим верхний в нижний 
            }
            string pob = new string(ar);
            textBox2.Text = pob.ToString() ;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            pork();
        }
    }
}
