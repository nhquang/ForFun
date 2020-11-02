	//https://leetcode.com/problems/add-digits/

	public int AddDigits(int num) {
        var count = 0;
        while(num >= 10){
            while(num > 0){
                count += (num % 10);
                num /= 10;
            }
            num = count; count = 0;
        }
        return num;
    }