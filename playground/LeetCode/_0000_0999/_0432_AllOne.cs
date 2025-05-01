namespace playground.LeetCode._0000_0999;

public class _0432_AllOne
{
    LinkedList first;
    LinkedList last;
    readonly Dictionary<string, LinkedList> strCount;
    public _0432_AllOne()
    {
        strCount = new();
    }

    public void Inc(string key)
    {
        if (strCount.ContainsKey(key))
        {
            var node = strCount[key];

            // move key to next node
            if (node.next != null && node.next.count == node.count + 1)
            {
                node.next.strs.Add(key);
                strCount[key] = node.next;
            }
            else
            {
                var newNode = new LinkedList(node.count + 1, key);
                AddAfter(node, newNode);
                strCount[key] = newNode;
            }

            RemoveStrFromNode(node, key);
        }
        else
        {
            // insert key with count == 1
            if (first == null)
            {
                LinkedList newNode = new LinkedList(1, key);
                first = newNode;
                last = newNode;
                strCount[key] = newNode;
            }
            else if (first.count == 1)
            {
                first.strs.Add(key);
                strCount[key] = first;
            }
            else
            {
                LinkedList newNode = new LinkedList(1, key);
                AddBefore(first, newNode);
                strCount[key] = newNode;
            }
        }
    }

    public void Dec(string key)
    {
        var node = strCount[key];

        // move key to prev node
        if (node.prev != null && node.prev.count == node.count - 1)
        {
            node.prev.strs.Add(key);
            strCount[key] = node.prev;
        }
        else if (node.count == 1)
        {
            strCount.Remove(key);
        }
        else
        {
            var newNode = new LinkedList(node.count - 1, key);
            AddBefore(node, newNode);
            strCount[key] = newNode;
        }
        RemoveStrFromNode(node, key);
    }

    public string GetMaxKey()
    {
        return last == null ? string.Empty : last.strs.First();
    }

    public string GetMinKey()
    {
        return first == null ? string.Empty : first.strs.First();
    }

    private void AddAfter(LinkedList node, LinkedList newNode)
    {
        newNode.prev = node;
        newNode.next = node.next;
        if (node.next != null)
            node.next.prev = newNode;
        node.next = newNode;
        if (node == last)
            last = newNode;
    }

    private void AddBefore(LinkedList node, LinkedList newNode)
    {
        newNode.prev = node.prev;
        newNode.next = node;
        if (node.prev != null)
            node.prev.next = newNode;
        node.prev = newNode;
        if (node == first)
            first = newNode;
    }

    private void RemoveStrFromNode(LinkedList node, string str)
    {
        node.strs.Remove(str);
        if (!node.strs.Any())
            Remove(node);
    }

    private void Remove(LinkedList node)
    {
        if (node.prev != null)
            node.prev.next = node.next;
        if (node.next != null)
            node.next.prev = node.prev;
        if (node == first)
            first = node.next;
        if (node == last)
            last = node.prev;
    }

    public class LinkedList
    {
        public int count;
        public HashSet<string> strs;
        public LinkedList prev;
        public LinkedList next;
        public LinkedList(int count, string str, LinkedList prev = null, LinkedList next = null)
        {
            this.count = count;
            strs = new HashSet<string> { str };
            this.prev = prev;
            this.next = next;
        }
    }
}
