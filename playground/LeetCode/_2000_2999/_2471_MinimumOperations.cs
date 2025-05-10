using playground.DataStructures;

namespace playground.LeetCode._2000_2999;

public class _2471_MinimumOperations
{
    public static int MinimumOperations(TreeNode root)
    {
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        int res = 0;
        while (q.Count > 0)
        {
            int count = q.Count;
            int[] arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                var node = q.Dequeue();
                if (node.left != null)
                    q.Enqueue(node.left);
                if (node.right != null)
                    q.Enqueue(node.right);
                arr[i] = node.val;
            }
            res += CycleSort(arr);
        }
        return res;
    }

    static int CycleSort(int[] arr)
    {
        var d = new Dictionary<int, int>();
        int[] sortedArr = arr.OrderBy(x => x).ToArray();
        for (int i = 0; i < arr.Length; i++)
        {
            d[arr[i]] = i;
        }

        int res = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != sortedArr[i])
            {
                int index1 = d[sortedArr[i]];
                int index2 = d[arr[i]];

                d[arr[i]] = index1;
                d[sortedArr[i]] = index2;

                arr[index1] = arr[i];
                arr[index2] = sortedArr[i];
                res++;
            }
        }
        return res;
    }
}


/*
int ans = 0;
    Queue<TreeNode> queue = new();
    queue.Enqueue(root);
    int count = queue.Count;
    List<int> li = new();
    List<int> inds = new();
    while (queue.Count > 0)
    {
        var node = queue.Dequeue();
        if (node.left != null) queue.Enqueue(node.left);
        if (node.right != null) queue.Enqueue(node.right);
        inds.Add(li.Count);
        li.Add(node.val);
        count--;
        if (count == 0)
        {
            count = queue.Count;
            var keys = li.ToArray();
            var items = inds.ToArray();
            Array.Sort(keys, items);
            HashSet<int> set = new();
            for (int i = 0; i < items.Length; i++)
            {
                if (set.Contains(i)) continue;
                if (items[i] == i) continue;
                int start = i;
                int next = items[i];
                while (start != next)
                {
                    set.Add(next);
                    next = items[next];
                    ans++;
                }
            }
            inds.Clear();
            li.Clear();
        }
    }
    return ans;
*/