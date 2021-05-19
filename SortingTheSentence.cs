//https://leetcode.com/problems/sorting-the-sentence/

public class Solution {
    public string SortSentence(string s) {
        var words = s.Split(' ');
        string[] rs = new string[words.Length];
        for(int i = 0; i < words.Length; i++){
            int temp = words[i][words[i].Length - 1] - '0';
            rs[--temp] = words[i].Remove(words[i].Length - 1);
        }
        return String.Join(" ", rs);
    }
}