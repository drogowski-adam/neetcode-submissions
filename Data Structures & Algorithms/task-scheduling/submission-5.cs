public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] count = new int[26];
        foreach(var task in tasks){
            count[task - 'A']++;
        }

        PriorityQueue<int,int> maxHeap = new();
        for(int i = 0; i < 26; i++){
            if(count[i] > 0) maxHeap.Enqueue(count[i],-count[i]);
        }
    

    int time = 0;
    Queue<int[]> q = new();
    while(q.Count > 0 || maxHeap.Count > 0){
        if(q.Count > 0 && time >= q.Peek()[1]){
            int[] temp = q.Dequeue();
            maxHeap.Enqueue(temp[0],-temp[0]);
        }
        if(maxHeap.Count > 0){
            int cnt = maxHeap.Dequeue() -1;
            if(cnt > 0){
                q.Enqueue(new int[]{cnt, time + n + 1});
            }
        }
        time++;
    }
    return time;
    }
}
