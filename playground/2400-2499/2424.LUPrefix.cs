namespace playground;

public class LUPrefix2424
{
    int n;
    readonly int[] uploadeds;
    public LUPrefix2424(int n)
    {
        this.n = n;
        uploadeds = new int[n * 4];
        Array.Fill(uploadeds, -1);
    }

    public void Upload(int video)
    {
        update(0, 0, n - 1, video - 1);
    }

    public int Longest()
    {
        return uploadeds[0] + 1;
    }

    void update(int i, int start, int end, int video)
    {
        if (video == start && start == end)
        {
            uploadeds[i] = start;
            return;
        }
        int mid = start + (end - start) / 2;
        if (video <= mid)
            update(i * 2 + 1, start, mid, video);
        else
            update(i * 2 + 2, mid + 1, end, video);
        if (uploadeds[i * 2 + 1] < mid || uploadeds[i * 2 + 2] == -1)
            uploadeds[i] = uploadeds[i * 2 + 1];
        else
            uploadeds[i] = uploadeds[i * 2 + 2];
    }
}
