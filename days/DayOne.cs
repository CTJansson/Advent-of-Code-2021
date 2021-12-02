public static class DayOne
{
    public static void Run()
    {
        List<int> numbers = File.ReadAllLines("./inputs/dayone.txt").Select(int.Parse).ToList();

        int increamentPartA = 0;
        int increamentPartB = 0;

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i-1] < numbers[i]) 
            {
                increamentPartA++;
            }

            if (i +2 < numbers.Count)
            {
                int compareA = numbers[i - 1] + numbers[i] + numbers[i + 1];
                int compareB = numbers[i] + numbers[i + 1] + numbers[i + 2];

                if (compareA < compareB)
                {
                    increamentPartB++;
                }
            }    
        }
        Console.WriteLine("Advent of Code - Day 1:");
        Console.WriteLine("Part A: " + increamentPartA.ToString());
        Console.WriteLine("Part B: " + increamentPartB.ToString());
        Console.WriteLine("-------------------------------------");
    }
}