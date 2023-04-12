using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public static class Utilities
    {
        #region Hashes
        public static int MyHashFunc(int[] dict, int value)
        {
            return value % dict.Length;
        }
        public static int MyHashFunc(List<int>[] dict, int value)
        {
            return value % dict.Length;
        }
        #endregion Hashes
        #region WritingOut
        public static void WriteOutDict(List<int>[] dict)
        {
            Console.WriteLine(dict.Length);
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
        #endregion WritingOut
    }
}
