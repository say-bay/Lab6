using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int positionCh1 = text.IndexOf('{');
            int positionCh2 = text.IndexOf('}');
            do
            {
                positionCh1 = text.IndexOf('{');
                positionCh2 = text.IndexOf('}');
                if ((positionCh1 < positionCh2) && (positionCh1 >= 0) && (positionCh2 >= 0))
                {
                    text = text.Remove(positionCh1, (positionCh2 - positionCh1 + 1));
                }
            }
            while ((positionCh1 >= 0) && (positionCh2 >= 0));
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
