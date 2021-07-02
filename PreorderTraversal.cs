//https://leetcode.com/problems/binary-tree-preorder-traversal/

public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> rs = new List<int>();
        var stack = new Stack<TreeNode>();
        var curr = root;
        while(stack.Count != 0 || curr != null){
            while(curr != null){
                stack.Push(curr);
                rs.Add(curr.val);
                curr = curr.left;
            }
            var node = stack.Pop();
            curr = node.right;
        }
        return rs;
    }
}