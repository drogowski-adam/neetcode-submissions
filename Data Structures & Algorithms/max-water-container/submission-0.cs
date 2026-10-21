public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int res = 0;

        while(left < right){
            int h = Math.Min(heights[left],heights[right]);
            int area = (right - left) * h;
            res = Math.Max(res,area);
            if(h == heights[left]){
                left++;
            }
            else if(h == heights[right]){
                right--;
            }
        }
        return res;
    }
}
