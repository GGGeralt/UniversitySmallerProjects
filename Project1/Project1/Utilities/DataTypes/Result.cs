using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Utilities.DataTypes
{
    public class Result
    {
        int memoryComplexity;
        int computationalComplexity;
        int index;

        public Result()
        {
            memoryComplexity = 0;
            computationalComplexity = 0;
            index = 0;
        }

        public Result(int memoryComplexity, int computationalComplexity, int index)
        {
            this.memoryComplexity = memoryComplexity;
            this.computationalComplexity = computationalComplexity;
            this.index = index;
        }
    }
}
