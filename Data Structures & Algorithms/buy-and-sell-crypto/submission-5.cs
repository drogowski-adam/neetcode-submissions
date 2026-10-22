public class Solution {
    public int MaxProfit(int[] prices) {
        
        int l = 0;
        int r = 1;

        int maxP = 0;

        while(r < prices.Length){
            int profit = prices[r] - prices[l];
            maxP = Math.Max(maxP,profit);

            if(profit < 0){
                l = r;
            }
            r++;
        }
        return maxP;

    }
}
