	//https://leetcode.com/problems/reverse-integer/
	
	
	public int Reverse(int x) {
        var nums = new List<int>();
        long temp = 1, rslt = 0;
        bool  negative = false;
        if(x >= int.MaxValue || x <= int.MinValue) return 0;   //avoid overflow
        if(x < 0) { negative = true; x = Math.Abs(x); }
        while(x > 0){
            nums.Add((x % 10));
            x /= 10;
            temp *= 10;
        }
        temp /= 10;
        
        foreach(var item in nums){
            rslt += (temp * item);
            temp /= 10;
        }
        if(rslt > int.MaxValue) return 0;						//avoid overflow
        if(negative) rslt *= -1;
        return (int)rslt;
    }