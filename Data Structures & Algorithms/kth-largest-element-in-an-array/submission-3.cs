public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> maxHeap = new();

        foreach(var num in nums){
            maxHeap.Enqueue(num,-num);
        }
        for(int i = 0; i < k; i++){
            if(i == k-1) return maxHeap.Dequeue();
            maxHeap.Dequeue();
        }
        return -1;
    }
}
