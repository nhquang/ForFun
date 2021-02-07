//https://leetcode.com/problems/palindrome-number/

public class Solution {
    public bool IsPalindrome(int x) {
        if (x <= 0) return x == 0 ? true : false;
        int sum = 0, z = 1, y = x;
        while ((x / 10) >= z) z *= 10;
        while (y > 0)
        {
            sum += (y % 10) * z;
            y /= 10;
            z /= 10;
        }
        return sum == x;
    }
}