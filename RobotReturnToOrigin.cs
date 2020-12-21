//https://leetcode.com/problems/robot-return-to-origin/


public class Solution {
    public bool JudgeCircle(string moves) {
        int x = 0, y = 0;
        for(int i = 0; i < moves.Length; i++){
            switch(moves[i]){
                case 'U':
                    x++;
                    break;
                case 'D':
                    x--;
                    break;
                case 'R':
                    y--;
                    break;
                case 'L':
                    y++;
                    break;
            }
        }
        return x == 0 && y == 0 ? true : false;
    }
}


