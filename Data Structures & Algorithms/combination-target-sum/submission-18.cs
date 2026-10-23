public class Solution {

    List<List<int>> res = new List<List<int>>();

    public void dfs(int i, List<int> curr, int total, int[] nums, int target){
            if(total == target){
                res.Add(curr.ToList());
                return;
            }

            if(i >= nums.Length || total > target) return;

            curr.Add(nums[i]);
            dfs(i, curr, total + nums[i],nums,target);
            curr.Remove(curr.Last());
            dfs(i+1,curr,total,nums,target);
        }

    public List<List<int>> CombinationSum(int[] nums, int target) {

        dfs(0, new List<int>(), 0,nums,target);
        return res;
    }
}
