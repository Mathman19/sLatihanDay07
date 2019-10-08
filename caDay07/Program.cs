using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tulis elemen pada himpunan A :");
            char[] input1 = Console.ReadLine().ToCharArray();
            Console.WriteLine("Tulis elemen pada himpunan B :");
            char[] input2 = Console.ReadLine().ToCharArray();
            int range1 = input1.Length;
            int range2 = input2.Length;

            int banyak = 0;
            
            //pembanding
            for (int i = 0; i<range1; i++)
            {
                for (int j = 0; j<range2; j++)
                {
                    if (input1[i] == input2[j])
                    {
                        banyak = banyak + 1;
                    }
                }
            }

            Console.Write("Angka yang sama ada " + banyak);
            Console.ReadKey();
        }
    }
}
