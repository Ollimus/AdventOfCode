string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PuzzleInput.dat"));

Console.WriteLine("--- Day 2 ---");
Console.WriteLine("--------- Part 1 ---------");

var count = Part1();

Console.WriteLine($"Solution for part 1: {count}");

Console.WriteLine("--------- Part 2 ---------");

count = Part2();

Console.WriteLine($"Solution for part 2: {count}");


// Part One Code
int Part1()
{
    int horizontalTotal = 0;
    int depthTotal = 0;

    foreach (var item in input)
    {
        string[] splitValues = new string[2];
        splitValues = item.Split(' ');

        var value = int.Parse(splitValues[1]);

        switch (splitValues[0])
        {
            case "forward":
                horizontalTotal += value;
                break;

            case "down":
                depthTotal += value;
                break;

            case "up":
                depthTotal -= value;
                break;
        }
    }

    return horizontalTotal * depthTotal;
}


// Part Two Code
int Part2()
{
    int horizontalTotal = 0;
    int depthTotal = 0;
    int aimTotal = 0;

    foreach (var item in input)
    {
        string[] splitValues = new string[2];
        splitValues = item.Split(' ');

        var value = int.Parse(splitValues[1]);

        switch (splitValues[0])
        {
            case "forward":
                horizontalTotal += value;
                depthTotal += value * aimTotal;
                break;

            case "down":
                aimTotal += value;
                break;

            case "up":
                aimTotal -= value;
                break;
        }
    }

    return horizontalTotal * depthTotal;
}