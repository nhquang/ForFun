//https://leetcode.com/problems/number-of-equivalent-domino-pairs/

public class Solution {
    public int NumEquivDominoPairs(int[][] dominoes) {
        var dict = new Dictionary<string, int>();
        foreach (var item in dominoes)
        {
            string temp1 = item[0].ToString() + item[1].ToString();
            string temp2 = item[1].ToString() + item[0].ToString();
            if (dict.ContainsKey(temp1)) dict[temp1]++;
            else if (dict.ContainsKey(temp2)) dict[temp2]++;
            else dict.Add(item[0].ToString() + item[1].ToString(), 1);
        }
        int rs = 0;
        foreach(var item in dict)
           for(int i = 1; i < item.Value; i++) rs += i;

        return rs;
    }
}