using System.Text;

namespace playground;

public class PrintLinkedListClass
{
    /// <summary>
    /// 已知 S_0 = 'ABC', S_n = 'A' + S_n-1 + 'B' + S_n-1 + 'C'
    /// 試印出 S_50 的前 100 個字元
    /// => 試印出 S_n 的前 k 個字元
    /// </summary>
    public static string PrintLinkedList(int n, int k)
    {
        Node[] heads = new Node[n + 1], tails = new Node[n + 1];

        Node c = new('C', null, null, true);
        Node b = new('B', c, c, true);
        Node a = new('A', b, b, true);
        heads[0] = a;
        tails[0] = c;

        for (int i = 1; i <= n; ++i)
        {
            c = new('C', null, null, true);
            b = new('B', heads[i - 1], heads[i - 1], true);
            a = new('A', heads[i - 1], heads[i - 1], true);
            tails[i - 1].first = b;
            tails[i - 1].second = c;

            heads[i] = a;
            tails[i] = c;
        }

        var cur = heads[^1];
        StringBuilder sb = new();
        for (int i = 0; i < k && cur != null; i++)
        {
            sb.Append(cur.data);
            cur.firstTime = !cur.firstTime;
            if (!cur.firstTime)
            {
                cur = cur.first;
            }
            else
            {
                cur = cur.second;
            }
        }
        return sb.ToString();
    }

    class Node
    {
        public char data;
        public Node first;
        public Node second;
        public bool firstTime;
        public Node(char data, Node first, Node second, bool firstTime)
        {
            this.data = data;
            this.first = first;
            this.second = second;
            this.firstTime = firstTime;
        }
    }
}
