public class Solution {
    public int Search(int[] nums, int target) {
        
        int l = 0;
        int r = nums.Length - 1;
        int m = 0;

        while(l <= r){
            
            m = (l+r)/2;
            if(target == nums[m]) return m;

            if(nums[l] <= nums[m]){
                if(target < nums[m] && target >= nums[l]){
                    r = m - 1;
                }
                else{
                    l = m + 1;
                }
            }else{
                if(target > nums[m] && target <= nums[r]){
                    l = m + 1;
                }
                else{
                    r = m - 1;
                }
            }
        }
        return -1;
    }
}
