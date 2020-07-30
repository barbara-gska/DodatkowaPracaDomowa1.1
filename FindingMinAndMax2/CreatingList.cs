using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMinAndMax2
{
    public static class CreatingList
    {
        public static List<int> CreateList(string phrase)
        {
            var numbers = new List<int>();

            foreach (var number in phrase.Split(' '))
            {
                numbers.Add(int.Parse(number));
            }

            return numbers;
        }
    }
}
