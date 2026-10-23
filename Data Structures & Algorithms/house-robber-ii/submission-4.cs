public class Solution {
    
    public int RobH(int[] nums) {
        int rob1 = 0;
        int rob2 = 0;

        foreach(var n in nums){
            var tmp = Math.Max(rob1+n,rob2);
            rob1 = rob2;
            rob2 = tmp;
        }
        return rob2;
    }
    
    public int Rob(int[] nums) {
        if(nums.Length == 1) return nums[0];
        return Math.Max(RobH(nums[1..]),RobH(nums[..^1]));
    }
}
