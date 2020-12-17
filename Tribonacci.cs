

public class Solution {
    public int Tribonacci(int n) {
        /*if(n <= 2){
            return n == 0 ? 0 : 1;
        }
        return Tribonacci(n - 1) + Tribonacci (n - 2) + Tribonacci(n - 3);*/
        
        if(n < 3)
        {
            if(n == 0) return 0;
            else return 1;
        }
        int rslt = 0, prev1 = 1, prev2 = 1, prev3 = 0;
        for(int i = 3; i <= n; i++)
        {
            rslt = prev1 + prev2 + prev3;
            prev3 = prev2;
            prev2 = prev1;
            prev1 = rslt;
        }
        return rslt;
    }
}