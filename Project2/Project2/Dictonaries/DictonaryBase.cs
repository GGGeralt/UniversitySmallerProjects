using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Dictonaries
{
    abstract class DictonaryBase
    {
        public abstract void Insert(int value);
        public abstract void Delete(int value);
        public abstract int Find(int value);
        public abstract void IncreaseSize();
        public abstract void DecreaseSize();
    }
}
