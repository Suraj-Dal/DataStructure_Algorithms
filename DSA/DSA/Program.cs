Console.WriteLine("1.Permutation\n2.Binary Search\nEnter your choice:");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        DSA.Algorithm algo = new DSA.Algorithm();
        Console.WriteLine("Enter String:");
        string a = Console.ReadLine();
        int len = a.Length;
        Console.WriteLine("Permutations are:");
        algo.permutation(a, 0, len);
        break;
    case 2:
        DSA.BinarySearch binary = new DSA.BinarySearch();
        Console.WriteLine("enter word to search:");
        string str = Console.ReadLine();
        binary.search(str);
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}

