namespace playground;

public class _1094_CarPooling
{
    public static bool CarPooling(int[][] trips, int capacity)
    {
        var changes = new int[1001];
        foreach (var t in trips)
        {
            int people = t[0], from = t[1], to = t[2];
            changes[from] += people;
            changes[to] -= people;
        }
        for (int i = 0; i < changes.Length; i++)
        {
            capacity -= changes[i];
            if (capacity < 0)
                return false;
        }
        return true;
    }
}
