using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DSA
{
    internal class Algorithm
    {
        public void permutation(String str, int s, int e)
        {
           if (s == e - 1)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = s; i < e; i++)
                {
                    str = swap(str, s, i);
                    permutation(str, s + 1, e);
                    str = swap(str, s, i);
                }
            }
        }
        public string swap(string str, int s, int e)
        {
            char[] ch = str.ToCharArray();
            char c;
            c = ch[s];
            ch[s] = ch[e];
            ch[e] = c;
            return string.Join("",ch);
        }
    }
}
