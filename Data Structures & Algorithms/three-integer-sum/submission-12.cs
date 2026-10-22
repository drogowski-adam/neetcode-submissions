public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> res = new();

        for(int i = 0;i < nums.Length - 2; i++){

            int right = nums.Length - 1;
            int left = i + 1;

            while(left < right){
                if(i > 0 && nums[i-1] == nums[i]){
                    break;
                }

                int sum = nums[left] + nums[right] + nums[i];

                if(sum == 0){

                    List<int> r = new(){nums[left],nums[i],nums[right]};
                    res.Add(r);
                    left++;
                    right--;
                    while(left < right && nums[left] == nums[left-1]) left++;
                    while(left < right && nums[right] == nums[right+1]) right--;
                }
                else if(sum < 0){
                    left++;
                }else{
                    right--;
                }
            }
        }
        return res;
    }
}
