namespace playground;

public class Solution
{
    // int[] nums;
    // int[,] arr;
    // int res = 0;
    // public long CountSubarrays(int[] nums, int k)
    // {
    //     var segment = new Segment(nums, 0, nums.Length - 1, k);
    //     return segment.count;
    // }
    // private void RangeCount(int start, int end, int k)
    // {
    //     if (start == end)
    //     {
    //         res += nums[start] == k ? 1 : 0;
    //         arr[start, start] = nums[start];
    //         return;
    //     }
    //     int mid = start + (end - start) / 2;
    //     RangeCount(start, mid, k);
    //     RangeCount(mid + 1, end, k);
    //     for (int i = start; i <= mid; i++)
    //     {
    //         for (int j = mid + 1; j <= end; j++)
    //         {
    //             arr[i, j] = nums[start];
    //         }
    //     }
    //     var cur = rangeAnd.ToArray();
    //     for (int i = mid + 1; i <= end; i++)
    //     {
    //         for (int j = 0; j < 32; j++)
    //         {
    //             if ((nums[i] >> j & 1) > 0)
    //                 rangeAnd[j]++;
    //         }
    //     }
    //     for (int i = mid + 1; i <= end; i++)
    //     {
    //         for (int j = 0; j < 32; j++)
    //         {
    //             if ((nums[i] >> j & 1) > 0)
    //                 cur[j]++;
    //         }
    //         int m = 0;
    //         for (; m < 32; m++)
    //         {
    //             if ((cur[m] == i - start + 1 ? 1 : 0) != (k >> m & 1))
    //                 break;
    //         }
    //         if (m == 32)
    //             res++;
    //     }

    //     for (int i = start; i < mid; i++)
    //     {
    //         for (int j = 0; j < 32; j++)
    //         {
    //             if ((nums[i] >> j & 1) > 0)
    //                 cur[j]--;
    //         }
    //         int m = 0;
    //         for (; m < 32; m++)
    //         {
    //             if ((cur[m] == end - i ? 1 : 0) != (k >> m & 1))
    //                 break;
    //         }
    //         if (m == 32)
    //             res++;
    //     }
    //     return rangeAnd;
    // }

    // public class Segment
    // {
    //     int and;
    //     int start;
    //     int end;
    //     public int count = 0;
    //     Segment left;
    //     Segment right;
    //     public Segment(int[] nums, int start, int end, int k)
    //     {
    //         this.start = start;
    //         this.end = end;
    //         if (start == end)
    //         {
    //             and = nums[start];
    //             count = and == k ? 1 : 0;
    //             return;
    //         }
    //         int mid = start + (end - start) / 2;
    //         left = new Segment(nums, start, mid, k);
    //         right = new Segment(nums, mid + 1, end, k);
    //         count += left.count + right.count;
    //         for (int i = start; i <= mid; i++)
    //         {
    //             var cur = nums[i];
    //             for (int j = i; j <= mid; j++)
    //             {
    //                 cur &= nums[j];
    //             }
    //             for (int j = mid + 1; j <= end; j++)
    //             {
    //                 cur &= nums[j];
    //                 if (cur == k)
    //                     count++;
    //                 if (cur < k)
    //                     break;
    //             }
    //         }
    //     }
    // }

    // public int MinimumCost(string target, string[] words, int[] costs)
    // {
    //     var d = new Dictionary<string, int>();
    //     var countD = new HashSet<int>();
    //     var seen = new Dictionary<string, int> { [""] = 0 };
    //     for (int i = 0; i < words.Length; i++)
    //     {
    //         if (d.ContainsKey(words[i]))
    //             d[words[i]] = Math.Min(d[words[i]], costs[i]);
    //         else
    //             d[words[i]] = costs[i];
    //         countD.Add(words[i].Length);
    //     }
    //     for (int i = 0; i < target.Length; i++)
    //     {
    //         foreach (var len in countD)
    //         {
    //             if (i + len <= target.Length)
    //             {
    //                 if ((i == 0 || seen.ContainsKey(target[..i])) && d.ContainsKey(target.Substring(i, len)))
    //                 {
    //                     var str = target.Substring(i, len);
    //                     seen[target[..i] + str] = seen.ContainsKey(target[..i] + str) ? Math.Min(seen[target[..i] + str], seen[target[..i]] + d[str]) : seen[target[..i]] + d[str];
    //                 }
    //             }
    //         }
    //     }
    //     return seen.ContainsKey(target) ? seen[target] : -1;
    // }

    // private void Dfs2(string target, Dictionary<string, int> d, string str, int cur, int[] res)
    // {
    //     if (str.Length == target.Length)
    //     {
    //         res[0] = Math.Min(res[0], cur);
    //         return;
    //     }
    //     var max = d.Keys.Select(k => k.Length).Max();
    //     for (int len = 1; len <= max && str.Length + len <= target.Length; len++)
    //     {
    //         var s = target.Substring(str.Length, len);
    //         if (d.ContainsKey(s))
    //         {
    //             Dfs2(target, d, str + s, cur + d[s], res);
    //         }
    //     }
    // }
}