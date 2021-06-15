//https://leetcode.com/problems/day-of-the-year/

public class Solution {
    public int DayOfYear(string date) {
        int mo = int.Parse(date.Substring(5,2));
        int yr = int.Parse(date.Substring(0,4));
        int rs = 0;
        for(int i = 1; i < mo; i++){
            if(i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12) rs += 31;
            else if (i == 2){
                if((yr % 100 == 0 && yr % 400 == 0) || (yr % 4 == 0 && yr % 100 != 0)) rs += 29;
                else rs += 28;
            }
            else rs += 30;
        }
        return rs += int.Parse(date.Substring(8,2));
    }
}