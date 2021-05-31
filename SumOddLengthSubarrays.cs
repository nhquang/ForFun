//https://leetcode.com/problems/sum-of-all-odd-length-subarrays/


public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int rs = 0;
        for(int i = 1; i <= arr.Length; i+=2){
            for(int j = 0; j + i - 1 < arr.Length; j++){
                int temp = 0; int idx = j;
                while(temp < i){
                    rs += arr[idx];
                    temp++; idx++;
                } 
            }
        }
        return rs;
    }
}