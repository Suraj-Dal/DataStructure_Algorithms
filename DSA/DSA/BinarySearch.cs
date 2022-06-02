using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DSA
{
    internal class BinarySearch
    {
        public void search(string str)
        {
            string text = File.ReadAllText(@"D:\Suraj\Projects\DataStructure_Algorithms\binary.txt");
            string[] words = text.Split(' ');
            Array.Sort(words);
            int s = 0, e = words.Length;
            while (s <= e)
            {
                int mid = (s + e) / 2;
                if (words[mid].Equals(str))
                {
                    Console.WriteLine("Word found in file.");
                    return;
                }
                else if (words[mid].CompareTo(str) > 0)
                    e = mid - 1;
                else
                    e = mid + 1;
                Console.WriteLine("Word not found in file.");
                return;
            }
            
        }
    }
}
