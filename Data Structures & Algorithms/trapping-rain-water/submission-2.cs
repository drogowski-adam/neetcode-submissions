public class Solution {
    public int Trap(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int res = 0;
        int maxL = height[left];
        int maxR = height[right];

        if(height.Length == 0) return -1;

        while(left < right){
            
            if(maxL < maxR){
                left++;
                maxL = Math.Max(maxL,height[left]);
                res += maxL - height[left];
            }
            else{
                right--;
                maxR = Math.Max(maxR,height[right]);
                res += maxR - height[right];
            }
        }
        return res;
    }
}
