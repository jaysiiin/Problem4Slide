using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4Slide
{
    class Program
    {
        public static void Main()
        {

            int[] example = { 20, 10, 5, 2 };
            Console.WriteLine("\n" + "The sum of the example array is {0}", Sum(example));

        }
        static int Sum(int[] num)
        {
            int answer = 0;
            foreach (int x in num)
            {
                answer += x;
            }
            return answer;
            
            

        }

    }
}
