//https://leetcode.com/problems/largest-odd-number-in-string/

public class Solution {
    public string LargestOddNumber(string num) {
        int count = 0, i = num.Length - 1;
        while(i >= 0){
            if((num[i] - '0') % 2 != 0) break;
            i--; count++;
        }
        return num.Substring(0, num.Length - count);
    }
}