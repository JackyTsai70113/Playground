namespace playground.UnitTest;

public class MyCalendarTwoTest0731
{
    [Theory]
    [InlineData(new string[] { "MyCalendarTwo", "book", "book", "book", "book", "book", "book" }, "[[], [10, 20], [50, 60], [10, 40], [5, 15], [5, 10], [25, 55]]", "[null, true, true, true, false, true, true]")]
    [InlineData(new string[] { "MyCalendarTwo", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book" }, "[[],[24,40],[43,50],[27,43],[5,21],[30,40],[14,29],[3,19],[3,14],[25,39],[6,19]]", "[null,true,true,true,true,false,false,true,false,false,false]")]
    [InlineData(new string[] { "MyCalendarTwo", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book" }, "[[],[5,12],[42,50],[4,9],[33,41],[2,7],[16,25],[7,16],[6,11],[13,18],[38,43],[49,50],[6,15],[5,13],[35,42],[19,24],[46,50],[39,44],[28,36],[28,37],[20,29],[41,49],[11,19],[41,46],[28,37],[17,23],[22,31],[4,10],[31,40],[4,12],[19,26]]", "[null,true,true,true,true,false,true,false,false,true,true,true,false,false,false,true,false,false,true,false,false,false,false,false,false,false,false,false,false,false,false]")]
    public void MyCalendar(string[] funcs, string valArr, string expected)
    {
        var vals = valArr.To2dArr();
        var expecteds = expected.ToArr<bool?>();
        MyCalendarTwo0731 myCalendar = new();
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "book":
                    Assert.Equal(expecteds[i], myCalendar.Book(vals[i][0], vals[i][1]));
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
