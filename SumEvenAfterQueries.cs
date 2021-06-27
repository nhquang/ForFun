//https://leetcode.com/problems/sum-of-even-numbers-after-queries/

public class Solution {
    public int[] SumEvenAfterQueries(int[] nums, int[][] queries) {
        var rs = new int[queries.Length];
        int sum = 0;
        foreach(var item in nums)
            if(item % 2 == 0)
                sum += item;
        for(int i = 0; i < queries.Length; i++){
            if(nums[queries[i][1]] % 2 == 0) sum -= nums[queries[i][1]];
            nums[queries[i][1]] += queries[i][0];
            if(nums[queries[i][1]] % 2 == 0) sum += nums[queries[i][1]];
            rs[i] = sum;
        }
        return rs;
    }
}