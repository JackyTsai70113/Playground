namespace playground.Stacks;

public class SurvivedRobotsHealthsClass
{
    public static IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions)
    {
        List<(int i, int p, int h, char d)> A = positions
            .Select((_, i) => (i, p: positions[i], h: healths[i], d: directions[i]))
            .OrderBy(x => x.p)
            .ToList();
        var collide = true;
        while (collide && A.Count > 0)
        {
            collide = false;
            var B = Enumerable
                .Empty<(int i, int p, int h, char d)>()
                .ToList();
            for (int i = 0; i < A.Count; ++i)
            {
                if (B.Count > 0 && B[^1].d == 'R' && A[i].d == 'L')
                {
                    if (B[^1].h == A[i].h)
                    {
                        B.RemoveAt(B.Count - 1);
                    }
                    else if (B[^1].h > A[i].h)
                    {
                        B[^1] = (B[^1].i, B[^1].p, B[^1].h - 1, B[^1].d);
                    }
                    else if (B[^1].h < A[i].h)
                    {
                        B.RemoveAt(B.Count - 1);
                        A[i] = (A[i].i, A[i].p, A[i].h - 1, A[i].d);
                        i--;
                    }
                    collide = true;
                }
                else
                {
                    B.Add((A[i].i, A[i].p, A[i].h, A[i].d));
                }
            }
            A = B;
        }
        return A.OrderBy(x => x.i).Select(x => x.h).ToList();
    }
}
