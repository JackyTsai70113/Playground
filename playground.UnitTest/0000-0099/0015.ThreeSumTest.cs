namespace playground.UnitTest;

public class ThreeSumTest_0015
{
    [Theory]
    [InlineData("[-1,0,1,2,-1,-4]", "[[-1,-1,2],[-1,0,1]]")]
    [InlineData("[0,1,1]", "[]")]
    [InlineData("[0,0,0]", "[[0,0,0]]")]
    public void ThreeSum(string nums, string expected)
    {
        var actual = ThreeSum_0015.ThreeSum(nums.ToArr());
        var expectedArr = expected.To2dArr();
        if (expectedArr.Length == 0)
        {
            Assert.Equal(expectedArr.Length, actual.Count);
        }
        else
        {
            for (int i = 0; i < expectedArr.Length; ++i)
                Assert.True(Enumerable.SequenceEqual(expectedArr[i], actual[i]));
        }
    }
}
