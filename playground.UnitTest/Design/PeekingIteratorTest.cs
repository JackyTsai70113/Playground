using playground.Interval;

namespace playground.UnitTest.Design;

public class PeekingIteratorTest
{
    [Theory]
    [InlineData(new string[] { "PeekingIterator", "next", "peek", "next", "next", "hasNext" }, "[[1,2,3],[],[],[],[],[]]", new string[] { null, "1", "2", "2", "3", "false" })]
    public void PeekingIterator(string[] functions, string valArr, string[] expected)
    {
        var vals = valArr.To2dArr();
        PeekingIterator obj = new(((IEnumerable<int>)vals[0]).GetEnumerator());
        for (int i = 1; i < functions.Length; ++i)
        {
            switch (functions[i])
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
