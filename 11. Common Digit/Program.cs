namespace _11._Common_Digit;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] inputNumbers = Console.ReadLine().Split(' ');
        System.Console.WriteLine(FindCommonDigit(inputNumbers));
    }

    static char FindCommonDigit(string[] inputNumbers)
    {
        int[] digitsCount = new int[10];

        foreach (string number in inputNumbers)
        {
            foreach (char digit in number)
            {
                digitsCount[digit - '0']++;
            }
        }

        int maxCount = 0;
        int maxCountDigit = -1;
        for (int i = 0; i < 10; i++)
        {
            if (digitsCount[i] >= maxCount)
            {
                maxCount = digitsCount[i];
                maxCountDigit = i;
            }
        }

        return (char)(maxCountDigit + '0');

    }


}
