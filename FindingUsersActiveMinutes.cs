//https://leetcode.com/problems/finding-the-users-active-minutes/

public class Solution {
    public int[] FindingUsersActiveMinutes(int[][] logs, int k) {
        var rslt = new int[k];
        var dict = new Dictionary<int, HashSet<int>>();
        for(int i = 0; i < logs.Length; i++){
            if(!dict.ContainsKey(logs[i][0])){
                var temp = new HashSet<int>();
                temp.Add(logs[i][1]);
                dict.Add(logs[i][0], temp);
            }
            else dict[logs[i][0]].Add(logs[i][1]);
        }
        foreach(var item in dict) rslt[item.Value.Count - 1]++;
        return rslt;
    }
}