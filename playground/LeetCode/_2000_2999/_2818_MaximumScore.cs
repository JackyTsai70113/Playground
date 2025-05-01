using System.Numerics;

namespace playground.LeetCode._2000_2999;

public class _2818_MaximumScore
{
    private const long MOD = 1_000_000_007;
    public static int MaximumScore(IList<int> nums, int k)
    {
        int n = nums.Count;

        // Step 1: 預處理 - 每個數字對應的「質因數數量」作為權重
        var primeScore = GetPrimeScores(nums);

        // Step 2: 建立單調堆疊 - 計算每個位置作為最大值的次數
        var leftBounds = GetLeftBounds(nums, primeScore);
        var rightBounds = GetRightBounds(nums, primeScore);

        // Step 3: 計算每個元素可貢獻多少次乘積
        var contributionCounts = new long[n];
        for (int i = 0; i < n; i++)
        {
            contributionCounts[i] = (long)(i - leftBounds[i]) * (rightBounds[i] - i);
        }

        // Step 4: 按照數字大小從大到小進行選取
        var maxHeap = new PriorityQueue<int, int>();
        for (int i = 0; i < n; i++)
        {
            maxHeap.Enqueue(i, -nums[i]); // 使用 -value 模擬 MaxHeap
        }

        long result = 1;
        while (k > 0 && maxHeap.Count > 0)
        {
            int idx = maxHeap.Dequeue();
            int use = (int)Math.Min(k, contributionCounts[idx]);
            result = result * (long)BigInteger.ModPow(nums[idx], use, MOD) % MOD;
            k -= use;
        }

        return (int)result;

    }

    public static Dictionary<int, int> GetPrimeScores(IList<int> nums)
    {
        var max = nums.Max();
        var score = nums.Distinct().ToDictionary(num => num, _ => 0);
        var isPrime = new bool[max + 1];
        Array.Fill(isPrime, true);

        for (int i = 2; i <= max; i++)
        {
            if (!isPrime[i]) continue;

            for (int j = i; j <= max; j += i)
            {
                if (i != j)
                {
                    isPrime[j] = false;
                }
                if (score.ContainsKey(j))
                {
                    score[j]++;
                }
            }
        }

        return score;
    }

    private static int[] GetLeftBounds(IList<int> nums, Dictionary<int, int> primeScore)
    {
        int n = nums.Count;
        var stack = new Stack<int>();
        var left = new int[n];

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && primeScore[nums[stack.Peek()]] < primeScore[nums[i]])
                stack.Pop();

            left[i] = stack.Count == 0 ? -1 : stack.Peek();
            stack.Push(i);
        }

        return left;
    }

    private static int[] GetRightBounds(IList<int> nums, Dictionary<int, int> primeScore)
    {
        int n = nums.Count;
        var stack = new Stack<int>();
        var right = new int[n];

        for (int i = n - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && primeScore[nums[stack.Peek()]] <= primeScore[nums[i]])
                stack.Pop();

            right[i] = stack.Count == 0 ? n : stack.Peek();
            stack.Push(i);
        }

        return right;
    }
}
