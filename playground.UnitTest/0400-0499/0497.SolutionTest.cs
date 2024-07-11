namespace playground.UnitTest;

public class SolutionTest0497
{
    [Theory]
    [InlineData(new string[] { "Solution", "pick", "pick", "pick", "pick", "pick" }, new string[] { "[[-2, -2, 1, 1], [2, 2, 4, 6]]", "[]", "[]", "[]", "[]", "[]" }, "[null, [1, -2], [1, -1], [-1, -2], [-2, -2], [0, 0]]")]
    public void Solution(string[] funcs, string[] valStr, string expectedStr)
    {
        var expected = expectedStr.ToArr<int[]>();
        Solution0497 obj = new(valStr[0].To2dArr());
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "pick":
                    Assert.Equal(expected[i], obj.Pick());
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
