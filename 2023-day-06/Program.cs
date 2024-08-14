namespace _2023_day_06;

internal class Program
{
    private static (int, int)[] Races =
    [
        (53, 275),
        (71, 1181),
        (78, 1215),
        (80, 1524)
    ];

    private static (int, long) Race2 = (53717880, 275118112151524);
    static void Main(string[] args)
    {
        SolvePart2();
    }

    private static void SolvePart1()
    {
        int[] outcomes = new int[Races.Length];
        for (int i = 0; i < Races.Length; i++)
        {
            int result = 0;
            for (int j = 0; j < Races[i].Item1; j++)
            {
                int speed = j;
                int time = Races[i].Item1 - j;
                int distance = speed * time;
                if (distance > Races[i].Item2)
                {
                    result++;
                }
            }
            outcomes[i] = result;
        }

        foreach (int outcome in outcomes)
        {
            Console.WriteLine(outcome);
        }
        Console.WriteLine(outcomes.Aggregate(1, (i, j) => i * j));
    }

    private static void SolvePart2()
    {
        // this input is _much_ larger
        // a simple linear search might take a while
        // a binary search could more quickly find the right answer
        // .... or we treat this as an order-2 polynomial equation
        // and apply calculus to solve for the two "zeroes"

        DoALinearSearch();

        // in reality, the linear search still solved it in under 1s of run time. 
    }

    private static void DoALinearSearch()
    {
        long result = 0;
        for (long j = 0; j < Race2.Item1; j++)
        {
            long speed = j;
            long time = Race2.Item1 - j;
            long distance = speed * time;
            if (distance > Race2.Item2)
            {
                result++;
            }
        }

        Console.WriteLine(result);
    }
}
