

//https://leetcode.com/problems/find-smallest-letter-greater-than-target/
public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int j = 0;
        while(j < letters.Length){
            if(letters[j] > target) return letters[j];
            j++;
        }
        return letters[0];
    }
}