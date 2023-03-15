using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Utilities.DataTypes
{
    public class Result
    {
        public int computationalComplexity;
        public int memoryComplexity;
        public List<int> indexes;

        public Result()
        {
            computationalComplexity = 0;
            memoryComplexity = 0;
            indexes = new List<int>();
        }

        public Result(int memoryComplexity, int computationalComplexity, List<int> index)
        {
            this.computationalComplexity = computationalComplexity;
            this.memoryComplexity = memoryComplexity;
            this.indexes = index;
        }

    }
}
