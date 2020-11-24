//https://leetcode.com/problems/uncommon-words-from-two-sentences/



public class Solution {
    public string[] UncommonFromSentences(string A, string B) {
        var rslt = new List<string>();
        string[] a = A.Split(' '), b = B.Split(' ');

        Dictionary<string, int> dict1 = new Dictionary<string, int>(), dict2 = new Dictionary<string, int>();
        
        for(int i = 0; i < a.Length || i < b.Length; i++){
            if(i < a.Length){
                if(!dict1.ContainsKey(a[i])) dict1.Add(a[i], 1);
                else dict1[a[i]]++;
            }
            if(i < b.Length){
                if(!dict2.ContainsKey(b[i])) dict2.Add(b[i], 1);
                else dict2[b[i]]++;
            }
        }
        foreach(var item in dict1)
            if(item.Value == 1 && !dict2.ContainsKey(item.Key)) rslt.Add(item.Key);

        foreach(var item in dict2)
            if(item.Value == 1 && !dict1.ContainsKey(item.Key)) rslt.Add(item.Key);

        
        return rslt.ToArray();
    }
}