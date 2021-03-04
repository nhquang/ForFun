
//https://leetcode.com/problems/monotonic-array/

public class Solution {
    public bool IsMonotonic(int[] A) {
        bool increasing = true, decreasing = true;
        for(int i = 0; i < A.Length - 1; i++){
            if(A[i] > A[i+1]) increasing = false;
            if(A[i] < A[i+1]) decreasing = false;
        }
        return increasing || decreasing;
    }
}