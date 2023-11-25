namespace playground;

public class Sort
{
    /// <summary>
    /// 插入演算法 Insertion Sort: O(N^2)/O(1)
    /// </summary>
    /// <remarks>
    /// | --j--- | ---i---- | <br/>
    /// | sorted | unsorted | <br/>
    /// i 為未排序組的第一個元素 X 的索引值，j 為已排序組的尾端元素 Y 的索引值，
    /// 如果 Y 大於  X 則把 Y 往後移一格，不斷重複至所有在已排序組中大於 X 的資料都往後移為止，
    /// 最後將 j+1 設定為 X。
    /// </remarks>
    public static void InsertionSort(int[] nums, int n)
    {
        for (int i = 1; i < n; i++)
        {
            int value = nums[i];
            int j = i - 1;
            while (j >= 0 && nums[j] > value)
            {
                nums[j + 1] = nums[j];
                j--;
            }
            nums[j + 1] = value;
        }
    }

    /// <summary>
    /// 謝爾演算法 Shell Sort: O(N^2)/O(1)
    /// </summary>
    /// <remarks>
    /// 讓 gap 從 n / 2 開始，也就是讓每一組資料個數從 2 開始逐步處理，
    /// 分組完後分別對組內做插入排序法，直至最後一次進行所有資料的插入排序法為止。 
    /// </remarks>
    public static void ShellSort(int[] nums, int n)
    {
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            // 透過現在的 gap 對組內元素進行插入排序法
            for (int offset = 0; offset < gap; offset++)
            {
                for (int i = offset; i < n; i += gap)
                {
                    int value = nums[i];
                    int j = i - gap;
                    while (j >= 0 && nums[j] > value)
                    {
                        nums[j + gap] = nums[j];
                        j -= gap;
                    }
                    nums[j + gap] = value;
                }
            }
        }
    }

    /// <summary>
    /// 選擇排序法 Selection Sort: O(N^2)/O(1)
    /// </summary>
    /// <remarks>
    /// 自未排序好的資料中挑出最小值放到第一個，
    /// 放完後已排序資料加一，未排序資料減一，
    /// 依序做到未排序資料沒有為止。
    /// </remarks>
    public static void SelectionSort(int[] nums, int n)
    {
        for (int i = 0; i < n - 1; ++i)
        {
            int mini = i;
            for (int j = i + 1; j < n; j++)
            {
                if (nums[mini] > nums[j])
                    mini = j;
            }
            (nums[i], nums[mini]) = (nums[mini], nums[i]);
        }
    }

    /// <summary>
    /// 冒泡排序法 Bubble Sort: O(N^2)/O(1)
    /// </summary>
    /// <remarks>
    /// 兩兩比較，調整順序，每一次至少有一筆「最小/最大資料」會移到正確的位置上。
    /// </remarks>
    public static void BubbleSort(int[] nums, int n)
    {
        for (int i = 0; i < n - 1; ++i)
        {
            for (int j = 0; j < n - i - 1; ++j)
            {
                if (nums[j] > nums[j + 1])
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
            }
        }
    }

    /// <summary>
    /// 雙向冒泡排序法 Shaker Sort: O(N^2)/O(1)
    /// </summary>
    /// <remarks>
    /// 在冒泡排序法的基礎上，紀錄最後互換的位置，避免重複運算，
    /// 為了避免已排序好的區塊恰好在陣列的左邊或右邊，
    /// 每一輪的 bubble sort 會分別從左到右，從右到左各做一次。
    /// </remarks>
    public static void ShakerSort(int[] nums, int n)
    {
        int left = 0, right = n - 1;
        int shift = 0; // 最後互換的位置
        while (left < right)
        {
            for (int i = left; i < right; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
                    shift = i;
                }
            }
            right = shift;
            for (int i = right - 1; i >= left; i--)
            {
                if (nums[i] > nums[i + 1])
                {
                    (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
                    shift = i;
                }
            }
            left = shift;
        }
    }

    /// <summary>
    /// 合併排序法 Merge Sort: O(NlogN)/O(N)
    /// </summary>
    /// <remarks>
    /// 將資料分成左右兩組，直至每組只剩一筆資料，
    /// 接著兩組兩組「融合 Merge」在一起，直至融合成整個陣列。
    /// </remarks>
    public static void MergeSort(int[] nums, int n)
    {
        MergeSort(nums, 0, n - 1);
    }

    public static void MergeSort(int[] nums, int left, int right)
    {
        if (left >= right) return;
        int mid = left + (right - left) / 2;
        MergeSort(nums, 0, mid);
        MergeSort(nums, mid + 1, right);
        Merge(nums, left, right);
    }

    public static void Merge(int[] nums, int left, int right)
    {
        int mid = left + (right - left) / 2;
        int idx = left, i = left, j = mid + 1;
        var nums2 = new int[nums.Length]; // 需要額外的 O(N) 空間
        Array.Copy(nums, nums2, nums.Length);
        while (i <= mid || j <= right)
        {
            var a = i <= mid ? nums2[i] : int.MaxValue;
            var b = j <= right ? nums2[j] : int.MaxValue;
            nums[idx++] = a < b ? nums2[i++] : nums2[j++];
        }
    }
}
