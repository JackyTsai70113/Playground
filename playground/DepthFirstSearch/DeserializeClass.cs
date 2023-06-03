namespace playground.DepthFirstSearch;

public class DeserializeClass
{
    /// <summary>
    /// https://leetcode.com/problems/mini-parser
    /// </summary>
    public static NestedInteger Deserialize(string s)
    {
        if (s[0] != '[')
            return new NestedInteger(int.Parse(s));
        var res = new NestedInteger();
        int l = 1, count = 1;
        for (int i = 1; i < s.Length - 1; ++i)
        {
            if (s[i] == '[')
            {
                count++;
            }
            else if (s[i] == ']')
            {
                count--;
            }
            else if (s[i] == ',')
            {
                if (count == 1)
                {
                    res.Add(Deserialize(s[l..i]));
                    l = i + 1;
                }
            }
        }
        if (l != s.Length - 1)
            res.Add(Deserialize(s[l..^1]));
        return res;
    }
}

// This is the interface that allows for creating nested lists.
// You should not implement it, or speculate about its implementation
interface INestedInteger
{

    // public NestedInteger(int value);

    // @return true if this NestedInteger holds a single integer, rather than a nested list.
    bool IsInteger();

    // @return the single integer that this NestedInteger holds, if it holds a single integer
    // Return null if this NestedInteger holds a nested list
    int? GetInteger();

    // Set this NestedInteger to hold a single integer.
    public void SetInteger(int value);

    /// <summary>
    /// Set this NestedInteger to hold a nested list and adds a nested integer to it.
    /// </summary>
    public void Add(NestedInteger ni);

    // @return the nested list that this NestedInteger holds, if it holds a nested list
    // Return null if this NestedInteger holds a single integer
    IList<NestedInteger> GetList();
}

public class NestedInteger : INestedInteger
{
    private int? value;

    private List<NestedInteger> nis;

    // Constructor initializes an empty nested list.
    public NestedInteger()
    {
    }

    // Constructor initializes a single integer.
    public NestedInteger(int value)
    {
        this.value = value;
    }

    /// <inheritdoc/>
    public void Add(NestedInteger ni)
    {
        nis ??= new();
        nis.Add(ni);
    }

    public int? GetInteger()
    {
        return value;
    }

    public IList<NestedInteger> GetList()
    {
        return nis;
    }

    public bool IsInteger()
    {
        return value != null;
    }

    public void SetInteger(int value)
    {
        this.value = value;
        this.nis = null;
    }
}
