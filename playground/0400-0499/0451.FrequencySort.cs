using System.Text;

namespace playground;

public class FrequencySort0451
{
    /// <summary>
    /// https://leetcode.com/problems/sort-characters-by-frequency
    /// </summary>
    public static string FrequencySort(string s) {
        var chs = new int[128];
        foreach(var c in s)
            chs[c]++;
        var arr = chs
            .Select((x, i)=>(x, i))
            .OrderBy(x=>-x.x)
            .ToArray();
        var sb = new StringBuilder();
        for(int i = 0; i<128; i++){
            if(arr[i].x>0)
                sb.Append((char)arr[i].i, arr[i].x);
        }
        return sb.ToString();
    }
}
