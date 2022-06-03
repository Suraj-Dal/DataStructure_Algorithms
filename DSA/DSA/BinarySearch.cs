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
            int flag = 0;
            int s = 0, e = words.Length;
            while (s < e - 1)
            {
                
                int mid = (s + e) / 2;
                if (words[mid].Equals(str) || words[mid+1].Equals(str) || words[mid-1].Equals(str))
                {
                    Console.WriteLine("Word found in file.");
                    return;
                }
                else if (words[mid].CompareTo(str) > 0)
                    e = mid - 1;
                else if (words[mid].CompareTo(str) < 0)
                    s = mid + 1;
            }
            if (flag == 0)
            {
                Console.WriteLine("Word not found in file.");
            }
        }
    }
}
