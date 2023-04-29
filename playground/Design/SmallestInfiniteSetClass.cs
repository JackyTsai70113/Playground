namespace playground.Design;

public class SmallestInfiniteSetClass
{
    private int minNum;
    private readonly SortedSet<int> s;

    public SmallestInfiniteSetClass()
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