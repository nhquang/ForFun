//https://leetcode.com/problems/number-of-different-integers-in-a-string/

public class Solution {
    public int NumDifferentIntegers(string word) {
        var set = new HashSet<int>();
        var temp = 0;
        var prevDigit = false;
        for(int i = 0; i < word.Length; i++){
            if(Char.IsDigit(word[i])){
                temp = temp * 10 + Int32.Parse(word[i].ToString());
                prevDigit = true;
            }
            else{
                if(prevDigit) set.Add(temp);
                prevDigit = false;
                temp = 0;
            }
        }
        if(prevDigit) set.Add(temp);
        return set.Count;
    }
}