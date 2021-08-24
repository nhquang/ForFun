//https://leetcode.com/problems/minimum-time-to-type-word-using-special-typewriter/

public class Solution {
    public int MinTimeToType(string word) {
        int rs = 0;
        char pointer = 'a';
        for(int i = 0; i < word.Length; i++){
            rs += Math.Min(Math.Abs(word[i] - pointer) + 1, 26 - Math.Abs(word[i] - pointer) + 1);
            pointer = word[i];
        }
        return rs;
    }
}