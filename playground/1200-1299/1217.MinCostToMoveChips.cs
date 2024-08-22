namespace playground;

public class MinCostToMoveChips1217
{
    public static int MinCostToMoveChips(int[] position)
    {
        var even = 0;
        for (int i = 0; i < position.Length; i++)
        {
            if (position[i] % 2 == 0)
                even++;
        }
        return Math.Min(even, position.Length - even);
    }
}