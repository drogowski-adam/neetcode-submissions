public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map = new();

        foreach(int num in nums){
            if(!map.ContainsKey(num)) map[num] = 0;
            map[num]++;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach(var pair in map){
            int frequency = pair.Value;

            if(buckets[frequency] == null) buckets[frequency] = new List<int>();

            buckets[frequency].Add(pair.Key);
        }

        int[] result = new int[k];
        int index = 0;

        for(int i = buckets.Length -1; i >= 0; i--){
            if(buckets[i] == null) continue;

            foreach(int num in buckets[i]){
                result[index++] = num;

                if(index == k){
                    return result;
                }
            }
        }
        return result;

    }
}
