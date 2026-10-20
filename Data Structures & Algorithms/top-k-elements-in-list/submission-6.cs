public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map = new();

        foreach(var num in nums){
            if(!map.ContainsKey(num)) map[num] = 0;
            map[num]++;
        }

        Dictionary<int,List<int>> buckets = new(); // freq, list(nums of that freq)

        foreach(var pair in map){
            if(!buckets.ContainsKey(pair.Value)) buckets[pair.Value] = new List<int>();
            buckets[pair.Value].Add(pair.Key);
        }
        List<int> result = new();
        for(int freq = nums.Length; freq >= 0; freq--){
            if(!buckets.ContainsKey(freq)) continue;

            foreach(var el in buckets[freq]){
                result.Add(el);
                if(result.Count == k) return result.ToArray();
            }
        }
        return result.ToArray();
    }
}
