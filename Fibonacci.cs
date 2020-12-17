//https://leetcode.com/problems/fibonacci-number/



public class Solution {
    
	//recursive method
	public int Fib(int N) {
        if(N <= 1) return N;
        return Fib(N-1) + Fib(N-2);
    }
	
	//iterative method
	public int Fib(int n) {
        if(n < 2) return n == 0 ? 0 : 1;
        int rslt = 0, prev1 = 1, prev2 = 0;
        for(int i = 2; i <= n; i++){
            rslt = prev1 + prev2;
            prev2 = prev1;
            prev1 = rslt;
        }
        return rslt;
    }
	
	
}