using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plesoczki_A_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam, db;
            Console.WriteLine("Melyik szám osztóinak számat adjam meg?");
            Console.Write("szám : ");
            szam = Convert.ToInt32(Console.ReadLine());
            db = 0;
            for (int i = 1; i <= szam; i++)
                if (szam % i == 0)
                    db++;
            Console.WriteLine("Az {0} szám osztoinak száma : {1}", szam, db);
            Console.ReadLine();

        }
    }
}
