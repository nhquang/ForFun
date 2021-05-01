//https://leetcode.com/problems/group-the-people-given-the-group-size-they-belong-to/

public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        var dict = new Dictionary<int, List<int>>();
        for(int i = 0; i < groupSizes.Length; i++){
            if(dict.ContainsKey(groupSizes[i])) dict[groupSizes[i]].Add(i);
            else dict.Add(groupSizes[i], new List<int>(){ i });
        }
        var rslt = new List<List<int>>();
        foreach(var item in dict){
            if(item.Value.Count == item.Key) rslt.Add(item.Value);
            else{
                int temp = item.Value.Count / item.Key, count = 0;
                for(int i = 0; i < temp; i++){
                    var l = new List<int>();
                    for(int j = 0; j < item.Key; j++){
                        l.Add(item.Value[count]);
                        count++;
                    }
                    rslt.Add(l);
                }
            }
        }
        return rslt.ToArray();
    }
}