//https://leetcode.com/problems/fibonacci-number/



public class Solution {
    public int Fib(int N) {
        if(N <= 1) return N;
        return Fib(N-1) + Fib(N-2);
    }
}