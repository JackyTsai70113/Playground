namespace playground.UnitTest;

public class DailyTemperaturesTest0739
{
    [Theory]
    [InlineData("[73,74,75,71,69,72,76,73]", "[1,1,4,2,1,1,0,0]")]
    [InlineData("[30,40,50,60]", "[1,1,1,0]")]
    [InlineData("[30,60,90]", "[1,1,0]")]
    public void DailyTemperatures(string A, string expected)
    {
        var actual = DailyTemperatures0739.DailyTemperatures(A.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
