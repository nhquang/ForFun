//https://leetcode.com/problems/squares-of-a-sorted-array/



public class Solution {
    public int[] SortedSquares(int[] A) {
        var rslt = new List<int>();
        for(int i = 0; i < A.Length; i++){
            rslt.Add(A[i] * A[i]);
        }
        rslt.Sort();
        
        return rslt.ToArray();
    }
}