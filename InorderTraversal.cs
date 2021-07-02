//https://leetcode.com/problems/binary-tree-inorder-traversal/


public class Solution {
    List<int> rs = new List<int>();
    public IList<int> InorderTraversal(TreeNode root) {
        traverse(root);
        return rs;
    }
    void traverse(TreeNode root){
        if(root != null){
            traverse(root.left);
            rs.Add(root.val);
            traverse(root.right);
        }
    }
}
//Iterative inorder traversal using Stack
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var rs = new List<int>();
        var stack = new Stack<TreeNode>();
        var curr = root;
        while(stack.Count != 0 || curr != null){
            while(curr != null){
                stack.Push(curr);
                curr = curr.left;
            }
            var node = stack.Pop();
            rs.Add(node.val);
            curr = node.right;
        }
        return rs;
    }
    
}