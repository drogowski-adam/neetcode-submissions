public class Solution {
    public int[] CountBits(int n) {
        
        int[] count = new int[n+1];

        for(int i = 0; i <=n; i++){
            int cnt = 0;
            int id = i;
            while(id != 0){
                if(id%2 == 1) cnt++;
                id >>= 1;
            }
            count[i] = cnt;
        }
        return count;
    }
}
