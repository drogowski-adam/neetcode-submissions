public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new(nums);
        int longest = 0;
        int len = 0;
        foreach(var num in nums){

            // liczymy tylko od poczatku
            if(!set.Contains(num-1)){
                len = 1;
                int cur = num;

                while(set.Contains(cur + 1)){
                    len++;
                    cur++;
                }
            }
        
            longest = Math.Max(longest,len);
        }
        return longest;
    }
}
