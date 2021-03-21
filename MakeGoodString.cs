		//https://leetcode.com/problems/make-the-string-great/
		
		public string MakeGood(string s) {
			var rslt = new StringBuilder(s);
            var idx = 0;
            while(idx < rslt.Length)
            {
                for(int i = 0; i < rslt.Length - 1; i++)
                {
                    if(Math.Abs(rslt[i] - rslt[i+1]) == 32)
                    {
                        rslt.Remove(i, 2);
                        idx = 0;
                        break;
                    }
                }
                idx++;
            }
            return rslt.ToString();
		}
		//Stack
		public string MakeGood(string s) {
        var stack = new Stack<char>();
        for(int i = 0; i < s.Length; i++){
            if(stack.Count > 0 && Math.Abs(stack.Peek() - s[i]) == 32) stack.Pop();
            else stack.Push(s[i]);
        }
        var result = new char[stack.Count];
        var j = 0;
        while(stack.Count > 0){
            result[j] = stack.Pop();
            j++;
        }
        Array.Reverse(result);
        return new string(result);
    }