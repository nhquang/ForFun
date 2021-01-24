//https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/

public class Solution {
    public int SubtractProductAndSum(int n) {
        int prod = 1, sum = 0;
        while(n != 0){
            sum += n % 10;
            prod *= n % 10;
            n /= 10;
        }
        return prod - sum;
    }
}