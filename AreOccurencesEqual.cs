//https://leetcode.com/problems/check-if-all-characters-have-equal-number-of-occurrences/

public class Solution {
    public bool AreOccurrencesEqual(string s) {
        var dict = new Dictionary<char,int>();
        foreach(var c in s){
            if(dict.ContainsKey(c)) dict[c]++;
            else dict.Add(c, 1);
        }
        bool first = true;
        var temp = 0;
        foreach(var item in dict){
            if(first){
                temp = item.Value;
                first = false;
            }
            if(item.Value != temp) return false;
        }
        return true;
    }
}