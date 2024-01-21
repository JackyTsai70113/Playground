namespace playground;

public class MonotonicStacks
{
    /// <summary>
    /// 取得之前比自己值還小的 index。
    /// </summary>
    /// <remarks>
    /// stack 存放 index 有很多好處，其中之一就是可以算和 target 的差距。
    /// 如果 stack 為空 則填入 -1，也是有利計算差距。
    /// </remarks>
    /// <returns>Previous Less Index</returns>
    public static int[] GetPreviousLessIndex(int[] nums)
    {
        int[] pli = new int[nums.Length];
        Stack<int> st = new();
        for (int i = 0; i < nums.Length; ++i)
        {
            while (st.Count > 0 && nums[st.Peek()] > nums[i])
                st.Pop();
            pli[i] = st.Count == 0 ? -1 : st.Peek();
            st.Push(i);
        }
        return pli;
    }

    /// <summary>
    /// 取得之後比自己值還小的 index。
    /// </summary>
    /// <remarks>
    /// code snippet 一樣，只是 for 反過來尋找
    /// 如果 stack 為空則填入 nums.Length
    /// </remarks>
    /// <returns>Next Less Index</returns>
    public static int[] GetNextLessIndex(int[] nums)
    {
        int[] nli = new int[nums.Length];
        Stack<int> st = new();
        for (int i = nums.Length - 1; i >= 0; --i)
        {
            while (st.Count > 0 && nums[st.Peek()] > nums[i])
                st.Pop();
            nli[i] = st.Count == 0 ? nums.Length : st.Peek();
            st.Push(i);
        }
        return nli;
    }

    /// <summary>
    /// 取得之後比自己值還小的 index。
    /// </summary>
    /// <remarks>
    /// 另一種寫法，如果沒辦法從後面走訪數列的話
    /// </remarks>
    /// <returns>Next Less Index</returns>
    public static int[] GetNextLessIndex2(int[] nums)
    {
        int[] nli = new int[nums.Length];
        Array.Fill(nli, nums.Length);
        Stack<int> st = new();
        for (int i = 0; i < nums.Length; ++i)
        {
            while (st.Count > 0 && nums[st.Peek()] > nums[i])
                nli[st.Pop()] = i;
            st.Push(i);
        }
        return nli;
    }

    /// <summary>
    /// 取得往前看的最大值 index
    /// </summary>
    /// <returns>Backward Max Index</returns>
    public static int[] GetBackwardMaxIndex(int[] nums)
    {
        int[] backwardMaxIndex = new int[nums.Length]; // index
        Stack<int> st = new(); // index
        for (int i = 0; i < nums.Length; ++i)
        {
            // stack 中比目前的值還小就丟掉，因為接下來的 index 只會看到這個
            while (st.Count > 0 && nums[i] >= nums[st.Peek()])
                st.Pop();
            if (st.Count == 0) st.Push(i); // 如果沒了就是看到自己
            backwardMaxIndex[i] = st.Peek();
        }
        return backwardMaxIndex;
    }

    /// <summary>
    /// 取得往前看的最大值 index
    /// </summary>
    /// <remarks>
    /// 另一種寫法，不使用 Stack
    /// </remarks>
    /// <returns>Backward Max Index</returns>
    public static int[] GetBackwardMaxIndex2(int[] nums)
    {
        int maxi = -1;
        int[] backwardMaxIndex = new int[nums.Length];
        for (int i = 0; i < nums.Length; ++i)
        {
            if (maxi == -1 || nums[i] >= nums[maxi])
                maxi = i;
            backwardMaxIndex[i] = maxi;
        }
        return backwardMaxIndex;
    }

    /// <summary>
    /// 取得往後看的最大值 index
    /// </summary>
    /// <returns>Forward Max Index</returns>
    public static int[] GetForwardMaxIndex(int[] nums)
    {
        int[] forwardMaxIndex = new int[nums.Length]; // index
        Stack<int> st = new(); // index
        for (int i = nums.Length - 1; i >= 0; --i)
        {
            while (st.Count > 0 && nums[i] >= nums[st.Peek()])
                st.Pop();
            if (st.Count == 0) st.Push(i); // 如果沒了就是看到自己
            forwardMaxIndex[i] = st.Peek();
        }
        return forwardMaxIndex;
    }

    /// <summary>
    /// 取得往後看的最大值 index
    /// </summary>
    /// <remarks>
    /// 另一種寫法，不使用 Stack
    /// </remarks>
    /// <returns>Forward Max Index</returns>
    public static int[] GetForwardMaxIndex2(int[] nums)
    {
        int maxi = -1;
        int[] forwardMaxIndex = new int[nums.Length];
        for (int i = nums.Length - 1; i >= 0; --i)
        {
            if (maxi == -1 || nums[i] >= nums[maxi])
                maxi = i;
            forwardMaxIndex[i] = maxi;
        }
        return forwardMaxIndex;
    }

    /// <summary>
    /// 找出以第i個位置的山峰或是山谷
    /// </summary>
    /// <remarks>
    /// 用前面的找出前面和後面比自己高或是比自己低的位置。</br>
    /// 如果左右邊都應用的話，就是找出以第i個位置的山峰或是山谷。
    /// </remarks>
    /// <returns>Local Minimal Subarray</returns>
    public static int[] GetLocalMinimalSubarray(int[] nums, int index)
    {
        var left = GetPreviousLessIndex(nums);
        var right = GetNextLessIndex(nums);
        return new int[] { left[index] + 1, right[index] - 1 };
    }
}
