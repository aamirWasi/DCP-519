using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_519
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 1; t <= T; t++)
            {
                long x = 2;
                int n, i;
                n = int.Parse(Console.ReadLine());
                while (n > 0)
                {
                    for (i = 2; i < x; i++)
                    {
                        if (x % i == 0) break;
                    }
                    if (x == i)
                    {
                        Console.Write($"Caso {t}-> {x.ToString()} ");
                        n--;
                    }
                    x++;
                }
                Console.WriteLine();
            }
        }
    }
}
