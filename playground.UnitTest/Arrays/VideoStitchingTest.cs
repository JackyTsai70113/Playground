using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class VideoStitchingTest
{
    [Theory]
    [InlineData("[[0,2],[4,6],[8,10],[1,9],[1,5],[5,9]]", 10, 3)]
    [InlineData("[[0,1],[1,2]]", 5, -1)]
    [InlineData("[[1,2],[3,4]]", 5, -1)]
    [InlineData("[[0,1],[6,8],[0,2],[5,6],[0,4],[0,3],[6,7],[1,3],[4,7],[1,4],[2,5],[2,6],[3,4],[4,5],[5,7],[6,9]]", 9, 3)]
    [InlineData("[[5,7],[1,8],[0,0],[2,3],[4,5],[0,6],[5,10],[7,10]]", 5, 1)]
    public void VideoStitching(string A, int time, int expected)
    {
        var actual = VideoStitchingClass.VideoStitching(A.To2dArr(), time);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("[[0,2],[4,6],[8,10],[1,9],[1,5],[5,9]]", 10, 3)]
    [InlineData("[[0,1],[1,2]]", 5, -1)]
    [InlineData("[[0,1],[6,8],[0,2],[5,6],[0,4],[0,3],[6,7],[1,3],[4,7],[1,4],[2,5],[2,6],[3,4],[4,5],[5,7],[6,9]]", 9, 3)]
    [InlineData("[[5,7],[1,8],[0,0],[2,3],[4,5],[0,6],[5,10],[7,10]]", 5, 1)]
    public void VideoStitching2(string A, int time, int expected)
    {
        var actual = VideoStitchingClass.VideoStitching2(A.To2dArr(), time);
        Assert.Equal(expected, actual);
    }
}
