using playground.Design;
using playground.UnitTest.Utils;

namespace playground.UnitTest.Design;

public class CombinationIteratorTest
{
    [Theory]
    [InlineData("[CombinationIterator, next, hasNext, next, hasNext, next, hasNext]", "[[abc, 2], [], [], [], [], [], []]", "[null, ab, true, ac, true, bc, false]")]
    public void CombinationIteratorTest1(string a, string b, string expectedStr)
    {
        var funcs = a.ToArr<string>();

        var vals = b.To2dArr<string>();

        var expected = expectedStr.ToArr<string>();

        CombinationIterator obj = new(vals[0][0], int.Parse(vals[0][1]));
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "next":
                    Assert.Equal(expected[i], obj.Next());
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
