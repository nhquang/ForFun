//https://leetcode.com/problems/find-words-that-can-be-formed-by-characters/

public class Solution {
    public int CountCharacters(string[] words, string chars) {
        var dict = new Dictionary<char,int>();
        foreach(var item in chars){
            if(dict.ContainsKey(item)) dict[item]++;
            else dict.Add(item, 1);
        }
        int rs = 0;
        foreach(var item in words){
            var temp = new Dictionary<char, int>();
            foreach(var ch in item){
                if(temp.ContainsKey(ch)) temp[ch]++;
                else temp.Add(ch, 1);
            }
            var count = 0;
            foreach(var ch in temp){
                if(dict.ContainsKey(ch.Key) && dict[ch.Key] >= ch.Value) count++;
            }
            if(count == temp.Count) rs += item.Length;
        }
        return rs;
    }
}