public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0;
        HashSet<char> set = new();
        int res = 0;
        for(int r = 0; r < s.Length; r ++){
            while(!set.Add(s[r])){
                set.Remove(s[l]); 
                l++;
            }
            set.Add(s[r]);
            res = Math.Max(res, r-l+1);
        }
        return res;
    }
}
