namespace playground;
public class TrieNode<T>
{
    public T val = default;

    public readonly TrieNode<T>[] children;

    public TrieNode(T val, TrieNode<T>[] children)
    {
        this.val = val;
        this.children = children;
    }
}