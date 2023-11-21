namespace playground.UnitTest;

public class RemoveDuplicatesTest_0026
{
    [Theory]
    [InlineData("[1,1,2]", "[1, 2]")]
    [InlineData("[0,0,1,1,1,2,2,3,3,4]", "[0,1,2,3,4]")]
    public void RemoveDuplicates(string nums, string expected)
    {
        var actual = nums.ToArr();
        var expectedArr = expected.ToArr();
        RemoveDuplicates_0026.RemoveDuplicates(actual);
        Assert.True(Enumerable.SequenceEqual(expectedArr, actual.Take(expectedArr.Length)));
    }
}
