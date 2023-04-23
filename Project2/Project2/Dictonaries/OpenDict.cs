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
        public int itemNumber = 0;
        int size;

        public OpenDict()
        {
            size = 10;
            data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = -1;
            }
        }
        public OpenDict(int capacity)
        {
            size = capacity;
            data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = -1;
            }
        }

        public override void Insert(int value)
        {

            for (int i = 0; i < size; i++)
            {
                int index = Utilities.MyHashFunc(data, value + i);
                if (data[index] == value)
                {
                    Console.WriteLine($"Value {value} is actually on {index}, can't add duplicate");
                    return;
                }
                else if (data[index]==-1)
                {
                    break;
                }
            }
            for (int i = 0; i < data.Length; i++)
            {
                int index = Utilities.MyHashFunc(data, value + i);
                if (data[index] == -1 || data[index] == -2)
                {
                    data[index] = value;
                    itemNumber++;
                    break;
                }
            }

            //if ((data.Length - itemNumber) / (double)data.Length < 0.3)
            //{
            //    IncreaseSize();
            //}
        }

        public override int Find(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int index = Utilities.MyHashFunc(data, value + i);
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
                int index = Utilities.MyHashFunc(data, value + i);
                if (data[index] == value)
                {
                    data[index] = -2;
                    itemNumber--;
                    break;
                }
            }

            //if ((data.Length - itemNumber) / (double)data.Length >= 0.7 )
            //{
            //    DecreaseSize();
            //}
        }

        public override void IncreaseSize()
        {
            size = data.Length * 2;
            Console.WriteLine($"Increasing size to {size}");

            int[] values = new int[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                values[i] = data[i];
            }

            data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = -1;
            }

            itemNumber = 0;
            foreach (int item in values)
            {
                if(item != -1 && item != -2)
                {
                    Insert(item);
                }
            }
        }

        public override void DecreaseSize()
        {
            size = data.Length / 2;
            Console.WriteLine($"Decreasing size to {size}");

            int[] values = new int[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                values[i] = data[i];
            }

            data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = -1;
            }

            itemNumber = 0;
            foreach (int item in values)
            {
                if (item != -1 && item != -2)
                {
                    Insert(item);
                }
            }
        }
    }
}
