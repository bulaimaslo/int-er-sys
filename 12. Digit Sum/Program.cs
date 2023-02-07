namespace _12._Digit_Sum;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        if (N == 0)
        {
            System.Console.WriteLine(0);
            return;
        }
        
        string[] inputNumbers = Console.ReadLine().Split(' ');
        System.Console.WriteLine(FindMaxDigitSumIndex(inputNumbers));
    }

    static int FindMaxDigitSumIndex(string[] inputNumbers)
    {
        int maxDigitSum = 0;
        int maxDigitSumIndex = -1;

        for (int i = 0; i < inputNumbers.Length; i++)
        {
            int digitSum = CalculateDigitSum(inputNumbers[i]);
            if (digitSum >= maxDigitSum)
            {
                maxDigitSum = digitSum;
                maxDigitSumIndex = i;
            }
        }

        return maxDigitSumIndex;
    }

    static int CalculateDigitSum(string number)
    {
        int digitSum = 0;
        foreach (char digit in number)
        {
            digitSum += digit - '0';
        }
        return digitSum;
    }
}
