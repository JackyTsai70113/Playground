namespace playground.UnitTest;

public class MyCalendarTest0729
{
    [Theory]
    [InlineData(
        new string[] { "MyCalendar", "book", "book", "book" },
        "[[], [10, 20], [15, 25], [20, 30]]",
        "[null,true,false,true]")]
    [InlineData(
        new string[] { "MyCalendar", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book" },
        "[[],[47,50],[33,41],[39,45],[33,42],[25,32],[26,35],[19,25],[3,8],[8,13],[18,27]]",
        "[null,true,true,false,false,true,false,true,true,true,false]")]
    [InlineData(
        new string[] { "MyCalendar", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book" },
        "[[],[23,32],[42,50],[6,14],[0,7],[21,30],[26,31],[46,50],[28,36],[0,6],[27,36],[6,11],[20,25],[32,37],[14,20],[7,16],[13,22],[39,47],[37,46],[42,50],[9,17],[49,50],[31,37],[43,49],[2,10],[3,12],[8,14],[14,21],[42,47],[43,49],[36,43]]",
        "[null,true,true,true,false,false,false,false,false,true,false,false,false,true,true,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]")]
    public void MyCalendar(string[] funcs, string valArr, string expected)
    {
        var vals = valArr.To2dArr();
        var expecteds = expected.ToArr<bool?>();
        MyCalendar myCalendar = new();
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

    [Theory]
    [InlineData(
        new string[] { "MyCalendar", "book", "book", "book" },
        "[[], [10, 20], [15, 25], [20, 30]]",
        "[null,true,false,true]")]
    [InlineData(
        new string[] { "MyCalendar", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book" },
        "[[],[47,50],[33,41],[39,45],[33,42],[25,32],[26,35],[19,25],[3,8],[8,13],[18,27]]",
        "[null,true,true,false,false,true,false,true,true,true,false]")]
    [InlineData(
        new string[] { "MyCalendar", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book" },
        "[[],[23,32],[42,50],[6,14],[0,7],[21,30],[26,31],[46,50],[28,36],[0,6],[27,36],[6,11],[20,25],[32,37],[14,20],[7,16],[13,22],[39,47],[37,46],[42,50],[9,17],[49,50],[31,37],[43,49],[2,10],[3,12],[8,14],[14,21],[42,47],[43,49],[36,43]]",
        "[null,true,true,true,false,false,false,false,false,true,false,false,false,true,true,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]")]
    public void MyCalendar2(string[] funcs, string valArr, string expected)
    {
        var vals = valArr.To2dArr();
        var expecteds = expected.ToArr<bool?>();
        MyCalendar2 myCalendar = new();
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
