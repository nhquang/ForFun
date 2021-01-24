//https://leetcode.com/problems/guess-number-higher-or-lower/


/* 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is lower than the guess number
 *			      1 if num is higher than the guess number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        return BinarySearch(1, n);
    }
    int BinarySearch(int l, int r){
        if(l <= r){
            int temp = l + (r - l) / 2;
            if(guess(temp) == 0) return temp;
            else if(guess(temp) == -1) return BinarySearch(l, temp - 1);
            else return BinarySearch(temp + 1, r);
        }
        return -1;
    }
}