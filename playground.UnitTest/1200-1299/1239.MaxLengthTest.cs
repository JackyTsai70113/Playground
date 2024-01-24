namespace playground.UnitTest;

public class MaxLengthTest1239
{
    [Theory]
    [InlineData(new string[] { "un", "iq", "ue" }, 4)]
    [InlineData(new string[] { "cha", "r", "act", "ers" }, 6)]
    [InlineData(new string[] { "abcdefghijklmnopqrstuvwxyz" }, 26)]
    public void MaxLength(string[] arr, int expected)
    {
        var actual = MaxLength1239.MaxLength(arr);
        Assert.Equal(expected, actual);
    }
}
