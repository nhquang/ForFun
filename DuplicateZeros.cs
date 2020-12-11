//https://leetcode.com/problems/duplicate-zeros/


public class Solution {
    public void DuplicateZeros(int[] arr) {
        int prev = -1;
        for(int i = 0; i < arr.Length; i++){
            if(arr[i] == 0){
                for(int j = i+1; j < arr.Length; j++){
                    if(j == i+1){
                        prev = arr[j];
                        arr[j] = 0;
                    }
                    else{
                        int temp = arr[j];
                        arr[j] = prev;
                        prev = temp;
                    }
                }
                i++;
            }
        }
    }
}