using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string[] a = t.Split();
            string b = "";
            string c = "";
            string d = "";
            int cc = 0;
            foreach (string i in a)
            {
                b = i.Substring(0);
                int bb = b.Length;
                if (bb > cc)
                {
                    cc = bb;
                    d = i.Substring(0);
                }
            }
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
