//https://leetcode.com/problems/check-if-word-equals-summation-of-two-words/

public class Solution {
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
        return convert(firstWord) + convert(secondWord) == convert(targetWord);
    }
    int convert(string word){
        int sum = 0;
        for(int i = 0; i < word.Length; i++){
            int temp = word[i] - 'a';
            sum = sum * 10 + temp;
        }
        return sum;
    }
}