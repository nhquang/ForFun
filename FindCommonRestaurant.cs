//https://leetcode.com/problems/minimum-index-sum-of-two-lists/

public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        var dict1 = new Dictionary<string, int>();
        var dict2 = new Dictionary<string, int>();
        for(int i = 0; i < list1.Length || i < list2.Length; i++){
            if(i < list1.Length && !dict1.ContainsKey(list1[i])) dict1.Add(list1[i], i);
            if(i < list2.Length && !dict2.ContainsKey(list2[i])) dict2.Add(list2[i], i);
        }
        int min = int.MaxValue;
        var rslt = new List<string>();
        foreach(var item in dict1){
            if(dict2.ContainsKey(item.Key)){
                if((item.Value + dict2[item.Key]) == min) rslt.Add(item.Key);
                else if (item.Value + dict2[item.Key] < min){
                    rslt.Clear();
                    rslt.Add(item.Key);
                    min = item.Value + dict2[item.Key];
                }
            }
        }
        return rslt.ToArray();
        
    }
}