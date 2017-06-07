using System.Collections.Generic;
using System.Diagnostics;

namespace FulalasChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // just an example, run tests!

            int[] listValuestricky2 = { 10, 400, 3, 90, -4, 6, 500, 3, -1 }; // 7 

            var strategy = new Problem1WorkingTry2();

            var linkedList = new LinkedList<int>(listValuestricky2);
            var count = strategy.Count(linkedList);
            if (count == 7)
                Debug.WriteLine("Test tricky 2 pass");
        }
    }
}