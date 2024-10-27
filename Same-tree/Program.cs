/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        // Base cases
        if (p == null && q == null) return true;  // Both trees are empty
        if (p == null || q == null) return false; // One tree is empty, the other is not
        if (p.val != q.val) return false;         // Node values differ

        // Recursively check left and right subtrees
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}