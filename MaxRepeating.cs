//https://leetcode.com/problems/maximum-repeating-substring/


public class Solution {
    public int MaxRepeating(string sequence, string word) {
        var set = new HashSet<string>();
        set.Add(word);
        int max = 0;
        for(int i = 0; i < sequence.Length; i++){
            int count = 0;
            for(int j = i; j < sequence.Length; j++){
                if (j + word.Length > sequence.Length) break;
                string temp = sequence.Substring(j, word.Length);
                if(set.Contains(temp))
                    count++;
                else break;
                j += word.Length - 1;
            }
            if(count > max) max = count;
        }
        return max;
    }
}