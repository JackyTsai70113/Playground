namespace playground;

/// <summary>
/// https://leetcode.com/problems/range-sum-query-mutable
/// /// </summary>
public class NumArray0307
{
    SegmentTreeNode root;
    public NumArray0307(int[] nums)
    {
        root = new SegmentTreeNode(0, nums.Length - 1, nums);
    }

    public void Update(int index, int val)
    {
        root.Update(index, val);
    }

    public int SumRange(int left, int right)
    {
        return root.Query(left, right);
    }

    public class SegmentTreeNode
    {
        int start;
        int end;
        int val;
        SegmentTreeNode left;
        SegmentTreeNode right;
        public SegmentTreeNode(int start, int end, int[] nums)
        {
            this.start = start;
            this.end = end;
            if (start == end)
            {
                val = nums[start];
                return;
            }
            int mid = start + (end - start) / 2;
            left = new SegmentTreeNode(start, mid, nums);
            right = new SegmentTreeNode(mid + 1, end, nums);
            val = left.val + right.val;
        }

        public void Update(int index, int val)
        {
            if (index == start && index == end)
            {
                this.val = val;
                return;
            }
            int mid = start + (end - start) / 2;
            if (index <= mid)
                left.Update(index, val);
            else
                right.Update(index, val);
            this.val = left.val + right.val;
        }

        public int Query(int start, int end)
        {
            if (this.start == start && this.end == end)
            {
                return val;
            }
            int mid = this.start + (this.end - this.start) / 2;
            if (mid >= end)
            {
                return left.Query(start, end);
            }
            else if (mid < start)
            {
                return right.Query(start, end);
            }
            else
            {
                return left.Query(start, mid) + right.Query(mid + 1, end);
            }
        }
    }
}
