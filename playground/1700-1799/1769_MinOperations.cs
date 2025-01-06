namespace playground._1700_1799;

public class _1769_MinOperations
{
    public static int[] MinOperations(string boxes)
    {
        var res = new int[boxes.Length];
        int pre = 0, cur = 0;
        for (int i = 0; i < boxes.Length; ++i)
        {
            pre += cur;
            res[i] += pre;
            if (boxes[i] == '1')
                cur++;
        }

        pre = 0; cur = 0;
        for (int i = boxes.Length - 1; i >= 0; --i)
        {
            pre += cur;
            res[i] += pre;
            if (boxes[i] == '1')
                cur++;
        }
        return res;
    }
}