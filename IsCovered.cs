//https://leetcode.com/problems/check-if-all-the-integers-in-a-range-are-covered/

public class Solution {
    public bool IsCovered(int[][] ranges, int left, int right) {
        var set = new HashSet<int>();
        for(int i = 0; i < ranges.Length; i++){
            for(int j = ranges[i][0]; j <= ranges[i][1]; j++){
                set.Add(j);
            }
        }
        for(int i = left; i <= right; i++){
            if(!set.Contains(i)) return false;
        }
        return true;
    }
}