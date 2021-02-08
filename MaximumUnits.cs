//https://leetcode.com/problems/maximum-units-on-a-truck/

public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize)
    {
        Array.Sort(boxTypes, (a, b) => {return b[1] - a[1];});
        int boxes = 0, units = 0;
        for(int i = 0; i < boxTypes.Length; i++)
        {
            boxes += boxTypes[i][0];
            units += boxTypes[i][1] * boxTypes[i][0];
            if(boxes > truckSize)
            {
                int temp = boxes - truckSize;
                units -= (temp * boxTypes[i][1]);
                return units;
            }
        }
        return units;
    }
    
}