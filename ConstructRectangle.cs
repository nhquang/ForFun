//https://leetcode.com/problems/construct-the-rectangle/

public class Solution {
    public int[] ConstructRectangle(int area) {
        var temp = (int)Math.Sqrt(area);
        for(int i = temp; i >= 0; i--){
            if(area % i == 0)
                return new int[]{area / i, i};
        }
        return null;
    }
}