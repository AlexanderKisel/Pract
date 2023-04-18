using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KAI_Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string password = "password";
            string passworduser;
            do
            {
                Console.Write("Введите пароль: ");
                passworduser= Console.ReadLine();
                if (passworduser != password) counter++;
                else
                {
                    Console.WriteLine("Секретное сообщение: 894392gsgf340234");
                    counter = 3;
                }
            }while (counter < 3);
            Console.ReadKey();
        }
    }
}
