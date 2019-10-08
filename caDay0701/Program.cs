using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace caDay0701
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] kata = input.ToCharArray();
            int n = input.Length;
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                x = x * i;
                Console.WriteLine(x);
            }
            permute(input, 0, n - 1, x);
            int range = kata.Length;
            int[] angka = new int[range];
            string[] array = new string[range];
            int[] banding = new int[range-2];
            int[] pembanding = new int[(range - 1) * range];
            int rangePem = pembanding.Length;
            int rangeBan = banding.Length;
            //string[] tampung = new string[(range - 1) * range];
            //char tmp;

            /*for (int i = 0; i < range-2; i++)
            {
                array[i] = input.Substring(i, 3);
                banding[i] = Convert.ToInt32(array[i]);
                Console.Write(banding[i] + " "); 
            } 
            Console.WriteLine();
            pembanding[0] = banding.Max();
            Console.WriteLine(pembanding);*/
            Console.ReadKey();
        }
        protected static void permute(String input,
                                int l, int r, int r1)
        {
            
            
            
            
            if (l == r)
            {
                //Console.WriteLine(input);
                //array = input.ToArray();
                list(input, l, r, r1);
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    input = swap(input, l, i);
                    permute(input, l + 1, r, r1);
                    input = swap(input, l, i);
                }
            }
            
        }
        public static String swap(String a,
                                  int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
        public static void list(String arr, int p, int q, int m)
        {
            //string[] newArray = new string[m];
            //string[] arrayBaru = new string[(q - 3) * m];
            int[] banding = new int[q - 3];
            //char[] array = new char[m];
            char[] array = arr.ToArray();
            //Console.WriteLine(array);
            string arrayBaru = new string(array);
            string newArray = new string(arrayBaru);
            newArray = arrayBaru.ToString();
            /*for (int i = p; i < q; i++)
            {
                newArray[i] = arrayBaru.ToString();
                
            }*/
            foreach (char item in newArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            
        }
    }
}