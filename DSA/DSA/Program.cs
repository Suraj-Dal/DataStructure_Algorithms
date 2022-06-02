DSA.Algorithm algo = new DSA.Algorithm();
Console.WriteLine("Enter String:");
string str = Console.ReadLine();
int len = str.Length;
Console.WriteLine("Permutations are:");
algo.permutation(str, 0, len);
