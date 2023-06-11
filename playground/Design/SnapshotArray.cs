namespace playground.Design;

public class SnapshotArray
{
    int snapId = 0;
    readonly Dictionary<int, int>[] snapDict;
    public SnapshotArray(int length)
    {
        snapDict = new Dictionary<int, int>[length];
        for (int i = 0; i < length; ++i)
        {
            snapDict[i] = new()
            {
                [0] = 0
            };
        }
    }

    public void Set(int index, int val)
    {
        snapDict[index][snapId] = val;
    }

    public int Snap()
    {
        return snapId++;
    }

    public int Get(int index, int snap_id)
    {
        while (true)
        {
            if (snapDict[index].TryGetValue(snap_id, out var v))
            {
                return v;
            }
            else
            {
                snap_id--;
            }
        }
    }
}

