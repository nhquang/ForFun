
//https://leetcode.com/problems/merge-strings-alternately/

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var rslt = "";
        int i = 0, j = 0;
        while(i < word1.Length || j < word2.Length){
            if(i < word1.Length) rslt += word1[i];
            if(j < word2.Length) rslt += word2[j];
            i++; j++;
        }
        return rslt;
    }
}