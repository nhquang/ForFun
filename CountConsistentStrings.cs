//https://leetcode.com/problems/count-the-number-of-consistent-strings/


public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        var set = new HashSet<char>();
        foreach(var item in allowed){
            set.Add(item);
        }
        int rs = 0;
        foreach(var item in words){
            int temp = 0;
            foreach(var c in item){
                if(set.Contains(c)) temp++;
            }
            if(temp == item.Length) rs++;
        }
        return rs;
    }
}