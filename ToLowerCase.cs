//https://leetcode.com/problems/to-lower-case/

public class Solution {
    public string ToLowerCase(string str) {
        var rslt = "";
        for(int i = 0; i < str.Length; i++){
            if(Char.IsLetter(str[i]) && str[i] <= 90) rslt += (char)(str[i] + 32);
            else rslt += str[i];
        }
        return rslt;
    }
}