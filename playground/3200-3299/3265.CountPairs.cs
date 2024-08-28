namespace playground;

public class CountPairs3265
{
    public static int CountPairs(int[] nums)
    {
        int res = 0;
        var count = new int[1000000];
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            var chs = nums[i].ToString().ToCharArray();
            var vals = new HashSet<int> { int.Parse(new string(chs)) };
            for (int j = 0; j < chs.Length; j++)
            {
                for (int k = j + 1; k < chs.Length; k++)
                {
                    (chs[j], chs[k]) = (chs[k], chs[j]);
                    vals.Add(int.Parse(new string(chs)));
                    (chs[j], chs[k]) = (chs[k], chs[j]);
                }
            }
            foreach (var val in vals)
            {
                res += count[val];
            }
            count[nums[i]]++;
        }
        return res;
    }
}
