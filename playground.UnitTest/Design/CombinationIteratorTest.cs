using playground.Design;

namespace playground.UnitTest.Design;

public class CombinationIteratorTest
{
    [Theory]
    [InlineData(new string[] { "CombinationIterator", "next", "hasNext", "next", "hasNext", "next", "hasNext" }, "[[abc, 2], [], [], [], [], [], []]", new string[] { null, "ab", "true", "ac", "true", "bc", "false" })]
    public void CombinationIteratorTest1(string[] funcs, string b, string[] expected)
    {
        var vals = b.To2dArr<string>();

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
