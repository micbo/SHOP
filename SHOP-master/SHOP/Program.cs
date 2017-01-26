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
            bool fortsæt = true;
            int VareNummer = 1;

            while (fortsæt)
            {
                Console.Clear();
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
                        Console.WriteLine("{0,-20} {1,5}\n", "Nr Vare", "Pris");
                        foreach (var varer in sortiment.AlleVarer)

                        {
                            Console.WriteLine(VareNummer + " {0,-20} {1,5}\n", varer.Describtion, string.Format("{0:0.00, kr}", varer.Price));
                            VareNummer = VareNummer + 1;
                        }
                        Console.WriteLine("Tast nummer ud for den ønskede vare");
                        
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.D1:
                                Console.Clear();
                                Console.WriteLine("Du har valgt:");
                                Console.WriteLine(" {0,-20} {1,5}\n", sortiment.AlleVarer[0].Describtion, string.Format("{0:0.00, kr}", sortiment.AlleVarer[0].Price));
                                Console.WriteLine("Hvormange enheder - tal + ENTER");
                                Console.ReadKey();

                                break;

                                
                        }
                        break;

                    case ConsoleKey.D2:
                        //Console.WriteLine(Account[0] + ": " + balance);
                        //Console.WriteLine("Hvor meget vil du indsætte? ");
                        //// int result;
                        //if (Int32.TryParse(Console.ReadKey(), out result))
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
            while (n < 60)
            {
                Console.WriteLine(n + " gange På gensyn");
                n++;
            }
            Console.WriteLine("På gensyn");
        }
    }
}


