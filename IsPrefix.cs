//https://leetcode.com/problems/check-if-a-word-occurs-as-a-prefix-of-any-word-in-a-sentence/

public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        var parts = sentence.Split(' ');
        for(int i = 0; i < parts.Length; i++)
            if(parts[i].StartsWith(searchWord)) return i + 1;
        return -1;
    }
}