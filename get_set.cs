using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        class rechka
        {
            public string Name { get; set; } = "Tomik";
            public int Age { get; set; } = 18;
        }





        static void Main(string[] args)
        {


            rechka tolik = new rechka();

            // tolik.Name = "korsh";
            try
            {
                Console.WriteLine("Enter name");
                tolik.Name = Console.ReadLine();
                Console.WriteLine("Enter age");
                tolik.Age = Convert.ToInt32(Console.ReadLine());
            }

            catch { }



            finally
            {
                Console.WriteLine(tolik.Name);
                Console.WriteLine(tolik.Age);
                Console.ReadLine();
            }









        }
    }
}
