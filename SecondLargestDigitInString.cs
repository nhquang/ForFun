//https://leetcode.com/problems/second-largest-digit-in-a-string/

public class Solution {
    public int SecondHighest(string s) {
        int largest = int.MinValue;
        int sndLargest = int.MinValue;
        foreach(var item in s){
            if(Char.IsDigit(item)){
                if(Convert.ToInt32(item.ToString()) > largest){
                    sndLargest = largest;
                    largest = Convert.ToInt32(item.ToString());
                }
                else if (Convert.ToInt32(item.ToString()) > sndLargest && Convert.ToInt32(item.ToString()) != largest)
                    sndLargest = Convert.ToInt32(item.ToString());
            }
        }
        return sndLargest != int.MinValue ? sndLargest : -1;
    }
}