//https://leetcode.com/problems/the-number-of-the-smallest-unoccupied-chair/

public class Solution {
    public int SmallestChair(int[][] times, int targetFriend) {
        var arrivals = new Dictionary<int, int>();
        var leaveTimes = new Dictionary<int, List<int>>();
        for(int i = 0; i < times.Length; i++){
            arrivals.Add(times[i][0], i);
            if(leaveTimes.ContainsKey(times[i][1])) leaveTimes[times[i][1]].Add(i);
            else leaveTimes.Add(times[i][1], new List<int>(){i});
        }
        var chairs = new int[times.Length];
        for(int i = 0; i < chairs.Length; i++) chairs[i] = -1;
        int time = 1;
        while(true){
            if(leaveTimes.ContainsKey(time)){
                foreach(var item in leaveTimes[time]){
                    for(int i = 0; i < chairs.Length; i++)
                        if(chairs[i] == item)
                            chairs[i] = -1;
                }
            }
            if(arrivals.ContainsKey(time)){
                for(int i = 0; i < chairs.Length; i++){
                    if(chairs[i] == -1){
                        chairs[i] = arrivals[time];
                        if(arrivals[time] == targetFriend) return i;
                        break;
                    } 
                }
            }
            time++;
        }
        return 0;
    }
}