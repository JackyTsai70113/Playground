namespace playground.UnitTest;

public class JobSchedulingTest1235
{
    [Theory]
    [InlineData("[1,2,3,3]", "[3,4,5,6]", "[50,10,40,70]", 120)]
    [InlineData("[1,2,3,4,6]", "[3,5,10,6,9]", "[20,20,100,70,60]", 150)]
    [InlineData("[1,1,1]", "[2,3,4]", "[5,6,4]", 6)]
    public void JobScheduling(string startTime, string endTime, string profit, int expected)
    {
        var actual = JobScheduling1235.JobScheduling(startTime.ToArr(), endTime.ToArr(), profit.ToArr());
        Assert.Equal(expected, actual);
    }
}
