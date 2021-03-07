//https://leetcode.com/problems/crawler-log-folder/

public class Solution {
    public int MinOperations(string[] logs) {
        int count = 0;
        for(int i = 0; i < logs.Length; i++){
            if(Char.IsLetter(logs[i][0]) || Char.IsDigit(logs[i][0])) count++;
            else if(logs[i].StartsWith("..")) count = count > 0 ? --count : 0;
        }
        return count;
    }
}