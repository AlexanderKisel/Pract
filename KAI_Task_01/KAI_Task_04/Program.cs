using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAI_Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int BossHP = 0;
            int UserHP = 0;
            int Poison = 0;
            int Hill = 0;
            int DamageBoss = 0;
            int DamageUser = 0;
            int Stan = 2;
            int hod = 0;
            Random rnd = new Random();
            string spell;
            Console.SetCursorPosition(Console.WindowWidth / 4, Console.WindowTop);
            Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В ПОДЗЕМЕЛЬЕ!");
            Console.WriteLine();
            Console.WriteLine("Сейчас вам приедтся сразиться с боссом, используя заклинания! \n" +
                              "Первым ходит тот, кому больше повезло. Здоровье будет выбрано \n" +
                              "случайно. Заклинания и их действия будут написаны, вам лишь  \n" +
                              "остается думать, какое стоит использовать. Дам вам небольшой совет -  \n" +
                              "НЕ ОШИБИТЕСЬ ПРИ ПРОИЗНОШЕНИИ ЗАКЛИНАНИЯ!");
            Console.WriteLine();
            Console.WriteLine("Если вы готовы, напишите да. Иначе программа завершится: ");
            string ready = Console.ReadLine();
            ready = ready.ToUpper();
            if (ready == "ДА")
            {
                Console.Clear(); 
                Console.SetCursorPosition(Console.WindowWidth / 4, Console.WindowTop + 1);
                Console.WriteLine("ДА НАЧНЕТСЯ БИТВА!");
                Console.WriteLine("Ваши заклинания: \n" +
                    "1 - ДАЙЛЕОПАРД - Вы наносите 30 hp противнику, но сами теряете 10 hp \n" +
                    "2 - АПЧХИ - Вы заразите противника и он будет терять 5 hp каждый ход \n" +
                    "3 - ОЙДАЧТОТАКОЕ - Вы не наносите урон, но получаете 50 hp \n" +
                    "4 - АХМОЙМИЛЫЙАВГУСТИН - Противника обстреливает артелерия и снимает ему 150 hp \n" +
                    "5 - НЕВЛИЯЕТ - Противник находится под оглушением после обстрела артелерии и пропускает 2 хода \n" +
                    "6 - ВАЛЕРАНАСТАЛОТВОЕВРЕМЯ - Противник теряет 40 hp" +
                    "7 - ЛОВИАПТЕЧКУ - Вы получаете 40 hp" +
                    "8 - РУССКАЯРУЛЕТКА - Кто-то из вас двоих теряет 100 hp" +
                    "ПОМНИТЕ! НЕЛЬЗЯ ДВАЖДЫ ИСПОЛЬЗОВАТЬ ОДНО И ТО ЖЕ ЗАКЛИНАНИЕ");
                BossHP = rnd.Next(200, 1000);
                UserHP = rnd.Next(200, 1000);
                //hod = rnd.Next(0, 1);
                do
                {
                    Console.WriteLine("Здоровье босса - {0}", BossHP);
                    Console.WriteLine("Ваше здоровье - {0}", UserHP);
                    if (hod == 0)
                    {
                        HodBota(DamageBoss, Poison, Hill, Stan);
                        if (Stan != 0)
                        {
                            Console.WriteLine("Вы пропускате ход!");
                            Stan--;
                            Console.WriteLine("Вы получили {0} урон(-а)", DamageBoss + Poison);
                            BossHP = BossHP + Hill;
                            Console.WriteLine("Здоровье босса - {0}", BossHP + Hill);
                            UserHP = UserHP + DamageBoss + Poison;
                            Console.WriteLine("Ваше здоровье - {0}", UserHP);
                        }
                        else
                        {
                            Console.WriteLine("Вы получили {0} урон(-а)", DamageBoss + Poison);
                            BossHP = BossHP + Hill;
                            Console.WriteLine("Здоровье босса - {0}", BossHP);
                            UserHP = UserHP + DamageBoss + Poison;
                            Console.WriteLine("Ваше здоровье - {0}", UserHP);
                            Console.Write("Произнесите заклинание: ");
                            spell = Console.ReadLine();
                            HodCheloveka(spell, DamageUser, Poison, Hill, Stan);
                            if (Stan != 0)
                            {
                                Console.WriteLine("Босс пропускает ход!");
                                Stan--;
                                Console.WriteLine("Вы нанесли {0} урона", DamageUser + Poison);
                                BossHP = BossHP + DamageUser + Poison;
                                Console.WriteLine("Здоровье босса - {0}", BossHP);
                                UserHP = UserHP + Hill;
                                Console.WriteLine("Ваше здоровье - {0}", UserHP);
                            }
                            else
                            {
                                Console.WriteLine("Вы нанесли {0} урона", DamageUser + Poison);
                                BossHP = BossHP + DamageUser + Poison;
                                Console.WriteLine("Здоровье босса - {0}", BossHP);
                                UserHP = UserHP + Hill;
                                Console.WriteLine("Ваше здоровье - {0}", UserHP);
                            }
                        }
                    }
                    else
                    {

                    }
                } while (BossHP != 0);
            }
        }
        public static void HodBota(int DamageBoss, int Poison, int Hill, int Stan)
        {
            Random rnd = new Random();
            int spell = rnd.Next(1, 8);
            switch (spell)
            {
                case 1: DamageBoss = -30; Hill = -10; break;
                case 2: Poison = Poison - 5; break;
                case 3: Hill = 50; break;
                case 4: DamageBoss = -150; break;
                case 5: Stan = 2; break;
                case 6: DamageBoss = -40; break;
                case 7: Hill = 40; break;
                case 8: rnd.Next(DamageBoss = -100, Hill = -100); break;
            }
        }
        public static void HodCheloveka(string Spell,int DamageUser, int Poison, int Hill, int Stan)
        {
            Random rnd = new Random();
            switch (Spell)
            {
                case "ДАЙЛЕОПАРД": DamageUser = -30; Hill = -10; break;
                case "АПЧХИ": Poison = Poison - 5; break;
                case "ОЙДАЧТОТАКОЕ": Hill = 50; break;
                case "АХМОЙМИЛЫЙАВГУСТИН": DamageUser = -150; break;
                case "НЕВЛИЯЕТ": Stan = 2; break;
                case "ВАЛЕРАНАСТАЛОТВОЕВРЕМЯ": DamageUser = -40; break;
                case "ЛОВИАПТЕЧКУ": Hill = 40; break;
                case "РУССКАЯРУЛЕТКА": rnd.Next(DamageUser = -100, Hill = -100); break;
            }
        }
    }
}
