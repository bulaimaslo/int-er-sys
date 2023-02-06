namespace _6._Permutation;
class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        System.Console.WriteLine(ExistsPermutation(arr1, arr2) ? "YES" : "NO");
    }

    static bool ExistsPermutation(int[] arr1, int[] arr2)
    {
        var dict = new Dictionary<int, int>();
        foreach (var item in arr1)
        {
            if (dict.ContainsKey(item))
                dict[item]++;
            else
                dict.Add(item, 1);
        }

        foreach (var item in arr2)
        {
            if (dict.ContainsKey(item))
                dict[item]--;
            else
                return false;
        }

        foreach (var item in dict)
        {
            if (item.Value != 0)
                return false;
        }

        return true;
    }
}
