namespace playground.UnitTest;

public class RangeFreqQueryTest2080
{
    [Theory]
    [InlineData(new string[] { "RangeFreqQuery", "query", "query" }, new string[] { "[[12,33,4,56,22,2,34,33,22,12,34,56]]", "[1,2,4]", "[0,11,33]" }, "[null,1,2]")]
    [InlineData(new string[] { "RangeFreqQuery", "query", "query", "query" }, new string[] { "[[2,2,1,2,2]]", "[2,4,1]", "[1,3,1]", "[0,2,1]" }, "[null,1,1,1]")]
    [InlineData(new string[] { "RangeFreqQuery", "query", "query", "query", "query" }, new string[] { "[[1,1,1,2,2]]", "[0,1,2]", "[0,2,1]", "[3,3,2]", "[2,2,1]" }, "[null,0,3,1,1]")]
    [InlineData(new string[] { "RangeFreqQuery", "query", "query", "query", "query", "query", "query" }, new string[] { "[[8,4,2,5,4,5,8,6,2,3]]", "[0,3,5]", "[5,6,2]", "[6,8,4]", "[2,8,3]", "[4,5,1]", "[2,4,2]" }, "[null,1,0,0,0,0,1]")]
    
    public void RangeFreqQuery(string[] functions, string[] valStrs, string expectedStr)
    {
        var expected = expectedStr.ToArr<int?>();
        var arr = valStrs[0].To2dArr()[0];
        RangeFreqQuery2080 obj = new(arr);
        for (int i = 1; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
                case "query":
                    var vals = valStrs[i].ToArr();
                    var actual = obj.Query(vals[0], vals[1], vals[2]);
                    Assert.Equal(expected[i], actual);
                    break;
                default:
                    break;
            }
        }
    }

    [Theory]
    [InlineData(new string[] { "RangeFreqQuery", "query", "query" }, new string[] { "[[12,33,4,56,22,2,34,33,22,12,34,56]]", "[1,2,4]", "[0,11,33]" }, "[null,1,2]")]
    [InlineData(new string[] { "RangeFreqQuery", "query", "query", "query" }, new string[] { "[[2,2,1,2,2]]", "[2,4,1]", "[1,3,1]", "[0,2,1]" }, "[null,1,1,1]")]
    [InlineData(new string[] { "RangeFreqQuery", "query", "query", "query", "query" }, new string[] { "[[1,1,1,2,2]]", "[0,1,2]", "[0,2,1]", "[3,3,2]", "[2,2,1]" }, "[null,0,3,1,1]")]
    [InlineData(new string[] { "RangeFreqQuery", "query", "query", "query", "query", "query", "query" }, new string[] { "[[8,4,2,5,4,5,8,6,2,3]]", "[0,3,5]", "[5,6,2]", "[6,8,4]", "[2,8,3]", "[4,5,1]", "[2,4,2]" }, "[null,1,0,0,0,0,1]")]
    public void RangeFreqQuery2(string[] functions, string[] valStrs, string expectedStr)
    {
        var expected = expectedStr.ToArr<int?>();
        var arr = valStrs[0].To2dArr()[0];
        RangeFreqQuery2080_2 obj = new(arr);
        for (int i = 1; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
                case "query":
                    var vals = valStrs[i].ToArr();
                    var actual = obj.Query(vals[0], vals[1], vals[2]);
                    Assert.Equal(expected[i], actual);
                    break;
                default:
                    break;
            }
        }
    }
}
