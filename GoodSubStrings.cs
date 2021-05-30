//https://leetcode.com/problems/substrings-of-size-three-with-distinct-characters/

public class Solution {
    public int CountGoodSubstrings(string s) {
        int sum = 0;
        for(int i = 0; i < s.Length; i++){
            if(i + 2 < s.Length){
                if(s[i] != s[i+1] && s[i] != s[i+2] && s[i+1] != s[i+2]) sum++;
            }
        }
        return sum;
    }
}