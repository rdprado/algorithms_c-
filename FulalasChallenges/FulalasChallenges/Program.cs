using System.Collections.Generic;
using System.Diagnostics;

namespace FulalasChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listValuestricky2 = { 10, 400, 3, 90, -4, 6, 500, 3, -1 }; // 7 

            var strategy = new Problem1WorkingTry2();

            var linkedList = new LinkedList<int>(listValuestricky2);
            var count = strategy.Count(linkedList);
            if (count == 7)
                Debug.WriteLine("Test tricky 2 pass");
        }
    }

    public interface Problem1Strategy
    {
        int Count(LinkedList<int> linkedList);
    }

    public class Problem1WorkingTry2 : Problem1Strategy
    {
        public int Count(LinkedList<int> linkedList)
        {
            var listNode = linkedList.First;
            int startingIndex = -1;
            int currentListIndex = 0;

            for (var node = linkedList.First; node.Value != -1; node = node.Next, currentListIndex++)
                if (startingIndex == -1 && listNode.Value == currentListIndex + 1)
                    startingIndex = currentListIndex;

            return currentListIndex - startingIndex + 1;
        }
    }

    public class Problem1WorkingTry1 : Problem1Strategy
    {
        public int Count(LinkedList<int> linkedList)
        {
            var listNode = linkedList.First;
            int startingIndex = -1;
            int currentListIndex = 0;

            while(listNode.Value != -1)
            {
                if (startingIndex == -1 && listNode.Value == currentListIndex + 1)
                    startingIndex = currentListIndex;

                currentListIndex++;
                listNode = listNode.Next;
            }

            return currentListIndex - startingIndex + 1;
        }
    }
}