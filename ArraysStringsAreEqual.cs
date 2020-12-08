//https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/


public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        var w1 = String.Join("", word1);
        var w2 = String.Join("", word2);
        return w1.Equals(w2);
    }
}


public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        int i = 0, j = 0;
        string w1 = string.Empty, w2 = string.Empty;
        while(i < word1.Length || j < word2.Length){
            if(i < word1.Length) w1 += word1[i];
            if(j < word2.Length) w2 += word2[i];
            i++; j++;
        }
        if(w1.Length != w2.Length) return false;
        for(i = 0; i < w1.Length; i++){
            if(w1[i] != w2[i]) return false;
        }
        return true;
    }
}