//https://leetcode.com/problems/remove-outermost-parentheses/


public class Solution {
    public string RemoveOuterParentheses(string S) {
        var stack = new Stack<char>();
        string rslt = "";
        for(int i = 0; i < S.Length; i++){
            if(S[i] == '(') {
                stack.Push(S[i]);
                if(stack.Count > 1) rslt += S[i];
            }
            else{
                if(stack.Count > 1) rslt += S[i];
                stack.Pop();
            }
        }
        return rslt;
    }
}