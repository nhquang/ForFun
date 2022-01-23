//https://leetcode.com/problems/capitalize-the-title/

public class Solution {
    public string CapitalizeTitle(string title) {
        var arr = title.Split(' ');
        var sb = new StringBuilder("");
        foreach(var word in arr){
            if(word.Length > 2){
                for(int i = 0; i < word.Length; i++){
                    if(i == 0) sb.Append(Char.ToUpper(word[i]));
                    else sb.Append(Char.ToLower(word[i]));
                }
            }
            else{
                for(int i = 0; i < word.Length; i++)
                    sb.Append(Char.ToLower(word[i]));
            }
            sb.Append(' ');
        }
        return sb.ToString().TrimEnd();
    }
}