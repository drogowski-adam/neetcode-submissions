public class Solution {
    public int MissingNumber(int[] nums) {
        int xorr = nums.Length;

        for(int i = 0; i < nums.Length; i++){
            xorr = xorr ^ i;
            xorr = xorr ^ nums[i];
        }
        return xorr;
    }
}
