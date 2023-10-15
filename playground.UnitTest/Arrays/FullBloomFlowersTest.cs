﻿using System.Text.Json;
using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class FullBloomFlowersTest
{
    [Theory]
    [InlineData("[[1,6],[3,7],[9,12],[4,13]]", new int[] { 2, 3, 7, 11 }, new int[] { 1, 2, 2, 2 })]
    [InlineData("[[1,10],[3,3]]", new int[] { 3, 3, 2 }, new int[] { 2, 2, 1 })]
    [InlineData("[[36,39],[29,49],[32,35],[14,43],[42,49],[48,48],[32,46],[6,41],[14,19]]", new int[] { 14, 4 }, new int[] { 3, 0 })]
    [InlineData("[[43,50],[31,39],[37,42],[38,47],[22,25],[31,42],[29,43],[15,30],[37,42]]", new int[] { 47, 4, 12, 12, 30, 18, 17 }, new int[] { 2, 0, 0, 0, 2, 1, 1 })]
    public void FullBloomFlowers(string flowers, int[] people, int[] expected)
    {
        var actual = FullBloomFlowersClass.FullBloomFlowers(flowers.To2dArr(), people);
        Assert.True(expected.SequenceEqual(actual), JsonSerializer.Serialize(expected) + "," + JsonSerializer.Serialize(actual));
    }
}
