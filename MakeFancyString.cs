//https://leetcode.com/problems/delete-characters-to-make-fancy-string/

public class Solution {
    public string MakeFancyString(string s) {
        var sb = new StringBuilder();
        int count = 1; char prev = '\0';
        for(int i = 0; i < s.Length; i++){
            if(s[i] == prev){
                count++;
                if(count < 3) sb.Append(s[i]);
            }
            else {
                count = 1;
                sb.Append(s[i]);
            }
            prev = s[i];
        }
        return sb.ToString();
    }
	
	//using Stack
	public string MakeFancyStringStack(string s){
		var stack = new Stack<char>();
        int count = 1;
        for(int i = 0; i < s.Length; i++){
            if(stack.Count > 0 && s[i] == stack.Peek()){
                count++;
                if(count < 3) stack.Push(s[i]);
            }
            else{
                count = 1;
                stack.Push(s[i]);
            }
        }
        var rs = new char[stack.Count];
        for(int i = 0; i < rs.Length; i++) rs[i] = stack.Pop();
        Array.Reverse(rs);
        return new string(rs);
	}
}