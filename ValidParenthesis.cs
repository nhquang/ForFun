	//https://leetcode.com/problems/valid-parentheses/
	
	
	
	public bool IsValid(string s)
    {
        var matches = new Dictionary<char, char>();
        matches.Add(')', '(');
        matches.Add('}', '{');
        matches.Add(']', '[');
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[') stack.Push(s[i]);
            else
            {
                if (stack.Count != 0)
                {
                    switch (s[i])
                    {
                        case ')':
                            if (stack.Pop() != matches[')']) return false;
                            break;
                        case '}':
                            if (stack.Pop() != matches['}']) return false;
                            break;
                        case ']':
                            if (stack.Pop() != matches[']']) return false;
                            break;
                    }
                }
                else return false;
            }
        }
        if(stack.Count != 0) return false;
        return true;
    }