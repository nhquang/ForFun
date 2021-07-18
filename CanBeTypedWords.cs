//https://leetcode.com/problems/maximum-number-of-words-you-can-type/


public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        int rs = 0;
        var set = new HashSet<char>();
        foreach(var item in brokenLetters) set.Add(item);
        var words = text.Split(' ');
        foreach(var word in words){
            foreach(var c in word){
                if(set.Contains(c)){
                    rs++; break;
                }
            }
        }
        return words.Length - rs;
    }
}