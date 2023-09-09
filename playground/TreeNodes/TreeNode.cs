namespace playground.TreeNodes;

public class TreeNode<T> where T : unmanaged
{
    private T value = default;

    private readonly Dictionary<int, TreeNode<T>> children = new();

    public TreeNode(T value = default)
    {
        value = default;
    }

    public bool TrySearch(IEnumerable<int> routes, out T value)
    {
        value = default;
        var cur = this;
        foreach (var route in routes)
        {
            if (!cur.HasChild(route))
                return false;
            cur = cur.GetChild(route);
        }
        value = cur.GetValue();
        return true;
    }

    public void AddChild(int childIndex, T value = default)
    {
        children[childIndex] = new TreeNode<T>(value);
    }

    public bool HasChild(int childIndex)
    {
        return children.ContainsKey(childIndex);
    }

    public bool TryGetChild(int childIndex, out TreeNode<T> child)
    {
        if (children.ContainsKey(childIndex))
        {
            child = children[childIndex];
            return true;
        }
        else
        {
            child = default;
            return false;
        }
    }

    public TreeNode<T> GetChild(int childIndex)
    {
        return children.ContainsKey(childIndex) ? children[childIndex] : null;
    }

    public T GetValue()
    {
        return value;
    }

    public void SetValue(T value)
    {
        this.value = value;
    }
}