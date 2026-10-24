public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> maxHeap = new();

        foreach(var stone in stones){
            maxHeap.Enqueue(stone,-1*stone);
        }

        while(maxHeap.Count > 1){
            int s1 = maxHeap.Dequeue();
            int s2 = maxHeap.Dequeue();

            maxHeap.Enqueue(s1-s2,-1*(s1-s2));
        }
        return maxHeap.Dequeue();

    }
}
