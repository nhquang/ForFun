//https://leetcode.com/problems/partition-array-into-three-parts-with-equal-sum/

public class Solution {
    public bool CanThreePartsEqualSum(int[] arr) {
        int sum = 0;
        for(int i = 0; i < arr.Length; i++) sum += arr[i];
        if(sum % 3 != 0) return false;
        sum /= 3;
        int temp = 0, parts = 0;
        for(int i = 0; i < arr.Length; i++){
            temp += arr[i];
            if(temp == sum) {
                temp = 0;
                parts++;
            }
        }
        return parts >= 3;
    }
}