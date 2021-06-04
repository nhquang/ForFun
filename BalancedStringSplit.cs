//https://leetcode.com/problems/split-a-string-in-balanced-strings/


public class Solution {
    public int BalancedStringSplit(string s) {
        int sum = 0; int rs = 0;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == 'L') sum--;
            else sum++;
            if(sum == 0) rs++;
        }
        return rs;
    }
}