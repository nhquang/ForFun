//https://leetcode.com/problems/sort-array-by-parity-ii/
//sliding window
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
// 2 Passes
public class Solution {
    public int[] SortArrayByParityII(int[] A) {
        var ans = new int[A.Length];
        int j = 0;
        for(int i = 0; i < A.Length; i++){
            if(A[i] % 2 == 0){
                ans[j] = A[i];
                j += 2;
            }
        }
        j = 1;
        for(int i = 0; i < A.Length; i++){
            if(A[i] % 2 != 0){
                ans[j] = A[i];
                j += 2;
            }
        }
        return ans;
    }
}