namespace playground;

public class MyLinkedList_0707
{
    Node _head;
    Node _tail;
    int _count;

    public MyLinkedList_0707()
    {
        _head = null;
        _tail = null;
        _count = 0;
    }

    /// <summary>
    /// Get the value of the indexth node in the linked list. If the index is invalid, return -1.
    /// </summary>
    public int Get(int index)
    {
        if (index >= _count)
            return -1;
        var res = _head;
        for (; index > 0; index--)
        {
            res = res.next;
        }
        return res.val;
    }

    /// <summary>
    /// Add a node of value val before the first element of the linked list.
    /// </summary>
    public void AddAtHead(int val)
    {
        var newNode = new Node(val);
        if (_count == 0)
        {
            _head = _tail = newNode;
        }
        else
        {
            newNode.next = _head;
            _head = newNode;
        }
        _count++;
    }

    /// <summary>
    /// Append a node of value val as the last element of the linked list.
    /// </summary>
    public void AddAtTail(int val)
    {
        var newNode = new Node(val);
        if (_count == 0)
        {
            _head = _tail = newNode;
        }
        else
        {
            _tail.next = newNode;
            _tail = newNode;
        }
        _count++;
    }

    /// <summary>
    /// Add a node of value val before the indexth node in the linked list.
    /// </summary>
    public void AddAtIndex(int index, int val)
    {
        if (index == 0)
        {
            AddAtHead(val);
            return;
        }
        if (index == _count)
        {
            AddAtTail(val);
            return;
        }
        if (index > _count)
            return;
        var pre = new Node(0, _head);
        for (int i = 0; i < index; ++i)
        {
            pre = pre.next;
        }
        pre.next = new Node(val, pre.next);
        _count++;
    }

    /// <summary>
    /// Delete the indexth node in the linked list, if the index is valid.
    /// </summary>
    public void DeleteAtIndex(int index)
    {
        if (index == 0)
        {
            _head = _head.next;
            _count--;
            return;
        }
        if (index >= _count)
            return;
        var pre = new Node(0, _head);
        for (int i = 0; i < index; ++i)
        {
            pre = pre.next;
        }
        pre.next = pre.next.next;
        if (index == _count - 1)
            _tail = pre;
        _count--;
    }

    private class Node
    {
        public int val;
        public Node next;
        public Node(int val = 0, Node next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
