//https://leetcode.com/problems/valid-perfect-square/


public class Solution {
    public bool IsPerfectSquare(int num) {
        return BinarySearch(1,num, num);
    }
    bool BinarySearch(long l, long r, long num){
        if(r >= l){
            long mid = l + (r - l) / 2;
            if(mid * mid == num) return true;
            else if(mid * mid > num) return BinarySearch(l, mid-1, num);
            else return BinarySearch(mid+1, r, num);
        }
        return false;
    }
}