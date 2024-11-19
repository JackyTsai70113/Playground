using playground._1400_1499;

namespace playground.UnitTest._1400_1499;

public class _1462_CheckIfPrerequisiteTest
{
    [Theory]
    [InlineData(2, "[[1,0]]", "[[0,1],[1,0]]", new bool[] { false, true })]
    [InlineData(2, "[]", "[[1,0],[0,1]]", new bool[] { false, false })]
    [InlineData(3, "[[1,2],[1,0],[2,0]]", "[[1,0],[1,2]]", new bool[] { true, true })]
    public void CheckIfPrerequisite(int numCourses, string prerequisites, string queries, IList<bool> expected)
    {
        var actual = _1462_CheckIfPrerequisite.CheckIfPrerequisite(numCourses, prerequisites.To2dArr(), queries.To2dArr());
        Assert.Equal(expected, actual);
    }
}
