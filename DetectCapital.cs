	//https://leetcode.com/problems/detect-capital/
	
	
	
	public bool DetectCapitalUse(string word) {
        bool allLower = false, allUpper = false, firstUpper = false;
        
        for(int i = 0; i < word.Length; i++){
            if(i == 0){
                if(Char.IsUpper(word[i])) allUpper = firstUpper = true;

                else allLower = true;
            }
            else{
                if(allLower)
                    if(Char.IsUpper(word[i])) return false;

                else if(allUpper || firstUpper){
                    if(Char.IsUpper(word[i]))
                        firstUpper = false;
                    
                    else allUpper = false;
                }
            }
        }
        if(allLower || allUpper || firstUpper) return true;
        return false;
    }