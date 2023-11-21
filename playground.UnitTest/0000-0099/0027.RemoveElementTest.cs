namespace playground.UnitTest;

public class RemoveElementTest_0027
{
    [Theory]
    [InlineData("[3,2,2,3]", 3, "[2,2]")]
    [InlineData("[0,1,2,2,3,0,4,2]", 2, "[0,1,3,0,4]")]
    public void RemoveElement(string nums, int val, string expected)
    {
        var actual = nums.ToArr();
        RemoveElement_0027.RemoveElement(actual, val);
        var expectedArr = expected.ToArr();
        Assert.True(Enumerable.SequenceEqual(actual.Take(expectedArr.Length), expectedArr));
    }
}
