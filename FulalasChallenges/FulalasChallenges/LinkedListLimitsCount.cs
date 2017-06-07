using System.Collections.Generic;

// Contar quantos elementos há numa lista encadeada dado que o índice 0 tem como valor o índice para o próximo elemento,
// e no caso desse valor ser -1 significa que a lista acabou. Ex.: no array [1, 4, -1, 3, 2, 8] o total de elementos é 3..

namespace FulalasChallenges
{
    public interface LimitsCountStrategy
    {
        int Count(LinkedList<int> linkedList);
    }

    public class Problem1WorkingTry3 : LimitsCountStrategy
    {
        public int Count(LinkedList<int> linkedList)
        {
            int currentListIndex = 0;
            bool foundStart = false;

            for (var node = linkedList.First; node.Value != -1; node = node.Next, currentListIndex++)
                if (!foundStart && node.Value == currentListIndex + 1)
                    FoundListStart(out currentListIndex, out foundStart);

            return currentListIndex;
        }

        private void FoundListStart(out int currentListIndex, out bool foundStart)
        {
            foundStart = true;
            currentListIndex = 1;
        }
    }

    public class Problem1WorkingTry2 : LimitsCountStrategy
    {
        public int Count(LinkedList<int> linkedList)
        {
            int startingIndex = -1;
            int currentListIndex = 0;

            for (var node = linkedList.First; node.Value != -1; node = node.Next, currentListIndex++)
                if (startingIndex == -1 && node.Value == currentListIndex + 1)
                    startingIndex = currentListIndex;

            return currentListIndex - startingIndex + 1;
        }
    }

    public class Problem1WorkingTry1 : LimitsCountStrategy
    {
        public int Count(LinkedList<int> linkedList)
        {
            var listNode = linkedList.First;
            int startingIndex = -1;
            int currentListIndex = 0;

            while (listNode.Value != -1)
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
