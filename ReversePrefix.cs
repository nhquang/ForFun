//https://leetcode.com/problems/reverse-prefix-of-word/

public class Solution {
    public string ReversePrefix(string word, char ch) {
        var idx = word.IndexOf(ch);
        var arr = word.ToCharArray();
        int i = 0, j = idx;
        while(i < j){
            var temp = arr[i];
            arr[i++] = arr[j];
            arr[j--] = temp;
        }
        return new string(arr);
    }
}