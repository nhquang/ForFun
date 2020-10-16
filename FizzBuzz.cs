	//https://leetcode.com/problems/fizz-buzz/
	
	public IList<string> FizzBuzz(int n) {
        var rslt = new List<string>();
        for(int i = 1; i <= n; i++){
            string temp = "";
            if(i % 3 == 0) temp += "Fizz";
            if(i % 5 == 0) temp += "Buzz";
            if(temp == "") temp += i.ToString();
            rslt.Add(temp);
        }
        return rslt;
    }