//https://leetcode.com/problems/check-if-the-sentence-is-pangram/

public class Solution {
    public bool CheckIfPangram(string sentence) {
        var dict = new Dictionary<char,int>();
        for(int i = 0; i < sentence.Length;i++){
            if(dict.ContainsKey(sentence[i])) dict[sentence[i]]++;
            else dict.Add(sentence[i], 1);
        }
        return dict.Count == 26;
    }
}