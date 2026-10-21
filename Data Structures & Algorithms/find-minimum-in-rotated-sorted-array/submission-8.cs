public class Solution {
    public int FindMin(int[] nums) {
        
        int l = 0;
        int r = nums.Length - 1;
        int m = -1;
        int min = int.MaxValue;
        if(nums[l] < nums[r]) return nums[l];

        while(l<=r){

            if(nums[l] < nums[r]){
                min = Math.Min(min,nums[l]);
            }

            m = (l+r)/2;
            min = Math.Min(min,nums[m]);

            if (nums[m] >= nums[l]){
                l = m+1;
            }
            else{
                r = m-1;
            }
        }
        return min;
    }
}
