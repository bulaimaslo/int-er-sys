namespace _5._Palindrome;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string inputOnlyLetters = RemoveNonLetters(input);
        System.Console.WriteLine(IsPalindrome(inputOnlyLetters) ? "yes" : "no");
    }

    static bool IsPalindrome(string input)
    {
        for (int i = 0; i < input.Length / 2; i++)
        {
            if (input[i] != input[input.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }

    static string RemoveNonLetters(string input)
    {
        StringBuilder result = new StringBuilder();
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}
