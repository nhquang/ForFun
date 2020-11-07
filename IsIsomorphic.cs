	//https://leetcode.com/problems/isomorphic-strings/
	
	
	public bool IsIsomorphic(string s, string t)
        {
            var dict1 = new Dictionary<char, int>();
            var dict2 = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict1.ContainsKey(s[i])) dict1[s[i]]++;
                else dict1.Add(s[i], 1);
                if (dict2.ContainsKey(t[i])) dict2[t[i]]++;
                else dict2.Add(t[i], 1);
            }
            if (dict1.Count != dict2.Count) return false;
            for (int i = 0; i < dict1.Count; i++)
            {
                if (dict1.ElementAt(i).Value != dict2.ElementAt(i).Value) return false;
                else
                {
                    for(int j = 0; j < s.Length; j++)
                    {
                        if (s[j] == dict1.ElementAt(i).Key)
                            if (t[j] != dict2.ElementAt(i).Key)
								return false;
                    }
                }
            }
            return true;
        }