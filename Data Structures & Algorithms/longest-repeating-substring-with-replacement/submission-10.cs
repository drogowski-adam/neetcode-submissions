public class Solution {
    public int CharacterReplacement(string s, int k) {
        int l = 0;
        int maxLen = 0;

        Dictionary<char,int> counts = new();

        for(int r = 0; r < s.Length; r++){

            if(!counts.ContainsKey(s[r])) counts[s[r]] = 0;
            counts[s[r]]++;

            while(r-l+1 - counts.Values.Max() > k){
                counts[s[l]]--;
                l++;
            }
            maxLen = Math.Max(maxLen,r-l+1);
        }
        return maxLen;
    }
}
