//https://leetcode.com/problems/roman-to-integer/


public class Solution {
    public int RomanToInt(string s) {
        var dict = new Dictionary<char,int>();
        dict.Add('I', 1);
        dict.Add('V', 5);
        dict.Add('X', 10);
        dict.Add('L', 50);
        dict.Add('C', 100);
        dict.Add('D', 500);
        dict.Add('M', 1000);
        if(s.Length == 1) return dict[s[0]];
        int sum = 0;
        for(int i = 0; i < s.Length - 1; i++){
            if(s[i] == 'I' && (s[i+1] == 'V' || s[i+1] == 'X')){
                sum += dict[s[i+1]] - dict['I'];
                i++; 
            }
            else if (s[i] == 'X' && (s[i+1] == 'L' || s[i+1] == 'C')){
                sum += dict[s[i+1]] - dict['X'];
                i++; 
            }
            else if (s[i] == 'C' && (s[i+1] == 'D' || s[i+1] == 'M')){
                sum += dict[s[i+1]] - dict['C'];
                i++;
            }
            else
                sum += dict[s[i]];
                
            if(i == s.Length - 2) sum += dict[s[i+1]];
        }
        return sum;
    }
}