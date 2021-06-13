//https://leetcode.com/problems/redistribute-characters-to-make-all-strings-equal/

public class Solution {
    public bool MakeEqual(string[] words) {
        var dict = new Dictionary<char, int>();
        
        foreach(var item in words){
            for(int i = 0; i < item.Length; i++){
                if(dict.ContainsKey(item[i])) dict[item[i]]++;
                else dict.Add(item[i], 1);
            }
        }
        
        foreach(var item in dict){
            if(item.Value % words.Length != 0) return false;
        }
        return true;
    }
}