namespace playground;

public class SegmentTreeNode
{
    public int start;
    public int end;
    public int sum; // can be sum, max, min
    public SegmentTreeNode left;
    public SegmentTreeNode right;

    /// <summary>
    /// TC: O(N)
    /// </summary>
    public SegmentTreeNode(int start, int end, int[] nums)
    {
        this.start = start;
        this.end = end;
        if (start == end)
        {
            this.sum = nums[start];
            return;
        }
        var mid = start + (end - start) / 2;
        this.left = left = new SegmentTreeNode(start, mid, nums);
        this.right = new SegmentTreeNode(mid + 1, end, nums);
        this.sum = left.sum + right.sum;
    }

    /// <summary>
    /// TC: O(logN)
    /// </summary>
    public void UpdateTree(int index, int val)
    {
        if (index == start && index == end)
        {
            sum = val;
            return;
        }
        var mid = start + (end - start) / 2;
        if (index <= mid)
            left.UpdateTree(index, val);
        else
            right.UpdateTree(index, val);
        sum = left.sum + right.sum;
    }

    /// <summary>
    /// TC: O(logN+k), k: 訪問的節點數量
    /// </summary>
    public int GetSum(int start, int end)
    {
        if (start == this.start && end == this.end)
            return sum;
        var mid = this.start + (this.end - this.start) / 2;
        if (end <= mid)
            return left.GetSum(start, end);
        else if (start > mid)
            return right.GetSum(start, end);
        else
            return left.GetSum(start, mid) + right.GetSum(mid + 1, end);
    }
}