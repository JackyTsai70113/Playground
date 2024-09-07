namespace playground.UnitTest;

public class RobotSimTest0874
{
    [Theory]
    [InlineData(new int[]{4,-1,3}, "[]", 25)]
    [InlineData(new int[]{4,-1,4,-2,4}, "[[2,4]]", 65)]
    [InlineData(new int[]{-2,8,3,7,-1}, "[[-4,-1],[1,-1],[1,4],[5,0],[4,5],[-2,-1],[2,-5],[5,1],[-3,-1],[5,-3]]", 324)]
    [InlineData(new int[]{6,-1,-1,6}, "[]", 36)]
    public void RobotSim(int[] commands, string obstacles, int expected)
    {
        var actual = RobotSim0874.RobotSim(commands, obstacles.To2dArr());
        Assert.Equal(expected, actual);
    }
}