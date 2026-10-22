public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char,int> countsT = new();
        int l = 0;
        int minLen = int.MaxValue;

        foreach(var c in t){
            if(!countsT.ContainsKey(c)) countsT[c] = 0;
            countsT[c]++;        
            
        }

        int[] res = {-1,-1};
        Dictionary<char,int> window = new();
        int has = 0;
        int needs = countsT.Count;

        for(int r = 0; r < s.Length; r++){
            if(!window.ContainsKey(s[r])){
                window[s[r]] = 0;
            }
            window[s[r]]++;

            if(countsT.ContainsKey(s[r]) && countsT[s[r]] == window[s[r]]){
                has++;
            }

            while(has == needs){
                if(r-l+1 < minLen){
                    res[0] = l;
                    res[1] = r;
                    minLen = r-l+1;
                }

                window[s[l]]--;
                if(countsT.ContainsKey(s[l]) && countsT[s[l]] > window[s[l]]){
                    has--;
                }
                l++;
            }
        }

        StringBuilder st = new();

        if(res[0] < 0) return "";

        for(int i = res[0]; i < res[1] + 1; i++){
            st.Append(s[i]);
        }
        return st.ToString();
    }
}
