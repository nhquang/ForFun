//https://leetcode.com/problems/check-if-string-is-a-prefix-of-array/

public class Solution {
    public bool IsPrefixString(string s, string[] words) {
        int idx = 0;
        for(int i = 0; i < words.Length && idx < s.Length; i++){
            for(int j = 0; j < words[i].Length; j++){
                if(idx >= s.Length) return false;
                if(words[i][j] != s[idx++]) return false;
            }
        }
        return idx == s.Length ? true : false;
    }
}