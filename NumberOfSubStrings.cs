	//https://leetcode.com/problems/number-of-substrings-containing-all-three-characters/

	//easy implementation
	public int NumberOfSubstrings(string s) {
        char[] chars = s.ToCharArray();
        int rslt = 0;
        string temp = "";
        for(int i = 0; i < chars.Length - 2; i++){
            for(int j = i; j < chars.Length; j++){
                temp += chars[j].ToString();
                if(temp.Length >= 3){
                    if(temp.Contains("a") && temp.Contains("b") && temp.Contains("c")) rslt++;
                }
            }
            temp = "";
        }
        return rslt;
    }
	//faster runtime when the input is a huge string
	public int NumberOfSubstrings(string s)
        {
            int rslt = 0, construct = 0, temp = 0;
			
            bool a = false, b = false, c = false;
			
            for (int i = 0; i < s.Length - 2; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    temp++;
                    switch (s[j])
                    {
                        case 'a':
                            if(!a)
                            {
                                a = true;
                                construct += 1;
                            }
                              
                            break;
                        case 'b':
                            if (!b)
                            {
                                b = true;
                                construct += 2;
                            }
                            break;
                        case 'c':
                            if (!c)
                            {
                                c = true;
                                construct += 3;
                            }
                            break;
                    }
                    if (temp >= 3)
                    {
                        if (construct == 6)
                            rslt++;
                    }

                }
                temp = construct = 0;
                a = b = c = false;
            }
            return rslt;
        }