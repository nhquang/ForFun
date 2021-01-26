//https://leetcode.com/problems/sort-array-by-parity-ii/

public class Solution {
    public int[] SortArrayByParityII(int[] A) {
        for(int i = 0; i < A.Length; i++){
            if((i % 2) == 0 && (A[i] % 2) != 0){
                for(int j = i + 1; j < A.Length; j++){
                    if((j % 2) != 0 && (A[j] % 2) == 0){
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }
            else if((i % 2) != 0 && (A[i] % 2) == 0){
                for(int j = i + 1; j < A.Length; j++){
                    if((j % 2) == 0 && (A[j] % 2) != 0){
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }
        }
        return A;
    }
}