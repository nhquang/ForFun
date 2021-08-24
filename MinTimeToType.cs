//https://leetcode.com/problems/minimum-time-to-type-word-using-special-typewriter/

public class Solution {
    public int MinTimeToType(string word) {
        var dict = new Dictionary<char, int>();
        dict.Add('a', 0);
        char prev = 'a';
        for(int i = 1; i <= 26; i++){
            char temp = (char) (prev + 1);
            dict.Add(temp, i);
            prev = temp;
        }
        int rs = 0; char pointer = 'a';
        for(int i = 0; i < word.Length; i++){
            int counterWise = 0;
            int clockWise = 0;
            if(pointer < word[i]) {
                counterWise = dict[pointer] - dict['a'] + 26 - dict[word[i]] + 1;
                clockWise = dict[word[i]] - dict[pointer] + 1;
            }
            else if (pointer > word[i]){
                counterWise = dict[pointer] - dict[word[i]] + 1;
                clockWise = 26 - dict[pointer] + dict[word[i]] - dict['a'] + 1;
            }
            else{
                counterWise = 1;
                clockWise = 1;
            }
            rs += Math.Min(counterWise, clockWise);
            pointer = word[i];
        }
        return rs;
    }
}