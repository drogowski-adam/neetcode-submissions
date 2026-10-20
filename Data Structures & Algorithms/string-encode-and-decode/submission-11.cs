public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder res = new();
        foreach(var word in strs){
            res.Append(word.Length);
            res.Append('#');
            res.Append(word);
        }
        return res.ToString();
    }

    public List<string> Decode(string s) {
        List<string> res = new();

        int i = 0;
        int j = i;
        while(i < s.Length){
            j = i;
            while(s[j] != '#') j++;

            int len = int.Parse(s.Substring(i,j-i));

            res.Add(s.Substring(j+1, len));

            i = j + 1 + len;
        }
        return res;
   }
}
