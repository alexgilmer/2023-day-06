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
    static void Main(string[] args)
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
}
