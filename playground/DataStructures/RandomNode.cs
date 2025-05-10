using System.Text;

namespace playground.DataStructures;

public class RandomNode
{
    public int val;
    public RandomNode next;
    public RandomNode random;
    public RandomNode(int val = 0, RandomNode next = null, RandomNode random = null)
    {
        this.val = val;
        this.next = next;
        this.random = random;
    }

    public override string ToString()
    {
        Dictionary<RandomNode, int> dict = new();
        var cur = this;
        int i = 0;
        while (cur != null)
        {
            dict[cur] = i;
            i++;
            cur = cur.next;
        }
        var sb = new StringBuilder();
        sb.Append("[[" + val + ",");
        if (random == null)
            sb.Append("null");
        else
            sb.Append(dict[random]);
        sb.Append(']');
        cur = next;
        while (cur != null)
        {
            sb.Append(",[" + cur.val + ',');
            if (cur.random == null)
                sb.Append("null");
            else
                sb.Append(dict[cur.random]);
            sb.Append(']');
            cur = cur.next;
        }
        sb.Append(']');
        return sb.ToString();
    }
}