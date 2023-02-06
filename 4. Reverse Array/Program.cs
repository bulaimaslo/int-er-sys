namespace _4._Reverse_Array;
class Program
{
    static void Main(string[] args)
    {
        int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
        while (n <= 0)
        {
            Console.WriteLine("Enter positive number");
            n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
        }

        string[] input = Console.ReadLine().Split();

        while (input.Length != n)
        {
            Console.WriteLine("Enter {0} values", n);
            input = Console.ReadLine().Split();
        }

        ReverseArray(input);

    }

    static void ReverseArray<T>(T[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            T temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
        }

        System.Console.WriteLine(string.Join(" ", array));
    }


}
