namespace playground.UnitTest;

public class FindAllPeopleTest2092
{
    [Theory]
    [InlineData(6, "[[1,2,5],[2,3,8],[1,5,10]]", 1, "[0, 1, 2, 3, 5]")]
    [InlineData(4, "[[3,1,3],[1,2,2],[0,3,3]]", 3, "[0, 1, 3]")]
    [InlineData(5, "[[3,4,2],[1,2,1],[2,3,1]]", 1, "[0,1,2,3,4]")]
    [InlineData(6, "[[2,3,2],[3,4,2],[4,5,2],[1,5,2],[1,2,2]]", 1, "[0,1,2,3,4,5]")]
    public void FindAllPeople(int n, string meetings, int firstPerson, string expected)
    {
        var actual = FindAllPeople2092.FindAllPeople(n, meetings.To2dArr(), firstPerson);
        Assert.Equal(expected.ToArr(), actual.OrderBy(x => x));
    }
}
