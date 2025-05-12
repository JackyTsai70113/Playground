namespace playground.GeeksforGeeks;

public class KthLargestClass
{
    public static int KthLargest(int[] arr, int k)
    {
        int n = arr.Length;
        var pq = new PriorityQueue<int, int>();
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = i; j < n; j++)
            {
                sum += arr[j];
                pq.Enqueue(sum, -sum);
            }
        }

        for (int i = 0; i < k - 1; i++)
        {
            pq.Dequeue();
        }
        return pq.Dequeue();
    }
}