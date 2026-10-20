public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] counts = new int[26];
        if(s.Length != t.Length) return false;
        for(int i = 0; i < s.Length; i++){
            counts[s[i] - 'a']++;
            counts[t[i] - 'a']--;
        }
        foreach(var n in counts){
            if(n != 0) return false;
        }
        return true;
    }
}
