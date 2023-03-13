using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Utilities.DataTypes
{
    public class Result
    {
        int computationalComplexity;
        int memoryComplexity;
        int index;

        public Result()
        {
            computationalComplexity = 0;
            memoryComplexity = 0;
            index = 0;
        }

        public Result(int memoryComplexity, int computationalComplexity, int index)
        {
            this.computationalComplexity = computationalComplexity;
            this.memoryComplexity = memoryComplexity;
            this.index = index;
        }

        public int GetComputationalComplexity()
        {
            return computationalComplexity;
        }

        public int GetMemoryComplexity()
        {
            return memoryComplexity;
        }

        public int GetIndex()
        {
            return index;
        }
    }
}
