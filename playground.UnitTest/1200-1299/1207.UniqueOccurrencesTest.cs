namespace playground.UnitTest;

public class UniqueOccurrencesTest1207
{
    [Theory]
    [InlineData("[1,2,2,1,1,3]", true)]
    [InlineData("[1,2]", false)]
    [InlineData("[-3,0,1,-3,1,1,1,-3,10,0]", true)]
    public void UniqueOccurrences(string arr, bool expected)
    {
        var actual = UniqueOccurrences1207.UniqueOccurrences(arr.ToArr());
        Assert.Equal(expected, actual);
    }
}
