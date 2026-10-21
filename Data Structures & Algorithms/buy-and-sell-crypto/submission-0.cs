public class Solution {
    public int MaxProfit(int[] prices) {
        int maxP = 0;
        int left = 0;
        int right = 1;

        while(right < prices.Length){
            int s = prices[right] - prices[left];
            maxP = Math.Max(maxP,s);

            if(s < 0){
                left = right;
            }
            right++;
        }
        return maxP;
    }
}
