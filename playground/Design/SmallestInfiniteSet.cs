namespace playground.Design;

/// <summary>
/// https://leetcode.com/problems/smallest-number-in-infinite-set
/// </summary>
public class SmallestInfiniteSet
{
    private int minNum;
    private readonly SortedSet<int> s;

    public SmallestInfiniteSet()
    {
        minNum = 1;
        s = new();
    }

    public int? PopSmallest()
    {
        if (s.Count != 0)
        {
            var temp = s.Min();
            s.Remove(temp);
            return temp;
        }
        minNum++;
        return minNum - 1;
    }

    public void AddBack(int num)
    {
        if (minNum > num)
        {
            s.Add(num);
        }
    }
}