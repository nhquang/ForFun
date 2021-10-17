//https://leetcode.com/problems/minimum-number-of-moves-to-seat-everyone/

public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
        Array.Sort(seats);
        Array.Sort(students);
        int rs = 0;
        for(int i = 0; i < seats.Length; i++)
            rs += Math.Abs(students[i] - seats[i]);
        return rs;
    }
}