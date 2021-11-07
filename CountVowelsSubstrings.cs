//https://leetcode.com/problems/count-vowel-substrings-of-a-string/


public class Solution {
    public int CountVowelSubstrings(string word) {
        var vowels = new char[5]{'a','e','i','o', 'u'};
        int rs = 0;
        for(int i = 0; i < word.Length; i++){
            string temp = "";
            if(vowels.Contains(word[i])){
                temp += word[i];
                for(int j = i + 1; j < word.Length; j++){
                    if(vowels.Contains(word[j])){
                        temp += word[j];
                        for(int k = j + 1; k < word.Length; k++){
                             if(vowels.Contains(word[k])){
                                 temp += word[k];
                                 for(int h = k + 1; h < word.Length; h++){
                                     if(vowels.Contains(word[h])){
                                         temp += word[h];
                                         for(int l = h + 1; l < word.Length; l++){
                                             if(vowels.Contains(word[l])){
                                                 temp += word[l];
                                                 if(AllVowelsExist(temp)) rs++;
                                             }
                                             else break;
                                         }
                                     }
                                     break;
                                 }
                             }
                            break;
                        }
                    }
                    break;
                }
            }
        }
        return rs;
    }
    private bool AllVowelsExist(string s)
        => s.Contains('a') && s.Contains('e') && s.Contains('i') && s.Contains('o') && s.Contains('u');

}