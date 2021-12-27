string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PuzzleInput.dat"));
int bitLength = input[0].Length; // We'll just grab the length of the bit so we don't have magic later.
//int[] parsedInput = Array.ConvertAll(input, x => int.Parse(x));

Console.WriteLine("--- Day 3 ---");
Console.WriteLine("--------- Part 1 ---------");

var count = Part1();

Console.WriteLine($"Solution for part 1: {count}");

Console.WriteLine("--------- Part 2 ---------");

count = Part2();

Console.WriteLine($"Solution for part 2: {count}");


// Part One Code
int Part1()
{
    (int one, int zero) bitCounts = (0,0);
    int[] gamma = new int[bitLength];
    int[] epsilon = new int[bitLength];

    for (int i = 0; i < bitLength; i++)
    {
        for (int x = 0; x < input.Length; x++)
        {
            var test = input[x];
            var bit = test[i].ToString();

            if (bit == "1")
            {
                bitCounts.one++;
            }

            else
                bitCounts.zero++;
        }

        if (bitCounts.one > bitCounts.zero)
        {
            gamma[i] = 1;
            epsilon[i] = 0;
        }

        else
        {
            gamma[i] = 0;
            epsilon[i] = 1;
        }

        bitCounts = (0, 0);
    }

    var decimalConvertedGamma = BinaryToDecimal(gamma);
    var decimalConvertedEpsilon = BinaryToDecimal(epsilon);

    return decimalConvertedGamma * decimalConvertedEpsilon;
}

int BinaryToDecimal(int[] input)
{
    string binary = "";

    foreach (var item in input)
    {
        binary += item.ToString();
    }

    return Convert.ToInt32(binary, 2);
}


// Part Two Code
int Part2()
{
    return 0;
}