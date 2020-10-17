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