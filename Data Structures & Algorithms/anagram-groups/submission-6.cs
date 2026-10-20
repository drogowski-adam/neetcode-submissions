public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new();
        List<List<string>> result = new();
        foreach(var word in strs){
            int[] counts = new int [26];

            for(int i = 0; i < word.Length; i++){
                counts[word[i] - 'a']++;
            }

            string c = string.Join(',',counts);

            if(!map.ContainsKey(c)){
                map.Add(c,new List<string>{});
            }
            map[c].Add(word);
        }

        foreach(var word in map.Values){
            result.Add(word);
        }
        return result;
    }
}
