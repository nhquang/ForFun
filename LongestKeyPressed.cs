//https://leetcode.com/problems/slowest-key/


public class Solution {
    public char SlowestKey(int[] releaseTimes, string keysPressed) {
        var max = releaseTimes[0]; char maxKey = keysPressed[0];
        for(int i = 1; i < releaseTimes.Length; i++){
            if(releaseTimes[i] - releaseTimes[i - 1] > max){
                max = releaseTimes[i] - releaseTimes[i - 1];
                maxKey = keysPressed[i];
            }
            else if (releaseTimes[i] - releaseTimes[i - 1] == max && keysPressed[i] > maxKey){
                maxKey = keysPressed[i];
            }
        }
        return maxKey;
    }
}