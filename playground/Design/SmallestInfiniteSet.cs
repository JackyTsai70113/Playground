namespace playground.Design
{
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
                int temp = s.Min;
                _ = s.Remove(temp);
                return temp;
            }
            minNum++;
            return minNum - 1;
        }

        public void AddBack(int num)
        {
            if (minNum > num)
            {
                _ = s.Add(num);
            }
        }
    }
}