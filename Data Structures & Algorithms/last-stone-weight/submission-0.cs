public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
        foreach (int stone in stones) 
        {
            minHeap.Enqueue(stone, -1 * stone);
        }

        while (minHeap.Count > 1) 
        {
            int firstStone = minHeap.Dequeue();
            int secondStone = minHeap.Dequeue();
            if (firstStone > secondStone) 
            {
                int stoneShard = firstStone - secondStone;
                minHeap.Enqueue(stoneShard, -1 * stoneShard);
            }
        }

        return minHeap.Count == 1 ? minHeap.Dequeue() : 0;
    }
}
