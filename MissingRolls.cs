//https://leetcode.com/problems/find-missing-observations/submissions/

public class Solution {
    public int[] MissingRolls(int[] rolls, int mean, int n) {
        int total = ((rolls.Length + n) * mean);
        int sum = 0;
        foreach(var item in rolls)
            sum+=item;
        total -= sum;
        if(total > 6 * n || total <= 0 || total / n == 0)
            return new int[]{};
        int[] rs = new int[n];
        for(int i = 0; i < n; i++){
            rs[i] = total / (n - i);
            total -= rs[i];
        }
        return rs;
    }
}