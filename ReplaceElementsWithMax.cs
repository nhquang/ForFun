//https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/

public class Solution {
    public int[] ReplaceElements(int[] arr) {
        for(int i = 0; i < arr.Length; i++){
            int max = -1;
            for(int j = i + 1; j < arr.Length; j++) max = Math.Max(max, arr[j]);
            arr[i] = max;
        }
        return arr;
    }
}