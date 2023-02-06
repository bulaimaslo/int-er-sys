namespace _7._Existing_powers_of_2;
class Program
{
    static void Main(string[] args)
    {
        List<uint> input = new List<uint>();

        while (true)
        {
            string line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
                break;

            input.Add(uint.Parse(line));
        }

        List<uint> powers = PowersOfTwo(input);
        powers.Sort();
        System.Console.WriteLine(string.Join(" ", powers));

    }

    static List<uint> PowersOfTwo(List<uint> input)
    {
        HashSet<uint> powerNumbers = new HashSet<uint>();

        foreach (var number in input)
        {
            if (number == 0)
            {
                continue;
            }
            else if (number == 1)
            {
                powerNumbers.Add(number);
            }
            else
            {
                HashSet<uint> decomposed = DecomposeNumber(number);
                powerNumbers.UnionWith(decomposed);
            }
        }

        return powerNumbers.ToList();
    }

    static HashSet<uint> DecomposeNumber(uint number)
    {
        HashSet<uint> powers = new HashSet<uint>();

        while (number > 1)
        {
            uint power = 1;
            while (power * 2 <= number)
            {
                power *= 2;
            }

            powers.Add(power);
            number -= power;
        }

        return powers;
    }


}
