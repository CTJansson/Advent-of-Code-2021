public static class DayThree
{
    public static void Run()
    {
        List<string> binaries = File.ReadAllLines("./inputs/daythree.txt").ToList();

        string epsilon = "";
        string gamma = "";

        for (int i = 0; i < binaries[0].Length; i++)
        {
            int zero = 0;
            int one = 0;

            for (int j = 0; j < binaries.Count; j++)
            {
                switch (binaries[j].Substring(i, 1))
                {
                    case "0":
                        zero++;
                        break;
                    case "1":
                        one++;
                        break;
                }
            }

            if (zero > one)
            {
                gamma += "0";
                epsilon += "1";
            }
            else
            {
                gamma += "1";
                epsilon += "0";
            }
        }

        Console.WriteLine("Advent of Code - Day 3");
        Console.WriteLine("Part A: " + Convert.ToInt32(epsilon, 2) * Convert.ToInt32(gamma, 2));
        Console.WriteLine("-------------------------------------");
    }
}