//https://leetcode.com/problems/remove-palindromic-subsequences/

public class Solution {
    public int RemovePalindromeSub(string s) {
        string s1 = s;
        if(s.Length == 0) return 0;
        if(IsPalindromic(s)) return 1;
        return 2;
        
    }
    bool IsPalindromic(string s){
        int i = 0, j = s.Length - 1;
        while(j > i){
            if(s[i] != s[j]) return false;
            i++;j--;
        }
        return true;
    }
}