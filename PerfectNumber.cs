//https://leetcode.com/problems/perfect-number/

public class Solution {
    public bool CheckPerfectNumber(int num)
    {
        int sum = 0;
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
                sum += i;
            if (sum > num) return false;
                
        }
        return sum == num;
    }
}