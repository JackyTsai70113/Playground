namespace playground.UnitTest;

public class MostFrequentIDsTest3092
{
    [Theory]
    [InlineData("[2,3,2,1]", "[3,2,-3,1]", "[3,3,2,2]")]
    [InlineData("[5,5,3]", "[2,-2,1]", "[2,0,1]")]
    public void MostFrequentIDs(string nums, string freq, string expected)
    {
        var actual = MostFrequentIDs3092.MostFrequentIDs(nums.ToArr(), freq.ToArr());
        Assert.Equal(expected.ToArr<long>(), actual);
    }
}
