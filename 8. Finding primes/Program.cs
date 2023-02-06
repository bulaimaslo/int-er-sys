namespace _8._Finding_primes;
class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        for (int i = 0; i < T; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            Console.WriteLine(FindPrimes(m, n));
        }
    }

    static int FindPrimes(int m, int n)
    {
        int count = 0;
        for (int i = m; i <= n; i++)
        {
            if (IsPrime(i))
            {
                count++;
            }
        }

        return count;
    }

    static bool IsPrime(int n)
    {
        if (n < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }


}
