using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMinAndMax2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg liczb rozdzielając je spacją");

            var numbers = CreatingList.CreateList(Console.ReadLine());


            var min = numbers[0];
            var max = numbers[0];

            foreach (var number in numbers)
            {
                if (number < min)
                    min = number;

                if (number > max)
                    max = number;
            }


            Console.WriteLine($"{max.ToString()} {min.ToString()}");

            Console.ReadLine();
        }
    }
}
