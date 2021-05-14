//https://leetcode.com/problems/positions-of-large-groups/

public class Solution {
    public IList<IList<int>> LargeGroupPositions(string s) {
        IList<IList<int>> rs = new List<IList<int>>();
        int temp = 0; char prev = s[0]; int start = 0;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == prev) temp++;
            else {
                if (temp >= 3)
                    rs.Add(new List<int>(){ start, i-1 });
                start = i;
                temp = 1;
                prev = s[i];
            }
        }
        if (temp >= 3)
            rs.Add(new List<int>(){ start, s.Length - 1});
        return rs;
    }
}