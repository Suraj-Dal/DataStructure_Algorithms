Console.WriteLine("1.Permutation\n2.Binary Search\n3.Insertion Sort\n4.Bubble Sort\n5.Anagram Detection\n6.UnOrdered List\n7.Ordered List\n8.Balanced Expression\nEnter your choice:");
int choice = Convert.ToInt32(Console.ReadLine());
DSA.Algorithm algo = new DSA.Algorithm();
DSA.DataStructure ds = new DSA.DataStructure();
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
    case 4:
        Console.WriteLine("How many strings you want to add:");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] unsorted = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter string:");
            string s = Console.ReadLine();
            unsorted[i] = s;
        }
        algo.BubbleSort(unsorted);
        break;
    case 5:
        Console.WriteLine("Enter first strings:");
        string s1 = Console.ReadLine();
        Console.WriteLine("Enter first strings:");
        string s2 = Console.ReadLine();
        algo.Anagram(s1, s2);
        break;
    case 6:
        Console.WriteLine("Enter word to search:");
        string w = Console.ReadLine();
        ds.UnOrdered(w);
        break;
    case 7:
        Console.WriteLine("Enter word to search:");
        string order = Console.ReadLine();
        ds.Ordered(order);
        break;
    case 8:
        Console.WriteLine("Enter Arithmetic Expression:");
        string exp = Console.ReadLine();
        ds.BalancedParanthesis(exp);
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}

