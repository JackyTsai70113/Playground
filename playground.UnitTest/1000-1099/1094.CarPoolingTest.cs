namespace playground.UnitTest;

public class CarPoolingTest1094
{
    [Theory]
    [InlineData("[[2,1,5],[3,3,7]]", 4, false)]
    [InlineData("[[2,1,5],[3,3,7]]", 5, true)]
    [InlineData("[[4,3,4],[3,2,4],[1,8,9],[7,2,5]]", 14, true)]
    public void CarPooling(string trips, int capacity, bool expected)
    {
        var actual = CarPooling1094.CarPooling(trips.To2dArr(), capacity);
        Assert.Equal(expected, actual);
    }
}
