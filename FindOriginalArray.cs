//https://leetcode.com/problems/find-original-array-from-doubled-array/

public class Solution {
    public int[] FindOriginalArray(int[] changed) {
        if(changed.Length % 2 != 0)
            return new int[0]{};
        var sorted = new Dictionary<int, int>();
        var sortedSet = new HashSet<int>();
        Array.Sort(changed);
        foreach(var item in changed){
            if(sorted.ContainsKey(item))
                sorted[item]++;
            else sorted.Add(item, 1);
            sortedSet.Add(item);
        }
        var rs = new List<int>();
        foreach(var item in sortedSet){
            if(sorted.ContainsKey(item)){
                if(sorted.ContainsKey(item*2)){
                    if(item != 0){
                        for(int i = 0; i < sorted[item]; i++) rs.Add(item);
                        if(sorted[item] == sorted[item*2]){
                            sorted.Remove(item);
                            sorted.Remove(item*2);
                        }
                        else if(sorted[item] > sorted[item*2]) return new int[0]{};
                        else {
                            sorted[item*2] -= sorted[item];
                            sorted.Remove(item);
                        }
                    }
                    else{
                        if(sorted[0] % 2 == 0) {
                            for(int i = 0; i < sorted[0] / 2; i++) rs.Add(0);
                            sorted.Remove(0);
                        }
                        else return new int[0]{};
                    }
                }
                else return new int[0]{};
            }
        }
        
        return rs.ToArray();
    }
}