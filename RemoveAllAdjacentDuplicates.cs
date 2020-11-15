//https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/


public class Solution {
    public string RemoveDuplicates(string S) {
        var stack = new Stack<char>();
        for(int i = 0; i < S.Length; i++)
        {
            if(!stack.TryPop(out char temp) || temp != S[i])
            {
                if (Char.IsLetter(temp)) stack.Push(temp);
                stack.Push(S[i]);
            }
        }
        var list = new List<char>();
        
        while(stack.Count > 0)
            list.Add(stack.Pop());
        
        list.Reverse();
        return String.Join("", list);
    }
}