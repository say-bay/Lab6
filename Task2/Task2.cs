using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] arrey = text.Split();
            string text1 = String.Join("", arrey);
            string text2 = "";
            for (int i = 0; i < text1.Length; i++)
            {
                string textInsert = text1.Substring((text1.Length - 1 - i), 1);
                text2 = text2 + textInsert;
            }
            int result = String.Compare(text1, text2);
            if (result == 0)
            {
                Console.WriteLine("Является палиндромом");
            }
            else
            {
                Console.WriteLine("Не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
