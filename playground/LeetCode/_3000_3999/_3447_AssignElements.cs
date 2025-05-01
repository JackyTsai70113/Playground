namespace playground._3400_3499;

public class _3447_AssignElements
{
    public static int[] AssignElements(int[] groups, int[] elements)
    {
        Dictionary<int, int> elementIndexMap = new Dictionary<int, int>();
        for (int j = 0; j < elements.Length; j++)
        {
            if (!elementIndexMap.ContainsKey(elements[j]))
            {
                elementIndexMap[elements[j]] = j;
            }
        }

        int[] assigned = new int[groups.Length];

        for (int i = 0; i < groups.Length; i++)
        {
            int group = groups[i];
            int bestIndex = -1;

            for (int factor = 1; factor * factor <= group; factor++)
            {
                if (group % factor == 0)
                {
                    int div1 = factor;
                    int div2 = group / factor;

                    if (elementIndexMap.ContainsKey(div1))
                    {
                        int idx = elementIndexMap[div1];
                        if (bestIndex == -1 || idx < bestIndex)
                        {
                            bestIndex = idx;
                        }
                    }
                    if (elementIndexMap.ContainsKey(div2))
                    {
                        int idx = elementIndexMap[div2];
                        if (bestIndex == -1 || idx < bestIndex)
                        {
                            bestIndex = idx;
                        }
                    }
                }
            }

            assigned[i] = bestIndex;
        }

        return assigned;
    }
}
