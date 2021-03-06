using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
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

Console.WriteLine("Exercise 5:");
LinqExercise.Exercise5.Solve();
Console.WriteLine("\n");

Console.WriteLine("Exercise 6:");
LinqExercise.Exercise6.Solve();
Console.WriteLine("\n");

Console.WriteLine("Exercise 7:");
LinqExercise.Exercise7.Solve();
Console.WriteLine("\n");

Console.WriteLine("Exercise 8:");
LinqExercise.Exercise8.Solve();
Console.WriteLine("\n");

Console.WriteLine("Exercise 11:");
LinqExercise.Exercise11.Solve();
Console.WriteLine("\n");

Console.WriteLine("Exercise 13:");
LinqExercise.Exercise13.Solve();
Console.WriteLine("\n");

Console.WriteLine("Exercise 16:");
LinqExercise.Exercise16.Solve();

Console.WriteLine("Exercise 23:");
LinqExercise.Exercise23.Solve();
*/
namespace CSharpExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            //RecursionExercise.PrintNumber.Solve();
            //RecursionExercise.PrintNumberBackwards.Solve();
            //RecursionExercise.SumNaturalNumbers.Solve();
            //RecursionExercise.TestPalindrome.Solve();
            RecursionExercise.ReverseString.Solve();

            Console.ReadLine();
        }
    }
}

namespace RecursionExercise
{
    public class PrintNumber
    {
        public static void Solve()
        {
            Console.WriteLine("Using recursive method to print n natural numbers.");

            Console.Write("How many numbers to print? ");
            int n = Convert.ToInt32(Console.ReadLine());

            Print(n, 1);
        }

        private static void Print(int targetNumber, int currentNumber)
        {
            if (currentNumber <= targetNumber)
            {
                Console.Write(currentNumber + " ");
                Print(targetNumber, currentNumber + 1);
            }
            else
            {
                Console.WriteLine();
            }
        }
    }

    public class PrintNumberBackwards
    {
        public static void Solve()
        {
            int n;
            Console.WriteLine("Write a program in C# to print numbers from n to 1 using recursion.");

            Console.Write("How many numbers to print: ");

            n = Convert.ToInt32(Console.ReadLine());

            Print(n);
        }

        static void Print(int targetNumber)
        {
            Console.Write($"{targetNumber} ");
            if (targetNumber > 1)
            {
                Print(targetNumber - 1);
            }
            else
            {
                Console.WriteLine();
            }
        }
    }

    public class SumNaturalNumbers
    {
        public static void Solve()
        {
            int targetNumber, sum;
            Console.WriteLine("Write a program in C# to find the sum of first n natural numbers using recursion.");

            Console.Write("How many numbers to sum: ");
            targetNumber = Convert.ToInt32(Console.ReadLine());

            sum = Sum(targetNumber);

            Console.WriteLine($"The sum of first {targetNumber} natural numbers is {sum}.");
        }
        static int Sum(int targetNumber)
        {
            return targetNumber == 0 ? 0 : targetNumber + Sum(targetNumber - 1);
        }
    }

    public class TestPalindrome
    {
        public static void Solve()
        {
            string userInputString, resultString;

            Console.WriteLine("Check whether a given string is Palindrome or not using recursion.");
            Console.Write("Please input a string: ");

            userInputString = Console.ReadLine();

            resultString = IsPalindrome(userInputString) ? "" : "not ";

            Console.WriteLine($"{userInputString} is {resultString}a palindrome.");
        }
        private static bool IsPalindrome(string str)
        {
            int strLength = str.Length;
            Console.WriteLine($"Checking {str}...");
            if (strLength <= 1)
            {
                return true;
            }
            else
            {
                return (str.First() == str.Last()) && IsPalindrome(str.Substring(1, strLength - 2));
            }
        }
    }

