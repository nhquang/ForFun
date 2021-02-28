public class Solution {
    public bool BackspaceCompare(string S, string T) {
        var a = new Stack<char>();
        var b = new Stack<char>();
        for (int i = 0; i < S.Length; i++)
        {
            if (S[i] == '#' && a.Count > 0) a.Pop();
            else if (S[i] != '#') a.Push(S[i]);
        }
        for (int i = 0; i < T.Length; i++)
        {
            if (T[i] == '#' && b.Count > 0) b.Pop();
            else if(T[i] != '#') b.Push(T[i]);
        }
        if (a.Count != b.Count) return false;
        while(a.Count > 0)
            if (a.Pop() != b.Pop()) return false;

        return true;
    }
}