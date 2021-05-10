//https://leetcode.com/problems/minimum-number-of-operations-to-move-all-balls-to-each-box/

public class Solution {
	//O(n)
    public int[] MinOperations(string boxes) {
        var leftsum = new int[boxes.Length];
        var rightsum = new int[boxes.Length];
        var rs = new int[boxes.Length];
        int sum = 0, balls = 0;
        for(int i = 0; i < boxes.Length; i++){
            sum += balls;
            leftsum[i] = sum;
            if(boxes[i] == '1') balls++;
        }
        sum = 0; balls = 0;
        for(int i = boxes.Length - 1; i >= 0; i--){
            sum += balls;
            rightsum[i] = sum;
            if(boxes[i] == '1') balls++;
        }
        for(int i = 0; i < boxes.Length; i++)
            rs[i] = leftsum[i] + rightsum[i];
        return rs;
    }
	//O(n2)
	public int[] MinOperations(string boxes) {
        var rs = new int[boxes.Length];
        for(int i = 0; i < boxes.Length; i++){
            int left = 0, right = 0;
            for(int j = i - 1; j >= 0; j--){
                if(boxes[j] == '1') left += i - j;
            }
            for(int j = i + 1; j < boxes.Length; j++){
                if(boxes[j] == '1') right += j - i;
            }
            rs[i] = left + right;
		}
    }
}