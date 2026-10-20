public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();

        foreach(var str in strs){
            int[] count = new int[26];

            foreach(var c in str){
                count[c - 'a']++;
            }

            string key = string.Join(',',count);

            if(!map.ContainsKey(key)) map[key] = new List<string>();

            map[key].Add(str);
        }

        List<List<string>> result = new List<List<string>>();

        foreach(var group in map.Values){
            result.Add(group);
        }
        
        return result;
    }
}
