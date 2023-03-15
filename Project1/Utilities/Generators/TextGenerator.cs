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

            text += ((char)random.Next(65, 91)).ToString();

            return text;
        }

        public string Generate(int length)
        {
            string text = string.Empty;

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                text += ((char)'a' + random.Next(0, 25)).ToString();

            }

            return text;
        }

        public string GenerateFromTo(char from, char to, int length)
        {
            string text = string.Empty;

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                text += ((char)random.Next((int)from, (int)(to + 1))).ToString();

            }

            return text;
        }

        public string GenerateFromAplhabet(int length)
        {
            return GenerateFromTo('A', 'Z', length);
        }
    }
}
