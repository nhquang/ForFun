//https://leetcode.com/problems/sort-characters-by-frequency/

public class Solution {
    public string FrequencySort(string s) {
        var dict = new Dictionary<char, int>();
        foreach(var item in s){
            if(dict.ContainsKey(item)) dict[item]++;
            else dict.Add(item,1);
        }
        var sorted = dict.OrderByDescending(i => i.Value).ToDictionary(i => i.Key, i => i.Value);
        
        var rs = new StringBuilder("");
        foreach (var item in sorted)
            for (int i = 0; i < item.Value; i++)
                rs.Append(item.Key);
        return rs.ToString();
    }
}