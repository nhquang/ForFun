//https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/


public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var dict = new Dictionary<int, int>();
        for(int i = 0; i < numbers.Length; i++){
            int temp = target - numbers[i];
            if(dict.ContainsKey(temp)) return new int[2]{dict[temp] + 1, i+1 };
            if(!dict.ContainsKey(numbers[i])) dict.Add(numbers[i], i);
        }
        return new int[0]{};
    }
}