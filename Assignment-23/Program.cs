using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_23
{
    internal class Program
    {
        public delegate void LuckyNumber(ref int energy, int wp, int nos);
        public static void Details(ref int energy, int nos, int wp)
        {
            bool winner = false;
            bool runner = false;
            for (int i = 1; i <= nos; i++)
            {
                Console.WriteLine($"{i} Spin:");
                if (i % 2 == 0)
                {
                    energy += i;
                    wp += 10;
                    Console.WriteLine($"Energy Level = {energy},Winning Probability ={wp}");
                }
                else
                {
                    energy -= i;
                    wp -= 10 + i;
                    Console.WriteLine($"Energy Level = {energy},Winning Probability ={wp}");
                }

            }
            if (energy >= 4 && wp > 60)
            {
                winner = true;

            }
            else if (energy >= 1 && wp > 50)
            {
                runner = true;

            }


            if (winner)
            {
                Console.WriteLine("Winner!");
            }
            else if (runner)
            {
                Console.WriteLine("Runner Up!");
            }
            else
            {
                Console.WriteLine("Loser!");
            }


        }

        static void Main(string[] args)
        {
            Program program = new Program();
            LuckyNumber lucky = new LuckyNumber(Details);
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Lucky Number from 1 to 10");
            int luck = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter engery level");
            int en = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Winning Probability");
            int wp = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter No. of Spin");
            int nos = int.Parse(Console.ReadLine());
            lucky(ref en, nos, wp);
            Console.ReadKey();
        }
    }
}