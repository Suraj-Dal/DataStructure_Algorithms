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
                if (words[mid].Equals(str) || words[mid + 1].Equals(str) || words[mid - 1].Equals(str))
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
        public void InsertionSort(string[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j].CompareTo(array[i]) > 0)
                    {
                        string temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array is:");
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
        public void BubbleSort(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j+1]) > 0)
                    {
                        string temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array is:");
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
        public void Anagram(string str1, string str2)
        {
            if (str1.Length.Equals(str2.Length))
            {
                int flag = 0;
                for (int i =0; i < str1.Length; i++)
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
