	//https://leetcode.com/problems/convert-integer-to-the-sum-of-two-no-zero-integers/
	
	
	public int[] GetNoZeroIntegers(int n) {
        var rslt = new int[2]{0,0};
        for(int i = 1; i <= n; i++){
            var temp = n - i;
            if(i + temp == n && !detectZeros(i) && !detectZeros(temp)){
                rslt[0] = i;
                rslt[1] = temp;
                break;
            }
        }
        return rslt;
    }
    public bool detectZeros(int num){
        while(num != 0){
			if(num % 10 == 0) return true;
			num /= 10;
		}
		return false;
		
    }