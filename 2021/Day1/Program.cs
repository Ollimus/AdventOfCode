string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PuzzleInput.dat"));
int[] parsedInput = Array.ConvertAll(input, x => int.Parse(x));

Console.WriteLine("--- Day 1 ---");
Console.WriteLine("--------- Part 1 ---------");

var count = Part1();

Console.WriteLine($"Solution for part 1: {count}");

Console.WriteLine("--------- Part 2 ---------");

count = Part2();

Console.WriteLine($"Solution for part 2: {count}");


// Part One Code
int Part1()
{
    int count = 0;
    int? previous = 0;

    foreach (int i in parsedInput)
    {
        if (i > previous && previous != null)
        {
            count++;
            Console.WriteLine($"Comparison: {i} - Previous: {previous}");
        }

        previous = i;
    }

    return count;
}


// Part Two Code
int Part2()
{
    int count = 0;
    int previous = 0;

    foreach (int i in parsedInput)
    {
        if (i > previous && previous != 0)
        {
            count++;
            Console.WriteLine($"Comparison: {i} - Previous: {previous}");
        }

        previous = i;
    }

    return count;
}