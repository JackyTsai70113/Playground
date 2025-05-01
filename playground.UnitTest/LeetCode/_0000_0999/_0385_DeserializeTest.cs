using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0385_DeserializeTest
{
    [Theory]
    [InlineData("[]", "[]")]
    [InlineData("[[]]", "[[]]")]
    [InlineData("324", "324")]
    [InlineData("[123,[456,[789]]]", "[123,[456,[789]]]")]
    public void Deserialize(string actualStr, string expectedStr)
    {
        var actual = _0385_Deserialize.Deserialize(actualStr);
        var expected = _0385_Deserialize.Deserialize(expectedStr);
        Assert.Equivalent(expected, actual);
        Assert.Equal(expected.GetInteger(), actual.GetInteger());
        Assert.Equal(expected.IsInteger(), actual.IsInteger());
        Assert.Equivalent(expected.GetList(), actual.GetList());

        actual.SetInteger(1);
        expected.SetInteger(1);
        Assert.Equivalent(expected, actual);
    }
}
