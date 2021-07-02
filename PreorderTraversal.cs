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
//recursive
public class Solution {
    List<int> rs = new List<int>();
    public IList<int> PreorderTraversal(TreeNode root) {
        traverse(root);
        return rs;
    }
    void traverse(TreeNode root){
        if(root != null){
            rs.Add(root.val);
            traverse(root.left);
            traverse(root.right);
        }
    }
}