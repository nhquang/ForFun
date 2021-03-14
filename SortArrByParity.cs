//https://leetcode.com/problems/sort-array-by-parity/

public class Solution {
    public int[] SortArrayByParity(int[] A) {
        int i = 0, j = A.Length - 1;
        while(j > i){
            if(A[i] % 2 == 1 && A[j] % 2 == 0){
                int temp = A[i];
                A[i] = A[j];
                A[j] = temp;
            } 
            else if(A[i] % 2 == 1) i--;
            else j++;
            i++;j--;
        }
        return A;
    }
}