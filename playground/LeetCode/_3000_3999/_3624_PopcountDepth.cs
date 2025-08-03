namespace playground.LeetCode._3000_3999;

public class _3624_PopcountDepth
{
    public static int[] PopcountDepth(long[] nums, long[][] queries)
    {
        var segmentTree = new SegmentTreeNode(0, nums.Length - 1, nums);
        var result = new List<int>();
        foreach (var q in queries)
        {
            if (q[0] == 1)
            {
                var counts = segmentTree.Query((int)q[1], (int)q[2]);
                result.Add(counts[q[3]]);
            }
            else if (q[0] == 2)
            {
                nums[q[1]] = q[2];
                segmentTree.UpdateTree((int)q[1], q[2]);
            }
        }
        return result.ToArray();
    }

    private class SegmentTreeNode
    {
        public long start;
        public long end;
        public int[] depthCount = new int[7];
        public SegmentTreeNode left;
        public SegmentTreeNode right;

        /// <summary>
        /// TC: O(N)
        /// </summary>
        public SegmentTreeNode(int start, int end, long[] nums)
        {
            this.start = start;
            this.end = end;
            if (start == end)
            {
                int d = GetPopcountDepth(nums[start]);
                depthCount[d] = 1;
                return;
            }
            var mid = start + (end - start) / 2;
            left = new SegmentTreeNode(start, mid, nums);
            right = new SegmentTreeNode(mid + 1, end, nums);
            Merge();
        }

        /// <summary>
        /// TC: O(logN)
        /// </summary>
        public void UpdateTree(int index, long val)
        {
            if (index == start && index == end)
            {
                Array.Clear(depthCount, 0, depthCount.Length);
                int d = GetPopcountDepth(val);
                depthCount[d] = 1;
                return;
            }
            var mid = start + (end - start) / 2;
            if (index <= mid)
            {
                left.UpdateTree(index, val);
            }
            else
            {
                right.UpdateTree(index, val);
            }
            Merge();
        }

        public int[] Query(int start, int end)
        {
            if (start > end || start > this.end || end < this.start)
            {
                return new int[7];
            }
            if (start <= this.start && end >= this.end)
            {
                return (int[])depthCount.Clone();
            }
            var leftCount = left.Query(start, end);
            var rightCount = right.Query(start, end);
            var res = new int[7];
            for (int i = 0; i < 7; i++)
                res[i] = leftCount[i] + rightCount[i];
            return res;
        }

        private void Merge()
        {
            for (int i = 0; i < 7; i++)
                depthCount[i] = left.depthCount[i] + right.depthCount[i];
        }

        public static int GetPopcountDepth(long n)
        {
            int depth = 0;
            while (n > 1)
            {
                n = Popcount(n);
                depth++;
            }
            return depth;
        }

        private static int Popcount(long x)
        {
            int count = 0;
            while (x > 0)
            {
                count += (int)(x & 1);
                x >>= 1;
            }
            return count;
        }
    }
}