    public class ReverseString
    {
        public static void Solve()
        {
            Console.Write("Reverse string. Please input a string: ");
            string userInputString = Console.ReadLine();

            string revStr = RevStr(userInputString);
            Console.WriteLine($"Reversed string is {revStr}.");
        }

        private static string RevStr(string str)
        {
            if (str.Length == 1)
                return str;
            else
            {
                return RevStr(str.Substring(1, str.Length - 1)) + str.Substring(0, 1);
            }
        }
    }
}

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
    public class Exercise5
    {   
        private static string InputString;
        public static void Solve()
        {
            Console.Write("Input the string: ");
            InputString = Console.ReadLine() ?? "";

            foreach(var obj in InputString.ToArray().GroupBy(x=>x))
            {
                int count = obj.Count();
                Console.WriteLine($"Character {obj.Key}: {count} {(count==1?"time":"times")}");
            }
        }
    }
    public class Exercise6
    {
        public static void Solve()
        {
            foreach(var day in Enum.GetNames(typeof(DayOfWeek)))
            {
                Console.WriteLine(day);
            }
        }
    }
    public class Exercise7
    {
        private static int[] Numbers = {5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2};
        public static void Solve()
        {
            foreach(var obj in Numbers.GroupBy(x=>x))
            {
                int num = obj.Key;
                int fre = obj.Count();
                Console.WriteLine($"{num} {num*fre} {fre}");
            }
        }
    }
    public class Exercise8
    {
        static string[] Cities = {"ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "new delhi",
        "AMSTERDAM", "ABU DHABI", "PARIS", "PALM SPRINGS"};
        public static void Solve()
        {
            Console.Write("Input starting character for the string:");
            string startingChar = (Console.ReadLine() ?? "*").ToUpper();

            Console.Write("Input ending character for the string:");
            string endingChar = (Console.ReadLine() ?? "*").ToUpper();

            foreach(var city in Cities.Where(x=>(x.ToUpper().StartsWith(startingChar) && x.ToUpper().EndsWith(endingChar))))
            {
                Console.WriteLine($"The city starting with {startingChar} and ending with {endingChar} is: {city.ToUpper()}");
            }
        }
    }
    public class Exercise11
    {
        private static int[] Members = {5, 7, 13, 24, 6, 9, 8, 7, 11, 101};
        public static void Solve()
        {
            Console.Write($"Please enter an integer in range [0, {Members.Length+1}):");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The top {n} records from the list are:");
            foreach(var member in Members.OrderByDescending(x=>x).Take(n))
            {
                Console.WriteLine(member);
            }
        }
    }
    public class Exercise13
    {
        public static void Solve()
        {
            Console.Write("Input number of strings to store in the array: ");
            int numberElements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input {numberElements} strings for the array:");

            string[] stringArray = new string[numberElements];
            for (int i=0;i<numberElements;i++)
            {
                Console.Write($"Element[{i}]: ");
                stringArray[i] = Console.ReadLine();
            }
            string newString = String.Join(", ", stringArray);
            Console.WriteLine($"The new string is {newString}");
        }
    }
    public class Exercise16
    {
        public static void Solve()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            
            var fileInfos = Directory.EnumerateFiles(currentDirectory).Select(file=>new FileInfo(file));

            foreach(var obj in fileInfos)
            {
                Console.WriteLine($"{obj.Name}: {obj.Length}");
            }

            Console.WriteLine($"The average size of the files in this directory is {fileInfos.Select(x=>x.Length).Average()}.");
        }
    }
    
    public class Exercise23
    {   
        static char[] set1 = {'X', 'Y', 'Z'};
        static int[] set2 = {1, 2, 3, 4};
        static char[] set3 = {'$', '#', '@'};
        public static void Solve()
        {
            var cartesianProduct = set1.SelectMany(
                x=> set2.SelectMany(
                y=> set3.Select(
                z=> new{letterList=x, numberList=y, signList=z})));
            
            foreach(var prod in cartesianProduct)
            {
                Console.WriteLine(prod);
            }
        }
    }
}
