using playground.DepthFirstSearch;

namespace playground.UnitTest.DepthFirstSearch;

public class DeserializeTest
{
    [Theory]
    [InlineData("[]", "[]")]
    [InlineData("[[]]", "[[]]")]
    [InlineData("324", "324")]
    [InlineData("[123,[456,[789]]]", "[123,[456,[789]]]")]
    public void IsAdditiveNumber(string s, string expected)
    {
        Assert.NotNull(DeserializeClass.Deserialize(s));
        Assert.Equal(expected, s);
    }
}
