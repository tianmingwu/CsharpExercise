Console.WriteLine("Exercise 1:");
LinqExercise.Exercise1.Solve();
Console.WriteLine("\n");

Console.WriteLine("Exercise 2:");
LinqExercise.Exercise2.Solve();
Console.WriteLine("\n");

Console.WriteLine("Exercise 3:");
LinqExercise.Exercise3.Solve();
Console.WriteLine("Another method:");
LinqExercise.Exercise3.Solve2();
Console.WriteLine("\n");

Console.WriteLine("Exercise 4:");
LinqExercise.Exercise4.Solve();
Console.WriteLine("\n");

namespace LinqExercise
{
    public class Exercise1
    {
        private static int[] Numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

        public static void Solve()
        {
            foreach (var number in Numbers.Where(x=>x%2==0))
            {
                Console.Write(number + ", ");
            }
        }
    }
    public class Exercise2
    {
        private static int[] Numbers = {
            1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
        };

        public static void Solve()
        {
            foreach (var num in Numbers.Where(x=>x>0).Where(x=>x<12))
            {
                Console.Write(num+", ");
            }
        }
    }
    public class Exercise3
    {
        private static int[] Numbers = {3, 9, 2, 8, 6, 5};

        public static void Solve()
        {
            foreach (var number in Numbers.Where(x=>x*x>20))
            {
                Console.WriteLine($"{{Number = {number}, SqrNo = {number*number}}}");
            }
        }
        public static void Solve2()
        {
            foreach (
                var numPairs in Numbers
                .Select(x => new {Number=x, SqrNo = x*x})
                .Where(x => x.SqrNo>20)
            )
            {
                Console.WriteLine(numPairs);
            }
        }
    }
    public class Exercise4
    {
        private static int[] Numbers = {5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2};

        public static void Solve()
        {
            Console.Write("Numbers in the array are:");
            foreach(int num in Numbers)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine("\n");
            var numGroups = Numbers.GroupBy(x=>x);
            foreach(var num in numGroups)
            {
                Console.WriteLine($"Number {num.Key} appears {num.Count()} times");
            }
        }
    }

}
