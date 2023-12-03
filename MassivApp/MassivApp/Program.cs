using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MassivApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Ваша строка с числами 123 и 456. Также может быть 789.";
            Regex regex = new Regex(@"\d+");
            MatchCollection matches = regex.Matches(inputString);
            int[] numbers = new int[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                numbers[i] = Int32.Parse(matches[i].Value);
            }
            Console.WriteLine("Массив чисел: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}   
