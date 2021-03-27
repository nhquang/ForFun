//https://leetcode.com/problems/find-nearest-point-that-has-the-same-x-or-y-coordinate/

public class Solution {
    public int NearestValidPoint(int x, int y, int[][] points) {
        int min = int.MaxValue, minIdx = -1;
        for(int i = 0; i < points.Length; i++){
            if(points[i][0] == x && points[i][1] == y){
                return i;
            }
            else if (points[i][0] == x){
                if(Math.Abs(y - points[i][1]) < min){
                    min = Math.Abs(y - points[i][1]);
                    minIdx = i;
                }
            }
            else if (points[i][1] == y){
                if(Math.Abs(x - points[i][0]) < min){
                    min = Math.Abs(x - points[i][0]);
                    minIdx = i;
                }
            }
        }
        return minIdx;
    }
}