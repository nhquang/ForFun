//https://leetcode.com/problems/group-anagrams/

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        for(int i = 0; i < strs.Length; i++){
            var chars = strs[i].ToCharArray();
            Array.Sort(chars);
            var temp = new string(chars);
            if(dict.ContainsKey(temp)) dict[temp].Add(strs[i]);
            else dict.Add(temp, new List<string>(){strs[i]});
        }
        var rs = new List<List<string>>();
        foreach(var item in dict){
            var temp = new List<string>();
            for(int i = 0; i < item.Value.Count; i++){
                temp.Add(item.Value[i]);
            }
            rs.Add(temp);
        }
        return rs.ToArray();
    }
}