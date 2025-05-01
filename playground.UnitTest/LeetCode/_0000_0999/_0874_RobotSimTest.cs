using playground.LeetCode._0000_0999;

﻿namespace playground.UnitTest;

public class _0874_RobotSimTest
{
    [Theory]
    [InlineData(new int[] { 4, -1, 3 }, "[]", 25)]
    [InlineData(new int[] { 4, -1, 4, -2, 4 }, "[[2,4]]", 65)]
    [InlineData(new int[] { 6, -1, -1, 6 }, "[]", 36)]
    [InlineData(new int[] { 8 }, "[]", 64)]
    [InlineData(new int[] { 8 }, "[[0,4]]", 9)]
    [InlineData(new int[] { 8 }, "[[0,-100]]", 64)]
    [InlineData(new int[] { -1, 8 }, "[]", 64)]
    [InlineData(new int[] { -1, 8 }, "[[4,0]]", 9)]
    [InlineData(new int[] { -1, 8 }, "[[-100,0]]", 64)]
    [InlineData(new int[] { -1, -1, 8 }, "[]", 64)]
    [InlineData(new int[] { -1, -1, 8 }, "[[0,-4]]", 9)]
    [InlineData(new int[] { -1, -1, 8 }, "[[0,100]]", 64)]
    [InlineData(new int[] { -1, -1, -1, 8 }, "[]", 64)]
    [InlineData(new int[] { -1, -1, -1, 8 }, "[[-4,0]]", 9)]
    [InlineData(new int[] { -1, -1, -1, 8 }, "[[100,0]]", 64)]
    [InlineData(new int[] { 7, -2, -2, 7, 5 }, "[[-3,2],[-2,1],[0,1],[-2,4],[-1,0],[-2,-3],[0,-3],[4,4],[-3,3],[2,2]]", 4)]
    public void RobotSim(int[] commands, string obstacles, int expected)
    {
        var actual = _0874_RobotSim.RobotSim(commands, obstacles.To2dArr());
        Assert.Equal(expected, actual);
    }
}