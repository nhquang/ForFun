//https://leetcode.com/problems/partition-labels/


public class Solution {
    public IList<int> PartitionLabels(string S) {
        var dict = new Dictionary<int, int[]>();
        var rs = new List<int>();
        for(int i = 0; i < S.Length; i++){
            if(dict.ContainsKey(S[i])) dict[S[i]][1] = i;
            else dict.Add(S[i], new int[2] {i, -1});
        }
        for(int i = 0; i < S.Length; i++){
            int j = i, len = -1;
            while(j < S.Length){
                if(dict[S[j]][1] != -1) {
                    if(len == -1 || j < len) len = Math.Max(len, dict[S[j]][1]);
                    else break;
                }
                else if(len == -1 || len < j) break;
                j++;
            }
            int size = len == -1 ? 1 : len + 1 - i;
            rs.Add(size);
            i = len == -1 ? j : len;
        }
        return rs;
    }
}