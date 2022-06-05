using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class InsertionSort
    {
        public void insertionSort(string[] array)
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
    }
}
