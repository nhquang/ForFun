//https://leetcode.com/problems/number-of-students-doing-homework-at-a-given-time/

public class Solution {
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime) {
        int rs = 0;
        for(int i = 0; i < startTime.Length; i++)
            if(startTime[i] <= queryTime && endTime[i] >= queryTime)
                rs++; 
        return rs;
    }
}