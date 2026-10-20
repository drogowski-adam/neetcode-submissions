public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new();

        for(int i = 0; i < nums.Length; i++){
            int c = target - nums[i];

            if(map.ContainsKey(c)){
                return new int[] {map[c],i};
            }
            map.Add(nums[i],i);
        }
        return new int[] {-1,-1};
    }
}
