using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;
public class _0155_MinStackTest
{
    [Theory]
    [InlineData(new string[] { "MinStack", "push", "push", "push", "getMin", "pop", "top", "getMin" }, "[[],[-2],[0],[-3],[],[],[],[]]", "[null,null,null,null,-3,null,0,-2]")]
    public void Solution(string[] functions, string valStr, string expectedStr)
    {
        int[][] vals = valStr.To2dArr<int>();
        int?[] expected = expectedStr.ToArr<int?>();
        _0155_MinStack obj = new();
        for (int i = 1; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
                case "push":
                    obj.Push(vals[i][0]);
                    break;
                case "getMin":
                    int min = obj.GetMin();
                    Assert.Equal(expected[i], min);
                    break;
                case "pop":
                    obj.Pop();
                    break;
                case "top":
                    int top = obj.Top();
                    Assert.Equal(expected[i], top);
                    break;
                default:
                    break;
            }
        }
    }
}
