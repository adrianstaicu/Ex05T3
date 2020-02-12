using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Transformati un sir de caractere astfel: fiecare litera de pe pozitie para sa fie uppercase.

            string value = "ana are mere";
            char[] chararray = value.ToCharArray();

            for(int i = 0; i < chararray.Length; i++)
            {
                if (i % 2 == 0)
                    chararray[i] = char.ToUpper(value[i]);
            }
            Console.WriteLine(chararray);
        }
    }
}
