using System;

namespace encryption // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            string input;
            string output = "";
            int key;
            Console.WriteLine("Hello World!");
            
            input = Console.ReadLine();
            Console.WriteLine("enter key");
            key = Convert.ToInt32(Console.ReadLine());
            
            foreach (char c in input)
            {
                int thinking = System.Convert.ToInt32(c);
                if (thinking == 32)
                {
                    output += (Convert.ToChar(thinking));
                }
                else
                {
                    thinking = thinking + key;
                    if (thinking > 122)
                    {
                        thinking = thinking - 26;
                    }
                    output += (Convert.ToChar(thinking));
                }
            }


            Console.WriteLine(output);
            decrypt(output, key);
            Console.ReadKey();
        }
        static void decrypt(string output, int key) {
            string secondout = "";
            foreach (char c in output)
            {
                int thinking = System.Convert.ToInt32(c);
                if (thinking == 32)
                {
                    secondout += (Convert.ToChar(thinking));
                }
                else
                {
                    thinking = thinking - key;
                    if (thinking < 100)
                    {
                        thinking = thinking + 26;
                    }
                    secondout += (Convert.ToChar(thinking));
                }
            }
            Console.WriteLine(secondout);
            Console.ReadKey();
        }

    }
}
