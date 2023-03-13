using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Utilities.DataTypes;

namespace Project1.Algorithms
{
    internal interface Algorithm
    {
        public Result Run(string text, string pattern);
    }
}
