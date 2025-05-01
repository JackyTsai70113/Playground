using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0729_MyCalendarTest
{
    [Theory]
    [InlineData(new string[] { "MyCalendar", "book", "book", "book" }, "[[],[10,20],[15,25],[20,30]]", "[null,true,false,true]")]
    [InlineData(new string[] { "MyCalendar", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book" }, "[[],[47,50],[33,41],[39,45],[33,42],[25,32],[26,35],[19,25],[3,8],[8,13],[18,27]]", "[null,true,true,false,false,true,false,true,true,true,false]")]
    [InlineData(new string[] { "MyCalendar", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book" }, "[[],[23,32],[42,50],[6,14],[0,7],[21,30],[26,31],[46,50],[28,36],[0,6],[27,36],[6,11],[20,25],[32,37],[14,20],[7,16],[13,22],[39,47],[37,46],[42,50],[9,17],[49,50],[31,37],[43,49],[2,10],[3,12],[8,14],[14,21],[42,47],[43,49],[36,43]]", "[null,true,true,true,false,false,false,false,false,true,false,false,false,true,true,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]")]
    public void MyCalendar(string[] funcs, string valArr, string expected)
    {
        var vals = valArr.To2dArr();
        var expecteds = expected.ToArr<bool?>();
        _0729_MyCalendar myCalendar = new();
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
    [InlineData(new string[] { "MyCalendar", "book", "book", "book" }, "[[], [10, 20], [15, 25], [20, 30]]", "[null,true,false,true]")]
    [InlineData(new string[] { "MyCalendar", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book" }, "[[],[47,50],[33,41],[39,45],[33,42],[25,32],[26,35],[19,25],[3,8],[8,13],[18,27]]", "[null,true,true,false,false,true,false,true,true,true,false]")]
    [InlineData(new string[] { "MyCalendar", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book" }, "[[],[23,32],[42,50],[6,14],[0,7],[21,30],[26,31],[46,50],[28,36],[0,6],[27,36],[6,11],[20,25],[32,37],[14,20],[7,16],[13,22],[39,47],[37,46],[42,50],[9,17],[49,50],[31,37],[43,49],[2,10],[3,12],[8,14],[14,21],[42,47],[43,49],[36,43]]", "[null,true,true,true,false,false,false,false,false,true,false,false,false,true,true,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]")]
    public void MyCalendar2(string[] funcs, string valArr, string expected)
    {
        var vals = valArr.To2dArr();
        var expecteds = expected.ToArr<bool?>();
        _0729_MyCalendar2 myCalendar = new();
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
    [InlineData(new string[] { "MyCalendar", "book", "book", "book" }, "[[], [10, 20], [15, 25], [20, 30]]", "[null,true,false,true]")]
    [InlineData(new string[] { "MyCalendar", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book" }, "[[],[47,50],[33,41],[39,45],[33,42],[25,32],[26,35],[19,25],[3,8],[8,13],[18,27]]", "[null,true,true,false,false,true,false,true,true,true,false]")]
    [InlineData(new string[] { "MyCalendar", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book" }, "[[],[23,32],[42,50],[6,14],[0,7],[21,30],[26,31],[46,50],[28,36],[0,6],[27,36],[6,11],[20,25],[32,37],[14,20],[7,16],[13,22],[39,47],[37,46],[42,50],[9,17],[49,50],[31,37],[43,49],[2,10],[3,12],[8,14],[14,21],[42,47],[43,49],[36,43]]", "[null,true,true,true,false,false,false,false,false,true,false,false,false,true,true,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]")]
    [InlineData(new string[] { "MyCalendar", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book", "book" }, "[[],[20,29],[13,22],[44,50],[1,7],[2,10],[14,20],[19,25],[36,42],[45,50],[47,50],[39,45],[44,50],[16,25],[45,50],[45,50],[12,20],[21,29],[11,20],[12,17],[34,40],[10,18],[38,44],[23,32],[38,44],[15,20],[27,33],[34,42],[44,50],[35,40],[24,31]]", "[null,true,false,true,true,false,true,false,true,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]")]
    public void MyCalendar3(string[] funcs, string valArr, string expected)
    {
        var vals = valArr.To2dArr();
        var expecteds = expected.ToArr<bool?>();
        _0729_MyCalendar3 myCalendar = new();
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
