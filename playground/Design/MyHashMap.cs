namespace playground.Design;

public class Node
{
    public int Key;
    public int Val;
    public Node Next;
    public Node(int key, int val)
    {
        Key = key;
        Val = val;
    }
}

/// <summary>
/// https://leetcode.com/problems/design-hashmap/
/// </summary>
public class MyHashMap
{
    readonly Node[] nodes;
    public MyHashMap()
    {
        nodes = new Node[1000];
    }

    public void Put(int key, int value)
    {
        int hash = GetHash(key);
        if (nodes[hash] == null)
        {
            nodes[hash] = new Node(key, value);
            return;
        }
        Node cur = nodes[hash], pre = null;
        while (cur != null)
        {
            if (cur.Key == key)
            {
                cur.Val = value;
                return;
            }
            pre = cur;
            cur = cur.Next;
        }
        pre.Next = new Node(key, value);
    }

    public int Get(int key)
    {
        int hash = GetHash(key);
        Node cur = nodes[hash];
        while (cur != null)
        {
            if (cur.Key == key)
            {
                return cur.Val;
            }
            cur = cur.Next;
        }
        return -1;
    }

    public void Remove(int key)
    {
        int hash = GetHash(key);
        if (nodes[hash] == null) return;
        if (nodes[hash].Key == key)
        {
            nodes[hash] = nodes[hash].Next;
            return;
        }

        Node cur = nodes[hash];
        while (cur.Next != null)
        {
            if (cur.Next.Key == key)
            {
                cur.Next = cur.Next.Next;
                break;
            }
            cur = cur.Next;
        }
    }

    private static int GetHash(int key) =>
        key % 1000;
}