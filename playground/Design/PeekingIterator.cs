namespace playground.Interval;

public class PeekingIterator
{
    readonly IEnumerator<int> enumerator;
    bool nextExist;

    public PeekingIterator(IEnumerator<int> iterator)
    {
        enumerator = iterator;
        nextExist = true;
        enumerator.MoveNext();
    }

    // Returns the next element in the iteration without advancing the iterator.
    public int Peek()
    {
        return enumerator.Current;
    }

    // Returns the next element in the iteration and advances the iterator.
    public int Next()
    {
        int val = enumerator.Current;
        nextExist = enumerator.MoveNext();
        return val;
    }

    // Returns false if the iterator is refering to the end of the array of true otherwise.
    public bool HasNext()
    {
        return nextExist;
    }
}