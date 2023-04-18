using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAI_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            do
            {
                str = Console.ReadLine();
            } while (str.ToUpper() != "EXIT");
        }
    }
}
