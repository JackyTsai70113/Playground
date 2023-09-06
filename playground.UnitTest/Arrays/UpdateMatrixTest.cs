using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class UpdateMatrixTest
{
    [Theory]
    [InlineData("[[0,0,0],[0,1,0],[0,0,0]]", "[[0,0,0],[0,1,0],[0,0,0]]")]
    [InlineData("[[0,0,0],[0,1,0],[1,1,1]]", "[[0,0,0],[0,1,0],[1,2,1]]")]
    [InlineData("[[0,0,0,0],[0,1,1,0],[0,1,1,0],[0,0,0,0]]", "[[0,0,0,0],[0,1,1,0],[0,1,1,0],[0,0,0,0]]")]
    public void UpdateMatrix(string heights, string expected)
    {
        var actual = UpdateMatrixClass.UpdateMatrix(heights.To2dArr());

        Assert.Equal(expected.To2dArr(), actual);
    }
}
