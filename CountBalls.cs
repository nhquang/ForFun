//https://leetcode.com/problems/maximum-number-of-balls-in-a-box/

public class Solution {
    public int CountBalls(int lowLimit, int highLimit) {
        var boxes = new Dictionary<int,int>();
        for(int i = lowLimit; i <= highLimit; i++){
            int temp = 0, j = i;
            while(j > 0){
                temp += (j % 10);
                j /= 10;
            }
            if(boxes.ContainsKey(temp)) boxes[temp]++;
            else boxes.Add(temp, 1);
        }
        int max = int.MinValue;
        foreach(var item in boxes) max = Math.Max(max, item.Value);
        return max;
    }
}