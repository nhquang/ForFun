//https://leetcode.com/problems/reformat-the-string/

public class Solution {
    public string Reformat(string s) {
        var letters = new List<char>();
        var digits = new List<char>();
        var rslt = "";
        foreach(var item in s){
            if(Char.IsDigit(item)) digits.Add(item);
            else letters.Add(item);
        }
        if(Math.Abs(digits.Count - letters.Count) > 1) return "";
        if(letters.Count >= digits.Count) rslt += letters[0];
        else rslt += digits[0];
        bool digitFirst = false; int d = 0, l = 0;
        for(int i = 0; i < s.Length; i++){
            if(i == 0 && Char.IsDigit(rslt[0])) { digitFirst = true; d = 1; }
            else if (i == 0) l = 1;
            else{
                if(digitFirst && i % 2 == 0) { rslt += digits[d]; d++; }
                else if (digitFirst) { rslt += letters[l]; l++; }
                else if (!digitFirst && i % 2 == 0) { rslt += letters[l]; l++; }
                else if (!digitFirst)  { rslt += digits[d]; d++; }
            }
        }
        return rslt;
    }
}