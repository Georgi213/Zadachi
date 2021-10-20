using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi
{
    class Program
    {
        public static int Saali_suurus()
        {
            Console.WriteLine("Razmer Zala [1,2,3]");
            int a = int.Parse(Console.ReadLine());
            return a;
        }
        static int[,] saal = new int[,] { };
        static int kohad, read;
        public static void Saali_taitmine(int a)
        {
            Random rnd = new Random();
            if (a==1)
            {
                kohad = 30;
                read = 20;

            }
            else if (a==2)
            {
                kohad = 60;
                read = 50;
            }
            else
            {
                kohad = 30;
                read = 26;
            }
            saal = new int[read, kohad];

            for (int rida = 0; rida < read; rida++)
            {
                for (int koht = 0; koht < kohad; koht++)
                {
                    saal[rida, koht] = rnd.Next(0, 2);
                }
            }
            
        }
        public static void Saal_ekraanile()
        {
            for (int rida = 0; rida < read; rida++)
            {
                for (int koht = 0; koht < kohad; koht++)
                {
                    Console.Write(saal[rida, koht]);
                }
            }
            Console.WriteLine();
        }
        static bool Muuk()
        {
            Console.WriteLine("sisesta rida");
            int rida1 = int.Parse(Console.ReadLine());
            Console.WriteLine("sisesta koht");
            int koht1 = int.Parse(Console.ReadLine());

            if (saal[rida1-1,koht1-1]==0)

            {
                saal[rida1 - 1, koht1 - 1] = 1;
                return true;
                Console.WriteLine("Bilet kuplen");
            }
            else
            {
                return false;
                Console.WriteLine("mesto zanato");

            }


        }
        static void Main(string[] args)
        {
            int suurus = Saali_suurus();

            Saali_taitmine(suurus);
            while (true)
            {
                Saal_ekraanile();
                bool ost = Muuk();
                Console.WriteLine(ost);
            }
            Console.ReadLine();
        }   
    }
}
