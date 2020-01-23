using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Program
    {
        public class Problem1
        {
            public static IEnumerable<int> myFilter(IEnumerable<int> input)
            {
           
                var nums = from x in input
                           where x <= 50 || (x > 50 && x % 5 != 0)
                           select x;

                List<int> cubes = new List<int>();

                foreach (int i in nums)
                {
                    cubes.Add( Convert.ToInt32(Math.Pow(Convert.ToDouble(i), 3)));
                }

                var ans = from x in cubes
                          where x % 2 == 1
                          select x;

                return ans;
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random(5); // Important to seed with 5 for repeatability.
            var listForProblem =
              Enumerable.Range(1, 100).Select(i => rnd.Next() % 101);

            var answer = Problem1.myFilter(listForProblem);
            foreach (int i in answer)
            {
               Console.WriteLine(i);
            }
        }
    }
}
