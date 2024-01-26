namespace playground.UnitTest;

public class PermuteTest0046
{
    [Theory]
    [InlineData("[1,2,3]", "[[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]")]
    [InlineData("[0,1]", "[[0,1],[1,0]]")]
    [InlineData("[1]", "[[1]]")]
    public void Permute(string nums, string expected)
    {
        var actual = Permute0046.Permute(nums.ToArr());
        Assert.Equal(expected.To2dArr(), actual);
    }
}
