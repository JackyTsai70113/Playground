namespace playground.Greedy;

public class MaxScoreClass
{
    public static long MaxScore(int[] nums1, int[] nums2, int k)
    {
        int n = nums1.Length;
        var arr = new (int num1, int num2)[n];

        for (var i = 0; i < n; i++)
        {
            arr[i] = (nums1[i], nums2[i]);
        }

        Array.Sort(arr, (x, y) => x.num2.CompareTo(y.num2));

        long res = 0, sum = 0;
        var pq = new PriorityQueue<int, int>();
        for (int i = n - 1; i >= n - k; --i)
        {
            pq.Enqueue(arr[i].num1, arr[i].num1);
            sum += arr[i].num1;
        }

        res = Math.Max(res, sum * arr[n - k].num2);

        for (int i = n - k - 1; i >= 0; --i)
        {
            sum += arr[i].num1 - (pq.Count > 0 ? pq.Dequeue() : 0);
            pq.Enqueue(arr[i].num1, arr[i].num1);
            res = Math.Max(res, sum * arr[i].num2);
            // Console.WriteLine(sum + " " + arr[i][1]);
        }
        return res;
    }
}
