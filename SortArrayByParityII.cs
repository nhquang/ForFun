//https://leetcode.com/problems/sort-array-by-parity-ii/
//sliding window
public class Solution {
    public int[] SortArrayByParityII_In_Place(int[] A) {
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
	// 1 Pass
	public int[] SortArrayByParityIIOnePass(int[] nums) {
        var rslt = new int[nums.Length];
        int e = 0, o = 1;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] % 2 == 0) { rslt[e] = nums[i]; e += 2; }
            else { rslt[o] = nums[i]; o += 2; }
        }
        return rslt;
    }
	// 2 Passes
	public int[] SortArrayByParityIITwoPasses(int[] A) {
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