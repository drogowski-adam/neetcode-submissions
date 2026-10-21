public class Solution {
    public string MinWindow(string s, string t) {
        if(string.IsNullOrEmpty(t)) return "";

        Dictionary<char,int> countT = new();
        Dictionary<char,int> window = new();

        int have = 0;
        
        int minLen = int.MaxValue;
        int[] res = new int[]{-1,-1};

        foreach(var c in t){
            if(!countT.ContainsKey(c)) countT[c] = 0;
            countT[c]++;
        }
        int need = countT.Count;

        int l = 0;

        for(int r = 0; r < s.Length; r++){
            var c = s[r];
            if(!window.ContainsKey(c)) window[c] = 0;
            window[c]++;

            if(countT.ContainsKey(c) && window[c] == countT[c]){
                have++;
            }    

            while(have == need){

                if(r-l+1 < minLen){
                    res[0] = l;
                    res[1] = r;  
                    minLen = r-l+1;
                }
                window[s[l]]--;
                if(countT.ContainsKey(s[l]) && window[s[l]] < countT[s[l]]){
                    have--;
                }
                l++;
            }
        }

        StringBuilder st = new();

        if(minLen != int.MaxValue){

            for(int i = res[0]; i <= res[1]; i++){
                st.Append(s[i]);
            }
        }
        return st.ToString() ?? "";
    }
}
