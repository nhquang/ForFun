//https://leetcode.com/problems/maximum-number-of-words-found-in-sentences/

public class Solution {
    public int MostWordsFound(string[] sentences) {
        int rs = int.MinValue;
        foreach(var item in sentences){
            var temp = item.Split(' ');
            rs = Math.Max(rs, temp.Length);
        }
        return rs;
    }
}