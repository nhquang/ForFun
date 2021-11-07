//https://leetcode.com/problems/remove-colored-pieces-if-both-neighbors-are-the-same-color/

public class Solution {
    public bool WinnerOfGame(string colors) {
        int a = 0, b = 0, temp = 0;
        for(int i = 0; i < colors.Length; i++){
            if(colors[i] == 'A') temp++;
            else temp = 0;
            if(temp > 2) a++;
        }
        temp = 0;
        for(int i = 0; i < colors.Length; i++){
            if(colors[i] == 'B') temp++;
            else temp = 0;
            if(temp > 2) b++;
        }
        if(a > 0 && a > b)
            return true;
        return false;
    }
}