//https://leetcode.com/problems/time-needed-to-buy-tickets/

public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int rs = 0;
        while(true){
            for(int i = 0; i < tickets.Length; i++){
                if(tickets[i] > 0){
                    rs++;
                    tickets[i]--;
                }
                if(tickets[k] == 0)
                    return rs;
            }
        }
        return 0;
    }
}