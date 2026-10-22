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

public class Solution {    
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root == null && subRoot != null) return false;
        if(root != null && subRoot == null) return true;

        if(IsSameTree(root,subRoot)){
            return true;
        }
        return IsSubtree(root.left,subRoot) || IsSubtree(root.right,subRoot);
    }

    public bool IsSameTree(TreeNode t1, TreeNode t2){
        if(t1 == null && t2 == null) return true;
        if(t1 == null || t2 == null || t1.val != t2.val) return false;

        return IsSameTree(t1.left,t2.left) && IsSameTree(t1.right,t2.right);
    }
}
