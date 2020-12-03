//https://leetcode.com/problems/length-of-last-word/


public class Solution {
    public int LengthOfLastWord(string s) {
        int count = 0;
        if(String.IsNullOrEmpty(s) || String.IsNullOrWhiteSpace(s)) return 0;
        for(int i = s.Length - 1; i >= 0; i--){
            if(s[i] == ' ' && count == 0) continue;
            if(s[i] == ' ' && count != 0) break;
            count++;
        }
        return count;
    }
}