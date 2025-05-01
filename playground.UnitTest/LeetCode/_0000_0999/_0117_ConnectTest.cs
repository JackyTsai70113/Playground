using playground.LeetCode._0000_0999;
using static playground.LeetCode._0000_0999._0117_Connect;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0117_ConnectTest
{
    [Theory]
    [InlineData("[1,2,3,4,5,null,7]", "[1,#,2,3,#,4,5,7,#]")]
    [InlineData("[]", "[]")]
    public void Connect(string root, string expected)
    {
        var actual = _0117_Connect.Connect(ToNode(root));
        if (actual == null)
            Assert.Empty(expected.ToArr());
        else
            Assert.Equal(expected, actual.ToString());
    }

    private static Node ToNode(string str)
    {
        var arr = str.ToArr<int?>();
        if (arr.Length == 0) return null;
        var res = new Node(arr[0].Value);
        var q = new Queue<Node>();
        q.Enqueue(res);
        int j = 1;
        while (j < arr.Length)
        {
            var node = q.Dequeue();
            if (arr[j] != null)
            {
                node.left = new(arr[j].Value);
                q.Enqueue(node.left);
            }
            j++;
            if (j < arr.Length && arr[j] != null)
            {
                node.right = new(arr[j].Value);
                q.Enqueue(node.right);
            }
            j++;
        }
        return res;
    }
}