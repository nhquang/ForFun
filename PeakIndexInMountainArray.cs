//https://leetcode.com/problems/peak-index-in-a-mountain-array/

public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int max = arr[0], idx = 0;
        for(int i = 1; i < arr.Length; i++){
            if(max < arr[i]){
                max = arr[i];
                idx = i;
            }
        }
        return idx;
    }
}