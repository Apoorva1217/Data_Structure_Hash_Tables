using System;

namespace DataStructureHashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Hash Tables!");

            MyMapNode<int, string> hash = new MyMapNode<int, string>(20);
            string[] phrase = new string[] {"Paranoids", "are", "not", "paranoid", "because", "they",
                "are", "paranoid", "but", "because", "they", "keep", "putting", "themselves",
                "deliberately", "into", "paranoid", "avoidable", "situations"};

            int Key = 0;
            foreach (string word in phrase)
            {
                hash.Add(Key, word);
                Key++;
            }
            Console.WriteLine("Frequency : " + hash.GetFrequency("paranoid"));

        }
    }
}
