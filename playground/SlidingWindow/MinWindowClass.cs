namespace playground.SlidingWindow
{
    public class MinWindowClass
    {
        /// <summary>
        /// https://leetcode.com/problems/minimum-window-substring
        /// </summary>
        public static string MinWindow(string s, string t)
        {
            if (s.Length < t.Length) return string.Empty;
            int resl = -1, resr = 0;
            int l = 0, r = 0;
            var d = new Dictionary<int, int>();
            foreach (var tt in t)
            {
                if (!d.ContainsKey(tt)) d[tt] = 0;
                d[tt]++;
            }
            void SetRes()
            {
                foreach (var v in d.Values)
                {
                    if (v > 0)
                    {
                        return;
                    }
                }
                if (resl == -1 || (r - l) < (resr - resl))
                {
                    resr = r;
                    resl = l;
                }
            }
            for (; r < t.Length; ++r)
            {
                if (!d.ContainsKey(s[r])) continue;
                d[s[r]]--;
            }
            r--;
            SetRes();
            r++;
            for (; r < s.Length; r++)
            {
                if (!d.ContainsKey(s[r])) continue;
                d[s[r]]--;
                bool ifAdd = false;
                while (!d.TryGetValue(s[l], out var val) || val < 0)
                {
                    if (d.TryGetValue(s[l], out _)) d[s[l]]++;
                    l++;
                    ifAdd = true;
                }
                if (d[s[r]] > 0 && ifAdd) continue;
                SetRes();
            }
            return resl == -1 ? string.Empty : s.Substring(resl, resr - resl + 1);
        }
    }
}