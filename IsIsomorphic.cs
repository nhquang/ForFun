	//https://leetcode.com/problems/isomorphic-strings/
	
	
		public bool IsIsomorphic(string s, string t)
        {
            var matches = new Dictionary<char, char>();
			for(int i = 0; i < s.Length; i++){
            if(!matches.ContainsKey(s[i])){
                if(!matches.ContainsValue(t[i]))  matches.Add(s[i],t[i]);
                else return false;
            }
            else
                if(matches[s[i]] != t[i]) return false;
			}
        
			return true;
        }