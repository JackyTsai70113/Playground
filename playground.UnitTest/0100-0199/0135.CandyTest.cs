namespace playground.UnitTest;

public class CandyTest_0135
{
    [Theory]
    [InlineData("[1,0,2]", 5)]
    [InlineData("[1,2,2]", 4)]
    public void Candy(string nums, int expected)
    {
        var actual = Candy_0135.Candy(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
