		//https://leetcode.com/problems/reverse-only-letters/
		
		
		var arr = S.ToCharArray();
        int j = S.Length - 1, i = 0;
        while(j > i){
            if (Char.IsLetter(arr[i]) && Char.IsLetter(arr[j]))
            {
                var temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
                
            else if (!Char.IsLetter(arr[i]) && Char.IsLetter(arr[j]))
                j++;
            else if (Char.IsLetter(arr[i]) && !Char.IsLetter(arr[j]))
                i--;
            i++; j--;
        }
        return String.Join("", arr);