//https://leetcode.com/problems/largest-number-after-mutating-substring/

public class Solution {
    public string MaximumNumber(string num, int[] change) {
        var sb = new StringBuilder();
        for(int i = 0; i < num.Length; i++){
            int temp = num[i] - '0';
            if(temp < change[temp]){
                int j = 0;
                for(j = i; j < num.Length; j++){
                    temp = num[j] - '0';
                    if(temp <= change[temp]) sb.Append(change[temp].ToString());
                    else break;
                }
                while(j < num.Length){
                    sb.Append(num[j]);
                    j++;
                }
                break;
            }
            else sb.Append(num[i]);
        }
        return sb.ToString();
    }
}