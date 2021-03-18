//https://leetcode.com/problems/sqrtx/


public class Solution {
    public int MySqrt(int x) {
        return BinarySearch(0,x,x);
    }
    int BinarySearch(long l, long r, int tar)
    {
        if (l < r)
        {
            long mid = l + (r - l) / 2;
            long temp = mid * mid;
            if (temp == tar) return (int)mid;
            else if (temp > tar || temp <= 0) return BinarySearch(1, mid - 1, tar);
            else if (temp < tar)
            {
                if ((mid + 1) * (mid + 1) > tar) return (int)mid; 
                else return BinarySearch(mid + 1, r, tar);
            }
        }
        return (int)l;
    }
}
