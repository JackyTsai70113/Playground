using playground.Interval;
using playground.UnitTest.Utils;

namespace playground.UnitTest.Design;

public class PeekingIteratorTest
{
    [Theory]
    [InlineData("[PeekingIterator,next,peek,next,next,hasNext]", "[[1,2,3],[],[],[],[],[]]", "[null, 1, 2, 2, 3, false]")]
    public void SmallestInfiniteSetTest1(string funcArr, string valArr, string expectedStr)
    {
        var funcs = funcArr.ToArr<string>();

        var vals = valArr.To2dArr<int>();

        var expected = expectedStr.ToArr<string>();

        PeekingIterator obj = new(((IEnumerable<int>)vals[0]).GetEnumerator());
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "peek":
                    Assert.Equal(int.Parse(expected[i]), obj.Peek());
                    break;
                case "next":
                    Assert.Equal(int.Parse(expected[i]), obj.Next());
                    break;
                case "hasNext":
                    Assert.Equal(bool.Parse(expected[i]), obj.HasNext());
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
