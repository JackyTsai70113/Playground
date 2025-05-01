using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2933_FindHighAccessEployeesTest
{
    [Theory]
    [InlineData("[[\"a\",\"0549\"],[\"b\",\"0457\"],[\"a\",\"0532\"],[\"a\",\"0621\"],[\"b\",\"0540\"]]", "[\"a\"]")]
    [InlineData("[[\"d\",\"0002\"],[\"c\",\"0808\"],[\"c\",\"0829\"],[\"e\",\"0215\"],[\"d\",\"1508\"],[\"d\",\"1444\"],[\"d\",\"1410\"],[\"c\",\"0809\"]]", "[\"c\",\"d\"]")]
    [InlineData("[[\"cd\",\"1025\"],[\"ab\",\"1025\"],[\"cd\",\"1046\"],[\"cd\",\"1055\"],[\"ab\",\"1124\"],[\"ab\",\"1120\"]]", "[\"cd\",\"ab\"]")]
    public void FindHighAccessEmployees(string nums, string expected)
    {
        var actual = _2933_FindHighAccessEmployees.FindHighAccessEmployees(nums.To2dArr<string>());
        Assert.Equal(expected.ToArr<string>(), actual);
    }
}
