namespace playground.TreeNode;

public class WidthOfBinaryTreeClass
{
    public static int WidthOfBinaryTree(TreeNode? root)
    {
        var q = new Queue<(TreeNode? node, int idx)>();
        q.Enqueue((root, 0));
        int res = 1;
        while (q.Count > 0)
        {
            while(q.Count>0)
            {
                var (node, idx) = q.Dequeue();
                if (node != null){
                    q.Enqueue((node.left, 2 * idx));
                    q.Enqueue((node.right, 2 * idx + 1));
                    
                } else {

                }
            }
        }
        return res;
    }
}
