using playground.Design;

namespace playground.UnitTest.Design;

public class SnapshotArrayTest
{
    [Theory]
    [InlineData(new string[] { "SnapshotArray", "set", "snap", "set", "get" }, "[[3],[0,5],[],[0,6],[0,0]]", new string[] { null, null, "0", null, "5" })]
    [InlineData(new string[] { "SnapshotArray", "set", "snap", "snap", "snap", "get", "snap", "snap", "get" }, "[[1],[0,15],[],[],[],[0,2],[],[],[0,0]]", new string[] { null, null, "0", "1", "2", "15", "3", "4", "15" })]
    [InlineData(new string[] { "SnapshotArray", "snap", "snap", "get", "set", "snap", "set" }, "[[4],[],[],[3,1],[2,4],[],[1,4]]", new string[] { null, "0", "1", "0", null, "2", null })]
    public void SnapshotArray(string[] funcs, string valArr, string[] expected)
    {
        var vals = valArr.To2dArr();
        SnapshotArray snapshotArray = new(0);
        for (int i = 0; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "SnapshotArray":
                    int length = vals[i][0];
                    snapshotArray = new SnapshotArray(length);
                    break;
                case "set":
                    int index = vals[i][0];
                    int val = vals[i][1];
                    snapshotArray.Set(index, val);
                    break;
                case "snap":
                    int actualSnapId = snapshotArray.Snap();
                    int expectedSnapId = int.Parse(expected[i]);
                    Assert.Equal(expectedSnapId, actualSnapId);
                    break;
                case "get":
                    index = vals[i][0];
                    int snapId = vals[i][1];
                    int actualVal = snapshotArray.Get(index, snapId);
                    int expectedVal = int.Parse(expected[i]);
                    Assert.Equal(expectedVal, actualVal);
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
