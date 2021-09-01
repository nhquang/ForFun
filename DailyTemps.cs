//https://leetcode.com/problems/daily-temperatures/

public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var dict= new Dictionary<int, List<int>>();
        for(int i = 0; i < temperatures.Length; i++){
            foreach(var item in dict){
                if(temperatures[i] > item.Key){
                    foreach(var idx in item.Value)
                        temperatures[idx] = i - idx;
                    item.Value.Clear();
                }
            }
            if(dict.ContainsKey(temperatures[i])) dict[temperatures[i]].Add(i);
            else dict.Add(temperatures[i], new List<int>(){i});
        }
        foreach(var item in dict){
            if(item.Value.Count > 0){
                foreach(var idx in item.Value)
                    temperatures[idx] = 0;
            }
        }
        return temperatures;
    }
}