public static class DayTwo
{
    public static void Run()
    {
        List<string> lines = File.ReadAllLines("./inputs/daytwo.txt").ToList();

        int depth = 0;
        int horizontalPos = 0;

        foreach (var line in lines)
        {
            string[] action = line.Split(' ');
            int speed = int.Parse(action[1]);

            switch (action[0])
            {
                case "forward":
                    horizontalPos += speed;
                    break;
                case "down":
                    depth += speed;
                    break;
                case "up":
                    depth -= speed;
                    break;
            }
        }

        Console.WriteLine("Advent of Code - Day 2");
        Console.WriteLine("Part A: " + horizontalPos * depth);

    }
}