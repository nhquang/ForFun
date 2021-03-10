//https://leetcode.com/problems/mean-of-array-after-removing-some-elements/

public class Solution {
    public double TrimMean(int[] arr) {
        Array.Sort(arr);
        int rm = (5 * arr.Length) / 100;
        double rslt = 0;
        for(int i = rm; i < arr.Length - rm; i++) rslt += arr[i];
        return rslt / (arr.Length - (rm*2));
    }
}