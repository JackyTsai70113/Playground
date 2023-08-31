using System.Numerics;

namespace playground.BitManipulation;

public class WordCountClass
{
    public static int WordCount(string[] startWords, string[] targetWords)
    {
        var startWordBits = new HashSet<int>();

        int GetBit(string str)
        {
            int mask = 0;
            foreach (var c in str)
                mask += 1 << (c - 'a');
            return mask;
        }

        foreach (var startWord in startWords)
            startWordBits.Add(GetBit(startWord));

        int res = 0;
        foreach (var targetWord in targetWords)
        {
            var targetWordBit = GetBit(targetWord);
            foreach (var c in targetWord)
            {
                int copy = targetWordBit ^ (1 << (c - 'a'));
                if (startWordBits.Contains(copy))
                {
                    res++;
                    break;
                }
            }
        }
        return res;
    }
}
