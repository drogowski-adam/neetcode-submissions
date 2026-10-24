public class Solution {
    public int HammingWeight(uint n) {
        if(n == 0) return 0;
        int cnt = 0;
        while(n != 0){
            if(n%2 == 1) cnt++;
            n >>= 1;
        }
        return cnt;
    }
}
