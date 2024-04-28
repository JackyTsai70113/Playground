namespace playground.UnitTest;

public class FindRotateStepsTest0514
{
    [Theory]
    [InlineData("godding", "gd", 4)]
    [InlineData("godding", "godding", 13)]
    public void FindRotateSteps(string ring, string key, int expected)
    {
        var actual = FindRotateSteps0514.FindRotateSteps(ring, key);
        Assert.Equal(expected, actual);
    }
}
