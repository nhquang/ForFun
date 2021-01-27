//https://leetcode.com/problems/implement-strstr/

public class Solution {
    public int StrStr(string haystack, string needle) {
        if(needle.Length == 0) return 0;
        for(int i = 0; i < haystack.Length; i++){
            if(i + needle.Length <= haystack.Length && haystack[i] == needle[0]){
                int temp = i;
                int j;
                for(j = 0; j < needle.Length;j++){
                    if(haystack[temp] != needle[j]) break;
                    temp++;
                }
                if(j == needle.Length) return i;
            }
            else if (i + needle.Length > haystack.Length) break;
        }
        return -1;
    }
}