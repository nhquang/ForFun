//https://leetcode.com/problems/number-of-students-unable-to-eat-lunch/


public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        var studs = new Queue<int>();
        var sands = new Stack<int>();
        foreach(var item in students){
            studs.Enqueue(item);
        }
        for(int i = sandwiches.Length - 1; i >= 0; i--){
            sands.Push(sandwiches[i]);
        }
        while(sands.Count > 0 && studs.Count > 0){
            var stud = studs.Dequeue();
            if(stud == sands.Peek()){
                sands.Pop();
            }
            else {
                studs.Enqueue(stud);
                if(!studs.Contains(sands.Peek())) break;
            }
        }
        return studs.Count;
    }
}