//https://leetcode.com/problems/n-repeated-element-in-size-2n-array/


public class Solution {
    public int RepeatedNTimes(int[] A) {
        var set = new HashSet<int>();
        for(int i = 0; i < A.Length; i++){
            if(set.Contains(A[i])) return A[i];
            else set.Add(A[i]);
        }
        return -1;
    }
}