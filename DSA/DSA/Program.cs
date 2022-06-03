Console.WriteLine("1.Permutation\n2.Binary Search\n3.Insertion Sort\nEnter your choice:");
int choice = Convert.ToInt32(Console.ReadLine());
DSA.Algorithm algo = new DSA.Algorithm();
switch (choice)
{
    case 1:
        Console.WriteLine("Enter String:");
        string a = Console.ReadLine();
        int len = a.Length;
        Console.WriteLine("Permutations are:");
        algo.permutation(a, 0, len);
        break;
    case 2:
        Console.WriteLine("enter word to search:");
        string str = Console.ReadLine();
        algo.search(str);
        break;
    case 3:
        Console.WriteLine("How many strings you want to add:");
        int no = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[no];
        for (int i = 0; i < no; i++)
        {
            Console.WriteLine("Enter string:");
            string s = Console.ReadLine();
            array[i] = s;
        }
        algo.InsertionSort(array);
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}

