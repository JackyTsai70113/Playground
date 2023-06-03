using playground.DepthFirstSearch;

namespace playground.UnitTest.DepthFirstSearch;

public class DeserializeTest
{
    [Theory]
    [InlineData("[]", "[]")]
    [InlineData("[[]]", "[[]]")]
    [InlineData("324", "324")]
    [InlineData("[123,[456,[789]]]", "[123,[456,[789]]]")]
    public void Deserialize(string actualStr, string expectedStr)
    {
        var actual = DeserializeClass.Deserialize(actualStr);
        var expected = DeserializeClass.Deserialize(expectedStr);
        Assert.Equivalent(expected, actual);
        Assert.Equal(expected.GetInteger(), actual.GetInteger());
        Assert.Equal(expected.IsInteger(), actual.IsInteger());
        Assert.Equivalent(expected.GetList(), actual.GetList());

        actual.SetInteger(1);
        expected.SetInteger(1);
        Assert.Equivalent(expected, actual);
    }
}
