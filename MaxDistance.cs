//https://leetcode.com/problems/two-furthest-houses-with-different-colors/

public class Solution {
    public int MaxDistance(int[] colors) {
        int rs = 0;
        for(int i = 0; i < colors.Length; i++){
            for(int j = i + 1; j < colors.Length; j++){
                if(colors[i] != colors[j])
                    rs = Math.Max(rs, j - i);
            }
        }
        return rs;
    }
}