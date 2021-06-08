//https://leetcode.com/problems/number-of-days-between-two-dates/

public class Solution {
    public int DaysBetweenDates(string date1, string date2) {
        return Math.Abs(fdate(date2) - fdate(date1));
    }
    int fdate(string date1){
        int sum = 0;
        int yr = int.Parse(date1.Substring(0,4));
        for(int i = 1900; i < yr; i++){
            if((i % 100 == 0 && i % 400 == 0) || (i % 4 == 0 && i % 100 != 0))
                sum += 366;
            else sum += 365;
        }
        bool temp = false;
        if((yr % 100 == 0 && yr % 400 == 0) || (yr % 4 == 0 && yr % 100 != 0))
            temp = true;
        int mo = int.Parse(date1.Substring(5, 2));
        for(int i = 1; i < mo; i++){
            if(i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12) sum += 31;
            else if(i == 2){
                if(temp) sum += 29;
                else sum += 28;
            }
            else sum += 30;
        }
        sum += int.Parse(date1.Substring(8,2));
        return sum;
    }
}