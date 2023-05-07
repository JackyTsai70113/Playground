namespace playground.Design;

public class FrequencyTracker
{
    int[] arr1;
    int[] arr2;
    public FrequencyTracker()
    {
        arr1 = new int[100001];
        arr2 = new int[100001];
    }

    public void Add(int x)
    {
        arr2[arr1[x]]--;
        arr1[x]++;
        arr2[arr1[x]]++;
    }

    public void DeleteOne(int x)
    {
        if (arr1[x] > 0)
        {
            arr2[arr1[x]]--;
            arr1[x]--;
            arr2[arr1[x]]++;
        }
    }

    public bool HasFrequency(int f)
    {
        return arr2[f] > 0;
    }
}