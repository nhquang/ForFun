//https://leetcode.com/problems/find-the-town-judge/


public class Solution {
    public int FindJudge(int N, int[][] trust) {
        var dict = new Dictionary<int, int>();
        var pp = new HashSet<int>();
        for (int i = 0; i < trust.Length; i++)
        {
            if (dict.ContainsKey(trust[i][1])) dict[trust[i][1]]++;
            else dict.Add(trust[i][1], 1);
            pp.Add(trust[i][0]);
        }
        foreach(var item in dict)
            if(item.Value == N - 1 && !pp.Contains(item.Key))
                return item.Key;
        
        if(N == 1) return 1;
        return -1;
    }
}