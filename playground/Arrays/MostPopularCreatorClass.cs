namespace playground.Arrays;

public class MostPopularCreatorClass
{
    /// <remarks>https://leetcode.com/problems/most-popular-video-creator</remarks>
    public static IList<IList<string>> MostPopularCreator(string[] cr, string[] ids, int[] views)
    {
        int n = cr.Length;
        var p = new Dictionary<string, (long totalView, int view, string id)>();
        for (int i = 0; i < n; ++i)
        {
            if (!p.ContainsKey(cr[i]))
            {
                p[cr[i]] = (views[i], views[i], ids[i]);
            }
            else
            {
                long totalView = p[cr[i]].totalView + views[i];
                int view = p[cr[i]].view;
                string id = p[cr[i]].id;
                if (p[cr[i]].view < views[i])
                {
                    view = views[i];
                    id = ids[i];
                }
                else if (p[cr[i]].view == views[i] && p[cr[i]].id.CompareTo(ids[i]) == 1)
                {
                    id = ids[i];
                }
                p[cr[i]] = (totalView, view, id);
            }
        }
        var arr = p.Select(k => (k.Key, k.Value)).OrderBy(x => -x.Value.totalView).ToArray();
        var max = arr[0].Value.totalView;
        var res = new List<IList<string>>();
        foreach (var (Key, Value) in arr)
        {
            if (Value.totalView == max)
            {
                res.Add(new List<string> { Key, p[Key].id });
            }
            else
            {
                break;
            }
        }
        return res;
    }
}
