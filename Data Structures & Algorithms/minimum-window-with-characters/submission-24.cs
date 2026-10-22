public class Solution {
    public string MinWindow(string s, string t) {
        
        Dictionary<char,int> countsT = new();
        foreach(var c in t){
            if(!countsT.ContainsKey(c)){
                countsT[c] = 0;
            }
            countsT[c]++;
        }
        int l = 0;
        int minLen = int.MaxValue;
        int needs = countsT.Count;
        int has = 0;
        Dictionary<char,int> counts = new();

        int[] res = {-1,-1};

        for(int r = 0; r < s.Length; r++){
            
            if(!counts.ContainsKey(s[r])) counts[s[r]] = 0;
            counts[s[r]]++;

            if(countsT.ContainsKey(s[r]) && counts[s[r]] == countsT[s[r]]){
                has++;
            }

            while(has == needs){
                if(r-l+1 < minLen){
                    res[0] = l;
                    res[1] = r;
                    minLen = r-l+1;
                }
                counts[s[l]]--;
                if(countsT.ContainsKey(s[l]) && counts[s[l]] < countsT[s[l]]){
                    has--;
                }
                
                l++;
            }
        }
        StringBuilder st = new();

        if(res[0] < 0 || res[1] < 0){
            return "";
        }

        else{
            for(int i = res[0]; i < res[1]+1; i++){
                st.Append(s[i]);
            }
            return st.ToString();
        }
    }
}
