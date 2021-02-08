//https://leetcode.com/problems/reverse-words-in-a-string-iii/

public class Solution {
    public string ReverseWords(string s) {
        string[] strArr = s.Split(' ');
        List<string> rslt = new List<string>();
        for(int i = 0; i < strArr.Length; i++){
            var temp = strArr[i].ToCharArray();
            Array.Reverse(temp);
            rslt.Add(String.Join("", temp));
        }
        return String.Join(" ", rslt);
    }
}