
//https://leetcode.com/problems/minimum-add-to-make-parentheses-valid/

public class Solution {
    public int MinAddToMakeValid(string S) {
        var stack = new Stack<char>();
        for(int i = 0; i < S.Length; i++){
            if(S[i] == ')' && stack.Count > 0){
                if(stack.Peek() == '(') stack.Pop();
                else stack.Push(S[i]);
            }
            else stack.Push(S[i]);;
        }
        return stack.Count;
    }
}