using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Dictonaries
{
    internal class OpenDict : DictonaryBase
    {
        public int[] data;

        public OpenDict()
        {
            data = new int[10];
            for (int i = 0; i < 10; i++)
            {
                data[i] = -1;
            }
        }

        public OpenDict(int capacity)
        {
            data = new int[capacity];
            for (int i = 0; i < capacity; i++)
            {
                data[i] = -1;
            }
        }

        //TODO:
        // add checking to not creating duplicates  http://pbeling.w8.pl/algorithms/hash_tables.pdf page 22
        //TODO::
        public override void Insert(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int index = Utilities.MyHashFunc(value + i);
                if (data[index] == -1 || data[index] == -2)
                {
                    data[index] = value;
                    break;
                }
            }
        }
        public override int Find(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int index = Utilities.MyHashFunc(value + i);
                if (data[index] == value)
                {
                    return index;
                }
                else if(data[index] == -1)
                {
                    return -1;
                }
            }
            return -1;
        }
        public override void Delete(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int index = Utilities.MyHashFunc(value + i);
                if (data[index] == value)
                {
                    data[index] = -2;
                    break;
                }
            }
        }
    }
}
