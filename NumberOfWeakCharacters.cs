//https://leetcode.com/problems/the-number-of-weak-characters-in-the-game/

public class Solution {
	
	//Using TreeMap. Time Limit Exceeded. I think this might be accepted if it is implemented in Java.
	public int NumberOfWeakCharacters(int[][] properties) {
        var sorted = new SortedDictionary<int, List<int>>();
        for(int i = 0; i < properties.Length; i++){
            if(sorted.ContainsKey(properties[i][0])) sorted[properties[i][0]].Add(i);
            else sorted.Add(properties[i][0], new List<int>(){i});
        }
        var keys = sorted.Keys.ToArray();
        int rs = 0;
        for(int i = keys.Length - 2; i >= 0; i--){
            foreach(var pos1 in sorted[keys[i]]){
                bool found = false;
                for(int j = i + 1; j < keys.Length && !found; j++){
                    foreach(var pos2 in sorted[keys[j]]){
                        if(properties[pos1][1] < properties[pos2][1]){
                            rs++;
                            found = true;
                            break;
                        }
                    }
                }
            }
        }
	}
	
	//O(nlogn) Accepted
    public int NumberOfWeakCharacters(int[][] properties) {
        var rs = 0;
        var sorted = properties.OrderBy(i => i[0]).ToArray();
        int currAtt = sorted[properties.Length - 1][0];
        int maxDef = -1;
        int currMaxDef = sorted[properties.Length - 1][1];
        for(int i = sorted.Length - 1; i >= 0; i--){
            if(sorted[i][0] != currAtt){
                currAtt = sorted[i][0];
                maxDef = Math.Max(maxDef, currMaxDef);
                currMaxDef = sorted[i][1];
            }
            if(sorted[i][1] < maxDef) rs++;
            currMaxDef = Math.Max(sorted[i][1], currMaxDef);
        }
        return rs;
    }
}