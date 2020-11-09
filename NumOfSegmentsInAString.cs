	//https://leetcode.com/problems/number-of-segments-in-a-string/



	public int CountSegments(string s) {
        if (string.IsNullOrEmpty(s)) return 0;
        int count = 0;
        bool inSegment = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ' && !inSegment)
            {
                count++;
                inSegment = true;
            }
            else if (s[i] == ' ') inSegment = false;
        }
        return count;
        //return s.Split(' ',StringSplitOptions.RemoveEmptyEntries).Length;
    }