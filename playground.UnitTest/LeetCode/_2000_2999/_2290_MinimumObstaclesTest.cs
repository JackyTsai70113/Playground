﻿using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2290_MinimumObstaclesTest
{
    [Theory]
    [InlineData("[[0,1,1],[1,1,0],[1,1,0]]", 2)]
    [InlineData("[[0,1,0,0,0],[0,1,0,1,0],[0,0,0,1,0]]", 0)]
    public void MinimumObstacles(string A, int expected)
    {
        var actual = _2290_MinimumObstacles.MinimumObstacles(A.To2dArr());
        Assert.Equal(expected, expected);
    }
}
