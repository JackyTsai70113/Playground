namespace playground.UnitTest;

public class DeserializeTest0385
{
    [Theory]
    [InlineData("[]", "[]")]
    [InlineData("[[]]", "[[]]")]
    [InlineData("324", "324")]
    [InlineData("[123,[456,[789]]]", "[123,[456,[789]]]")]
    public void Deserialize(string actualStr, string expectedStr)
    {
        var actual = Deserialize0385.Deserialize(actualStr);
        var expected = Deserialize0385.Deserialize(expectedStr);
        Assert.Equivalent(expected, actual);
        Assert.Equal(expected.GetInteger(), actual.GetInteger());
        Assert.Equal(expected.IsInteger(), actual.IsInteger());
        Assert.Equivalent(expected.GetList(), actual.GetList());

        actual.SetInteger(1);
        expected.SetInteger(1);
        Assert.Equivalent(expected, actual);
    }
}
