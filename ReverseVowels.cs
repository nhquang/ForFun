	//https://leetcode.com/problems/reverse-vowels-of-a-string/
	
	
	public string ReverseVowels(string s) {
        var arr = s.ToCharArray();
        int i = 0, j = arr.Length - 1;
        while(j > i){
            var l = isVowel(arr[i]);
            var r = isVowel(arr[j]);
            if(l && r){
                char temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            else if(l && !r) i--;
            else if(!l && r) j++;
            i++; j--;
        }
        return String.Join("", arr);
    }
    private bool isVowel(char c){
        if (c == 'a' || c == 'e' || c == 'o' || c == 'i' || c == 'u' ||
            c == 'A' || c == 'E' || c == 'O' || c == 'I' || c == 'U') return true;
        return false;
    }