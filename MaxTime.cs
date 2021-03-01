//https://leetcode.com/problems/latest-time-by-replacing-hidden-digits/

public string MaximumTime(string time) {
    var chars = time.ToCharArray();
    for(int i = 0; i < chars.Length;i++){
        if(chars[i] == '?'){
            if (i == 0)
            {
                if (chars[i + 1] == '?' || Char.GetNumericValue(chars[i + 1]) <= 3) chars[i] = '2';
                else chars[i] = '1';
            }
            else if (i == 1){
                if(chars[i - 1] == '2') chars[i] = '3';
                else chars[i] = '9';
            }
            else if (i == 3) chars[i] = '5';
            else if (i == 4) chars[i] = '9';
        }
    }
        return new string(chars);
}