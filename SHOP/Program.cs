using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Varer varer1 = new Varer("Sødmælk", 6.12);
            Varer varer2 = new Varer("Rugbrød", 12);
            Varer varer3 = new Varer("Kaffe", 39.8000);
            Varer varer4 = new Varer("Cola", 72);
            var sortiment = new Sortiment();
            sortiment.AlleVarer.Add(varer1);
            sortiment.AlleVarer.Add(varer2);
            sortiment.AlleVarer.Add(varer3);
            sortiment.AlleVarer.Add(varer4);
            string[] Account = { "Varer", "Kurv", "Køb", "Ny balance" };
            int balance = 1000;
            int ud = 0;
            int ind = 0;
            int NyBalance = balance + ud + ind;
            int result;
            bool fortsæt = true;

            while (fortsæt)
            {
                Console.WriteLine("Tast for at vælge funktion: ");
                Console.WriteLine("Tryk 1 for at se vareudvalg ");
                Console.WriteLine("Tryk 2 for at se indkøbskurv ");
                Console.WriteLine("Tryk 3 for at se saldo ");
                Console.WriteLine("Tryk 4 for at se afslutte ");
                ConsoleKey Choice;
                Console.WriteLine("Skriv et tal mellem 1 og 4");
                Choice = Console.ReadKey().Key;

                switch (Choice)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("{0,-20} {1,5}\n", "Vare", "Pris");
                        foreach (var varer in sortiment.AlleVarer)
                        {
                            Console.WriteLine("{0,-20} {1,5}\n", varer.Describtion, string.Format("{0:0.00,-}", varer.Price));

                    //        Console.WriteLine(varer);

                        }
                        Console.ReadKey();
                        //Console.WriteLine(Account[0] + ": " + balance);
                        //Console.WriteLine("Hvor meget vil du hæve? ");
                        //if (Int32.TryParse(Console.ReadLine(), out result))
                        //    ud = result;
                        //balance = balance - ud;
                        //Console.WriteLine("Ny " + Account[0] + ": " + balance);
                        //       Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        //Console.WriteLine(Account[0] + ": " + balance);
                        //Console.WriteLine("Hvor meget vil du indsætte? ");
                        //// int result;
                        //if (Int32.TryParse(Console.ReadLine(), out result))
                        //    ud = result;
                        //balance = balance + ud;
                        //Console.WriteLine("Ny " + Account[0] + ": " + balance);
                        ////         Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine(" se saldo er valgt");
                        Console.WriteLine(Account[0] + ": " + balance);

                        break;

                    case ConsoleKey.D4:
                        fortsæt = false;
                        break;
                    default:
                        break;

                }
            }
            int n = 1;
            while (n < 6000)
            {
                Console.WriteLine(n + " gange På gensyn");
                n++;
            }
            Console.WriteLine("På gensyn");
        }
    }
}


