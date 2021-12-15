//https://leetcode.com/problems/k-radius-subarray-averages/

public class Solution {
    public int[] GetAverages(int[] nums, int k) {
        int[] rs = new int[nums.Length];
        double temp = nums.Length * 0.5;
        if(k >= temp)
            for(int i = 0; i < rs.Length; i++) rs[i] = -1;
        else {
            int head = 0, tail = k + k;
            long sum = 0;
            for(int i = head; i <= tail; i++) sum += nums[i];
            for(int i = 0; i < nums.Length; i++){
                if(i < k || i >= nums.Length - k) rs[i] = -1;
                else if (i == k){
                    rs[i] = (int)(sum / (k * 2 + 1));
                    head++; tail++;
                }
                else{
                    sum = sum - nums[head - 1] + nums[tail];
                    rs[i] = (int)(sum / (k * 2 + 1));
                    head++; tail++;
                }
            }
        }
        return rs;
    }
}