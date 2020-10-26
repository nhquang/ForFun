	//https://leetcode.com/problems/add-strings/

	public string AddStrings(string num1, string num2)
    {
        int[] rslt = null;
        if(num1.Length >= num2.Length)
        {
            rslt = calculate(converted(num1), converted(num2));
        }
        else rslt = calculate(converted(num2), converted(num1));
        return String.Join("", rslt);
    }
    private int[] converted(string num)
    {
        var nums = new List<int>();
            
        foreach (var item in num)
        {

            if (item == 48) nums.Add(0);
            else if (item == 49) nums.Add(1);
            else if (item == 50) nums.Add(2);
            else if (item == 51) nums.Add(3);
            else if (item == 52) nums.Add(4);
            else if (item == 53) nums.Add(5);
            else if (item == 54) nums.Add(6);
            else if (item == 55) nums.Add(7);
            else if (item == 56) nums.Add(8);
            else nums.Add(9);
        }
        return nums.ToArray();

    }
    private int[] calculate(int[] larger, int[] smaller)
    {
        var rslt = new List<int>();
        var carryOn = 0;
        Array.Reverse(larger);
        Array.Reverse(smaller);
        for(int i = 0; i < larger.Length; i++)
        {
            if (i < smaller.Length)
            {
                int temp = larger[i] + smaller[i] + carryOn;
                if (temp >= 10)
                {
                    rslt.Add(temp - 10);
                    carryOn = 1;
                }
                else { rslt.Add(temp); carryOn = 0; }
            }
            else
            {
                int temp = larger[i] + carryOn;
                if (temp >= 10)
                {
                    rslt.Add(temp - 10);
                    carryOn = 1;
                }
                else { rslt.Add(temp); carryOn = 0; }
            }
            if (i == larger.Length - 1 && carryOn == 1) rslt.Add(1); 
        }
        var reversed = rslt.ToArray();
        Array.Reverse(reversed);
        return reversed;
    }