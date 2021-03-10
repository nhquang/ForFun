//https://leetcode.com/problems/minimum-operations-to-make-array-equal/

public class Solution {
    public int MinOperations(int n) {
        var nums = new int[n];
        int sum = 0;
        for(int i = 0; i < nums.Length;i++){
            nums[i] = (2 * i) + 1;
            sum += nums[i];
        }
        int tar = sum / n, result = 0;
        if(n % 2 == 0) for(int i = 0; i < n / 2; i++) result += tar - nums[i];
        else for(int i = 0; i <= n / 2; i++) result += tar - nums[i];
        return result;
    }
}