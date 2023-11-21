namespace playground.UnitTest;

public class FindDifferentBinaryStringTest_1980
{
    [Theory]
    [InlineData("[\"01\",\"10\"]", "00")]
    [InlineData("[\"00\",\"01\"]", "11")]
    [InlineData("[\"111\",\"011\",\"001\"]", "000")]
    public void FindDifferentBinaryString(string nums, string expected)
    {
        var actual = FindDifferentBinaryString_1980.FindDifferentBinaryString(nums.ToArr<string>());
        Assert.Equal(expected, actual);
    }
}
