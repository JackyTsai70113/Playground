namespace playground.UnitTest;

public class _1980_FindDifferentBinaryStringTest
{
    [Theory]
    [InlineData("[\"01\",\"10\"]", "00")]
    [InlineData("[\"00\",\"01\"]", "11")]
    [InlineData("[\"111\",\"011\",\"001\"]", "000")]
    public void FindDifferentBinaryString(string nums, string expected)
    {
        var actual = _1980_FindDifferentBinaryString.FindDifferentBinaryString(nums.ToArr<string>());
        Assert.Equal(expected, actual);
    }
}
