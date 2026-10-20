public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        for(int i = 0; i < numbers.Length; i++){
            int c = target - numbers[i];

            int a = i+ 1;
            int b = numbers.Length - 1;

            while(a <= b){
                int s = (a+b)/2;
                if(numbers[s] == c){
                    return new int[]{i+1,s+1};
                }
                if(numbers[s] < c){
                    a = s + 1;
                    continue;
                }
                if(numbers[s] > c){
                    b = s - 1;
                    continue;
                }
            }
        }
        return new int[]{-1,-1};
    }
}
