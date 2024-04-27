namespace playground;

public class LRUCache0146
{
    private readonly int _capacity;
    private readonly Dictionary<int, LinkedListNode<KeyValuePair<int, int>>> _cacheMap;
    private readonly LinkedList<KeyValuePair<int, int>> _cacheList;

    public LRUCache0146(int capacity)
    {
        _capacity = capacity;
        _cacheMap = new();
        _cacheList = new();
    }

    public int Get(int key)
    {
        if (_cacheMap.TryGetValue(key, out var node))
        {
            _cacheList.Remove(node);
            _cacheList.AddFirst(node);
            return node.Value.Value;
        }
        return -1;
    }

    public void Put(int key, int value)
    {
        if (_cacheMap.TryGetValue(key, out var node))
        {
            node.Value = new KeyValuePair<int, int>(key, value);
            _cacheList.Remove(node);
            _cacheList.AddFirst(node);
            return;
        }

        if (_cacheMap.Count == _capacity)
        {
            var lastNode = _cacheList.Last;
            _cacheMap.Remove(lastNode.Value.Key);
            _cacheList.RemoveLast();
        }
        var newKvp = new KeyValuePair<int, int>(key, value);
        var newNode = new LinkedListNode<KeyValuePair<int, int>>(newKvp);
        _cacheMap.Add(key, newNode);
        _cacheList.AddFirst(newNode);
    }
}
