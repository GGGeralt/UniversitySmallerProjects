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
        private int itemNumber=0;

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
            int index = Utilities.MyHashFunc(data, value);
            if (data[index].Contains(value))
            {
                Console.WriteLine($"Value {value} is actually on {index}, can't add duplicate");
                return;
            }
            data[index].Add(value);
            itemNumber++;

            if(itemNumber/data.Length >= 3)
            {
                IncreaseSize();
            }
        }

        public override int Find(int value)
        {
            int index = Utilities.MyHashFunc(data, value);

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
            int index = Utilities.MyHashFunc(data, value);

            foreach (int item in data[index])
            {
                if (item == value)
                {
                    data[index].Remove(value);
                    itemNumber--;
                    break;
                }
            }

            if (itemNumber / data.Length <= 1)
            {
                DecreaseSize();
            }
        }

        public override void IncreaseSize()
        {
            int size = data.Length * 2;
            Console.WriteLine($"size {size}, count {itemNumber}");

            List<int> values = new List<int>();

            foreach (List<int> item in data)
            {
                foreach (int val in item)
                {
                    values.Add(val);
                }
            }

            data = new List<int>[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = new List<int>();
            }

            itemNumber = 0;
            foreach (int item in values)
            {
                Insert(item);
            }
        }

        public override void DecreaseSize()
        {
            int size = data.Length / 2;
            Console.WriteLine($"size {size}, count {itemNumber}");

            List<int> values = new List<int>();

            foreach (List<int> item in data)
            {
                foreach (int val in item)
                {
                    values.Add(val);
                }
            }

            data = new List<int>[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = new List<int>();
            }

            itemNumber = 0;
            foreach (int item in values)
            {
                Insert(item);
            }
        }
    }
}
