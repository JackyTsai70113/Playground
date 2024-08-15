namespace playground;

public class NextPermutation0031
{
    public static void NextPermutation(int[] nums)
    {
        var list = new List<int>();
        for (int i = nums.Length - 1; i > 0; i--)
        {
            list.Add(nums[i]);
            if (nums[i - 1] < nums[i])
            {
                int l = 0, r = list.Count;
                while (l < r)
                {
                    int m = l + (r - l) / 2;
                    if (list[m] > nums[i - 1])
                        r = m;
                    else
                        l = m + 1;
                }
                (nums[i - 1], list[l]) = (list[l], nums[i - 1]);
                list.Sort();
                for (int j = i, k = 0; j < nums.Length; j++)
                {
                    nums[j] = list[k++];
                }
                return;
            }
        }
        Array.Sort(nums);
    }
}
