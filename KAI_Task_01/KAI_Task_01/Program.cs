using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAI_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check;
            int kristalprice = 10;
            int gold = 0;
            int kristal = 0;
            Console.WriteLine("Введите ваше количество золота: ");
            gold = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите сколько вы хотите купить кристалов: ");
            kristal = Int32.Parse(Console.ReadLine());
            check = gold >= kristal * kristalprice;
            kristal *= Convert.ToByte(check);
            gold -=kristal * kristalprice;
            Console.WriteLine("Золота после сделки: {0}. Кристалов после сделки: {1}", gold, kristal);
            Console.ReadKey();
        }
    }
}
