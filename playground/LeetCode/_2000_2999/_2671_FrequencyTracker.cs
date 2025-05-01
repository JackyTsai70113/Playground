namespace playground.LeetCode._2000_2999;

public class _2671_FrequencyTracker
{
    public int[] freqToNumCount;
    public int[] numToFreq;
    public _2671_FrequencyTracker()
    {
        freqToNumCount = new int[100001];
        numToFreq = new int[100001];
    }

    public void Add(int number)
    {
        var freq = numToFreq[number];
        numToFreq[number] = freq + 1;
        freqToNumCount[freq]--;
        freqToNumCount[freq + 1]++;
    }

    public void DeleteOne(int number)
    {
        var freq = numToFreq[number];
        if (freq == 0)
            return;
        numToFreq[number] = freq - 1;
        freqToNumCount[freq]--;
        freqToNumCount[freq - 1]++;
    }

    public bool HasFrequency(int frequency)
    {
        return freqToNumCount[frequency] > 0;
    }
}


public class _2671_FrequencyTracker2
{
    public Dictionary<int, int> freqToNumCount;
    public Dictionary<int, int> numToFreq;
    public _2671_FrequencyTracker2()
    {
        freqToNumCount = new();
        numToFreq = new();
    }

    public void Add(int number)
    {
        var freq = numToFreq.GetValueOrDefault(number);
        numToFreq[number] = freq + 1;
        if (freq > 0)
            freqToNumCount[freq]--;
        freqToNumCount[freq + 1] = freqToNumCount.GetValueOrDefault(freq + 1) + 1;
    }

    public void DeleteOne(int number)
    {
        var freq = numToFreq.GetValueOrDefault(number);
        if (freq == 0)
            return;
        numToFreq[number] = freq - 1;
        freqToNumCount[freq]--;
        freqToNumCount[freq - 1] = freqToNumCount.GetValueOrDefault(freq - 1) + 1;
    }

    public bool HasFrequency(int frequency)
    {
        return freqToNumCount.GetValueOrDefault(frequency) > 0;
    }
}
