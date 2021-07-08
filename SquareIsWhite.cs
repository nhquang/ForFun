//https://leetcode.com/problems/determine-color-of-a-chessboard-square/

public class Solution {
    public bool SquareIsWhite(string coordinates) {
        bool first = false, second = false;
        if((coordinates[0] - 'a' + 1) % 2 == 0) first = true;
        if((coordinates[1] - '0') % 2 == 0) second = true;
        if((first && second) || (!first && !second)) return false;
        return true;
    }
}