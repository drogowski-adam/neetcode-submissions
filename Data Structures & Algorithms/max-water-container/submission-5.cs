public class Solution {
    public int MaxArea(int[] heights) {
        
        int l = 0;
        int r = heights.Length - 1;
        int maxArea = 0;

        while(l< r){
            int area = Math.Min(heights[r],heights[l])*(r-l);
            maxArea = Math.Max(maxArea, area);

            if (heights[r] < heights[l]){
                r--;
            }
            else{
                l++;
            }
        }
        return maxArea;
    }
}
