using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Dictonaries
{
    internal class ChainDict : DictonaryBase
    {
        public List<int>[] data;

        public ChainDict()
        {
            data = new List<int>[10];
            for (int i = 0; i < 10; i++)
            {
                data[i] = new List<int>();
            }
        }
        public ChainDict(int capacity)
        {
            data = new List<int>[capacity];
            for (int i = 0; i < capacity; i++)
            {
                data[i] = new List<int>();
            }
        }


        public override void Insert(int value)
        {
            int index = Utilities.MyHashFunc(value);
            data[index].Add(value);
        }
        public override int Find(int value)
        {
            int index = Utilities.MyHashFunc(value);

            foreach (int item in data[index])
            {
                if(item ==value)
                {
                    return index;
                }
            }
            return -1;
        }
        public override void Delete(int value)
        {
            int index = Utilities.MyHashFunc(value);

            foreach (int item in data[index])
            {
                if (item == value)
                {
                    data[index].Remove(value);
                    break;
                }
            }
        }
    }
}
