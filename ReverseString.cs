	//https://leetcode.com/problems/reverse-string/



	public void ReverseString(char[] s) {
        int i = 0, j = s.Length - 1;
        while(j > i){
            char temp = s[j];
            s[j] = s[i];
            s[i] = temp;
            i++;j--;
        }
    }