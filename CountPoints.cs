//https://leetcode.com/problems/rings-and-rods/


public class Solution {
    public int CountPoints(string rings) {
        var dict = new Dictionary<char, string>();
        for(int i = 1; i < rings.Length; i+=2){
            if(dict.ContainsKey(rings[i])) {
                if(!dict[rings[i]].Contains(rings[i - 1]))
                    dict[rings[i]] += rings[i - 1];
            }
            else
                dict.Add(rings[i], $"{rings[i - 1]}");
        }
        int rs = 0;
        foreach(var item in dict){
            if(item.Value.Length == 3)
                rs++;
        }
        return rs;
    }
}