using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\ostap\source\repos\ConsoleApp1\cod.txt");

            int n = 1, key = 1;


            Console.WriteLine("Ввидіть слово яке хочете зашифрувати: ");
            string s = Console.ReadLine();
            Console.WriteLine("Ввидіть слово яке хочете розшифрувати: ");
            string z = Console.ReadLine();


            Console.WriteLine("Ввидіть ключ: ");
            key = Convert.ToInt32(Console.ReadLine());

            string s1 = "";
            string z1 = "";

            string alfphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            int m = alfphabet.Length;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < alfphabet.Length; j++)
                {
                    if (s[i] == alfphabet[j])
                    {
                        int temp = j * n + key;

                        while (temp >= m)
                            temp -= m;

                        s1 = s1 + alfphabet[temp];
                    }
                }

            }
            Console.WriteLine("Зашифроване слово: " + s1);

            for (int i = 0; i < z.Length; i++)
            {
                for (int j = 0; j < alfphabet.Length; j++)
                {
                    if (z[i] == alfphabet[j])
                    {
                        int temp = j * n - key;

                        while (temp < 0)
                            temp += m;

                        z1 = z1 + alfphabet[temp];
                    }
                }

            }

            Console.WriteLine("Дешифроване слово: " + z1);
            Console.ReadLine();

            sw.WriteLine("Зашифроване слово: " + s1);
            sw.WriteLine("Дешифроване слово: " + z1);
            sw.Close();

        }
    }
}