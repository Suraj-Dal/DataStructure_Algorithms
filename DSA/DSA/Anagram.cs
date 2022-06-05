using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Anagram
    {
        public void anagram(string str1, string str2)
        {
            if (str1.Length.Equals(str2.Length))
            {
                int flag = 0;
                for (int i = 0; i < str1.Length; i++)
                {
                    for (int j = 0; j < str2.Length; j++)
                    {
                        if (str1[i].Equals(str2[j]))
                            flag++;
                    }
                }
                if (flag == str1.Length)
                {
                    Console.WriteLine("Strings are Anagram.");
                    return;
                }
                Console.WriteLine("Strings are not Anagram.");
            }
        }
    }
}
