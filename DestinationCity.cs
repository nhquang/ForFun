//https://leetcode.com/problems/destination-city/


public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        var set = new HashSet<string>();
        for(int i = 0; i < paths.Count; i++)
            set.Add(paths[i][0]);
        for(int i = 0; i < paths.Count; i++)
            if(!set.Contains(paths[i][1])) return paths[i][1];
        return "";
    }
}