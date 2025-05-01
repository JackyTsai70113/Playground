namespace playground.UnitTest;

public class _1239_MaxLengthTest
{
    [Theory]
    [InlineData(new string[] { "un", "iq", "ue" }, 4)]
    [InlineData(new string[] { "cha", "r", "act", "ers" }, 6)]
    [InlineData(new string[] { "abcdefghijklmnopqrstuvwxyz" }, 26)]
    public void MaxLength(string[] arr, int expected)
    {
        var actual = _1239_MaxLength.MaxLength(arr);
        Assert.Equal(expected, actual);
    }
}
