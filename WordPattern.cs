	//https://leetcode.com/problems/word-pattern/submissions/



	public bool WordPattern(string pattern, string s) {
        var matches = new Dictionary<char, string>();
        var sArr = s.Split(" ");
        if(pattern.Length != sArr.Length) return false;
        for(int i = 0; i < pattern.Length; i++){
            if(matches.ContainsKey(pattern[i])){
                if(matches[pattern[i]] != sArr[i]) return false;
            }
            else{
                if(matches.ContainsValue(sArr[i])) return false;
                matches.Add(pattern[i], sArr[i]);
            }
        }
        return true;
    }