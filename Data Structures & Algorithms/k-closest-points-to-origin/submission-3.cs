public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int,double> minHeap = new();

        for(int i = 0; i < points.Length; i++){
            double dist = Math.Sqrt(points[i][0]*points[i][0] + points[i][1]*points[i][1]);
            
            minHeap.Enqueue(i,dist);
        }
        List<int[]> result = new();
        for(int i = 0; i < k; i++){
            result.Add(points[minHeap.Dequeue()]);
        }
        return result.ToArray();
    }
}
