using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Utilities.Generators
{
    public class TextGenerator
    {
        public string Generate()
        {
            string text = string.Empty;

            Random random = new Random();

            text += ((char)random.Next(65, 90)).ToString();

            return text;
        }

        public string Generate(int length)
        {
            string text = string.Empty;

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                text += ((char)random.Next(65, 90)).ToString();

            }

            return text;
        }
    }
}
