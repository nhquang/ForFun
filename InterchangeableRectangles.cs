//https://leetcode.com/problems/number-of-pairs-of-interchangeable-rectangles/

public class Solution {
    public long InterchangeableRectangles(int[][] rectangles) {
        var dict = new Dictionary<double, List<int[]>>();
        long rs = 0;
        for(int i = 0; i < rectangles.Length; i++){
            double temp = (double) rectangles[i][0] / rectangles[i][1];
            if(dict.ContainsKey(temp)){
                rs += dict[temp].Count;
                dict[temp].Add(rectangles[i]);
            }
            else
                dict.Add(temp, new List<int[]>(){rectangles[i]});
        }
        return rs;
    }
}