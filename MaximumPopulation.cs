//https://leetcode.com/problems/maximum-population-year/

public class Solution {
    public int MaximumPopulation(int[][] logs) {
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < logs.Length; i++){
            if (!dict.ContainsKey(logs[i][0]))
            {
                dict.Add(logs[i][0], 1);
                for (int j = 0; j < logs.Length; j++)
                    if (j != i)
                        if (logs[i][0] >= logs[j][0] && logs[i][0] < logs[j][1]) dict[logs[i][0]]++;
            }
        }
        int rs = int.MaxValue, pop = int.MinValue;
        foreach(var item in dict){
            if(item.Value > pop){
                rs = item.Key;
                pop = item.Value;
            }
            else if (item.Value == pop && item.Key < rs) rs = item.Key;
        }
        return rs;
    }
}

