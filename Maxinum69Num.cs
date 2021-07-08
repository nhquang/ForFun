//https://leetcode.com/problems/maximum-69-number/

public class Solution {
    public int Maximum69Number (int num) {
        int rs = 0;
        var stack = new Stack<int>();
        while (num > 0){
            stack.Push(num % 10);
            num /= 10;
        }
        int temp = 1;
        for(int i = 1; i < stack.Count; i++) temp *= 10;
        bool modified = false;
        while(stack.Count > 0){
            int dig = 0;
            if(stack.Peek() == 6 && !modified){
                modified = true;
                stack.Pop();
                dig = 9;
            }
            else dig = stack.Pop();
            rs += temp * dig;
            temp /= 10;
        }
        return rs;
    }
}