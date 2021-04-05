//https://leetcode.com/problems/truncate-sentence/

public class Solution {
    public string TruncateSentence(string s, int k) {
        var parts = s.Split(' ');
        var rslt = "";
        for(int i = 0; i < k; i++) rslt += parts[i] + " ";
        return rslt.TrimEnd(' ');
    }
}