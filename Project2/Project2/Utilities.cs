using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public static class Utilities
    {

        public static int MyHashFunc(int value)
        {
            return value % 10;
        }

        public static void WriteOutDict(List<int>[] dict)
        {
            for (int i = 0; i < dict.Length; i++)
            {
                Console.Write(i + "||");
                foreach (int item in dict[i])
                { 
                    Console.Write(item + "->");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void WriteOutDict(int[] dict)
        {
            for (int i = 0; i < dict.Length; i++)
            {
                Console.Write(i + "||" + dict[i]);

                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
