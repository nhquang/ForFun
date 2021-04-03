//https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence/

public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        int tar = arr[1] - arr[0];
        for(int i = 2; i < arr.Length; i++){
            if(arr[i] - arr[i-1] != tar) return false;
        }
        return true;
    }
}