//https://leetcode.com/problems/reformat-phone-number/


public class Solution {
    public string ReformatNumber(string s) {
        string temp = string.Empty;
        for (int i = 0; i < s.Length; i++)
            if (Char.IsNumber(s[i]))
                temp += s[i];
        var rslt = new StringBuilder();
        for(int a = 0; a < temp.Length; a++)
        {
            rslt.Append(temp[a]);
            if ((a+1) % 3 == 0 && a != temp.Length - 1)
                rslt.Append("-");
        }
        if (temp.Length % 3 == 1)
        {
            char t = rslt[rslt.Length - 3];
            rslt[rslt.Length - 3] = rslt[rslt.Length - 2];
            rslt[rslt.Length - 2] = t;
        }
        return rslt.ToString();
    }
}