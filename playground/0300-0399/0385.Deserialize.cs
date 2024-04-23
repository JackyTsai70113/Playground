namespace playground;

public class Deserialize0385
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

/// <summary>
/// This is the interface that allows for creating nested lists.
/// </summary>
interface INestedInteger
{
    /// <summary>
    /// return true if this NestedInteger holds a single integer, rather than a nested list.
    /// </summary>
    bool IsInteger();

    /// <summary>
    /// return the single integer that this NestedInteger holds, if it holds a single integer
    /// </summary>
    /// <remarks>
    /// Return null if this NestedInteger holds a nested list
    /// </remarks>
    int? GetInteger();

    /// <summary>
    /// Set this NestedInteger to hold a single integer.
    /// </summary>
    void SetInteger(int val);

    /// <summary>
    /// Set this NestedInteger to hold a nested list and adds a nested integer to it.
    /// </summary>
    void Add(NestedInteger ni);

    /// <summary>
    /// return the nested list that this NestedInteger holds, if it holds a nested list
    /// </summary>
    /// <remarks>
    /// return null if this NestedInteger holds a single integer
    /// </remarks>
    IList<NestedInteger> GetList();
}

public class NestedInteger : INestedInteger
{
    private int? value;

    private List<NestedInteger> nis;

    /// <summary>
    /// Constructor initializes an empty nested list.
    /// </summary>
    public NestedInteger()
    {
    }

    /// <summary>
    /// Constructor initializes a single integer.
    /// </summary>
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

    /// <inheritdoc/>
    public int? GetInteger()
    {
        return value;
    }

    /// <inheritdoc/>
    public IList<NestedInteger> GetList()
    {
        return nis;
    }

    /// <inheritdoc/>
    public bool IsInteger()
    {
        return value != null;
    }

    /// <inheritdoc/>
    public void SetInteger(int val)
    {
        value = val;
        nis = null;
    }
}
