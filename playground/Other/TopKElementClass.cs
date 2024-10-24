namespace playground.Other;

public class TopKElementClass
{
    /*
        需求:
            
        算法需求:
            從多個已由小排到大的陣列之中，找出前k個不重複由小排到大的元素
    */
    /// <summary>
    /// 從多個已排序的陣列中，找出前 K 個不重複的最小元素。具體來說，
    /// 1.會在多個已排序陣列中進行合併，
    /// 2. 並且保持一個「最小堆」（Priority Queue）來逐步取出最小的元素
    /// 3. 同時過濾掉重複的元素，直到取得了 K 個不重複的元素為止。
    /// 典型的合併排序問題，且使用了優先隊列（最小堆）來保持合併過程的效率。
    /// 
    /// 
    /// 這段程式碼可以用來解決從多個排序資料集中找出前K個不重複的最小值的問題。這在很多情況下都有用，比如：
    /// 推薦系統：從多個來源（排序後的推薦項目列表）中，選擇前 K 個不重複的推薦項目。
    /// 資料處理：合併多個已排序的資料集，找出前 K 個不重複的值，這在合併搜尋結果或排名結果時會用到。
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    /// <remarks>
    /// 時間複雜度: O(nlogk+klogk) : n 是2維陣列數量
    /// 空間複雜度: O(k)
    /// </remarks>
    public static IList<int> TopKElement(int[][] arr, int k)
    {
        // 用於儲存已經處理過的數字，避免重複添加
        HashSet<int> existedNumbers = new();

        // 優先隊列 (最小堆)，每個元素包含兩個值：陣列的索引和該陣列中的元素索引，並根據元素的數值進行排序
        PriorityQueue<int, long> reverseChannelEntityPq = new();

        // 優先隊列 (最小堆)，每個元素包含兩個值：陣列的索引和該陣列中的元素索引，並根據元素的數值進行排序
        PriorityQueue<(int channelEntityListIndex, int channelEntityIndex), long> channelEntityPq = new();

        // 將每個陣列的第一個元素加入優先隊列
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length > 0)
            {
                reverseChannelEntityPq.Enqueue(i, -arr[i][0]); // logk
                if (reverseChannelEntityPq.Count > k)
                {
                    reverseChannelEntityPq.Dequeue();
                }
            }
        } // nlogk

        while (reverseChannelEntityPq.Count > 0)
        {
            int index = reverseChannelEntityPq.Dequeue();
            channelEntityPq.Enqueue((index, 0), arr[index][0]);
        }

        // 存儲結果的清單，保存最多 k 個不重複的數字
        var res = new List<int>();

        // 當結果數量少於 k 且優先隊列非空時，繼續處理
        while (res.Count < k && channelEntityPq.Count > 0)
        {
            // 從優先隊列中取出當前數值最小的元素
            var (arr_i, arr_j) = channelEntityPq.Dequeue(); // logk

            // 取得當前元素
            var currentNumber = arr[arr_i][arr_j];

            // 如果當前數字未出現過，將其加入結果清單
            if (existedNumbers.Add(currentNumber))
            {
                res.Add(currentNumber);
            }

            // 如果當前數字的下一個元素存在，將其加入優先隊列
            if (arr_j + 1 < arr[arr_i].Length)
            {
                var nextNumber = arr[arr_i][arr_j + 1];
                channelEntityPq.Enqueue((arr_i, arr_j + 1), nextNumber); // logk
            }
        } // klogk

        // 返回結果清單
        return res;
    }

    /// <summary>
    /// 這段程式碼的功能是從多個陣列中取得前 K 個元素（按大小排序且無重複），具體來說，該程式碼會先從每個陣列中最多取出 K 個元素，將其合併後進行去重與排序，最後返回前 K 個不重複的最小值。
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    /// <remarks>
    /// 時間複雜度: O(nklog(nk)) : m 是所有陣列中的總元素數
    /// 空間複雜度: O(nk)
    /// </remarks>
    public static IList<int> TopKElement2(int[][] arr, int k)
    {
        // 用於追蹤已經出現過的數字，避免重複
        HashSet<int> existedNumbers = new();

        // 初始化一個結果清單，用來儲存所有數字
        var res = new List<int>();

        // 將每個陣列中的所有元素展開並加入結果清單
        foreach (var nums in arr)
        {
            res.AddRange(nums.Take(k)); // 只取每個陣列的前 k 個元素
        }

        // 將結果中的所有數字去重並排序，返回一個新的排序後的清單
        return res.Distinct()   // 去除重複元素
                  .OrderBy(num => num)  // 按照數字大小排序
                  .Take(k) // 取 k 個數字
                  .ToList();  // 返回排序後的清單
    }
}
