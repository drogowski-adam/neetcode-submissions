public class Solution {
    public string LongestPalindrome(string s) {
        
        int l = 0;
        int r = 0;
        string res = "";
        int resLen = 0;
        int r2;
        //if(s.Length == 1) return s;

        for(int i = 0; i < s.Length; i++){
            l = i;
            r = i;

            while(l >= 0 && r < s.Length && s[l] == s[r]){
                if(r-l+1 > resLen){
                    resLen = r-l+1;
                    r2 = r+1;
                    res = s[l..r2];
                }
                l--;
                r++;
            }

            l = i;
            r = i+1;

            while(l >= 0 && r < s.Length && s[l] == s[r]){
                if(r-l+1 > resLen){
                    resLen = r-l+1;
                    r2 = r+1;
                    res = s[l..r2];
                }
                l--;
                r++;
            }
        
        }
        return res;
    }
}
