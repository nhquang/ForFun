//https://leetcode.com/problems/number-of-valid-words-in-a-sentence/

public class Solution {
    public int CountValidWords(string sentence) {
        var arr = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var punctuationMarks = new char[3] {'!','.',','};
        var rs = 0;
        foreach(var item in arr){
            bool temp = true;
            if(item.Length == 1 && !Char.IsDigit(item[0]) && item[0] != '-') continue;
            if(item.Contains(punctuationMarks[0]) || item.Contains(punctuationMarks[1]) || item.Contains(punctuationMarks[2])) {
                if(punctuationMarks.Contains(item[item.Length - 1])){
                    int count = 0;
                    foreach(var c in item)
                        if(punctuationMarks.Contains(c))
                            count++;
                    if(count > 1 || punctuationMarks.Contains(item[0])) temp = false;
                }
                else temp = false;
            }
            if(item.Contains('-')){
                if(item[0] == '-' || item[item.Length-1] == '-') temp = false;
                else {
                    int noOfHyphens = 0;
                    foreach(var c in item)
                        if(c == '-') noOfHyphens++;
                    if(noOfHyphens > 1) temp = false;
                    else{
                        if(punctuationMarks.Contains(item[item.IndexOf('-') + 1])) temp = false;
                    }
                }
            }
            foreach(var c in item){
                if(Char.IsDigit(c)){
                    temp = false;
                    break;
                }
            }
            if(!temp) rs--;
        }
        return arr.Length + rs;
    }
}