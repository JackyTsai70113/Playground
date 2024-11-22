using playground._1900_1999;

namespace playground.UnitTest._1900_1999;

public class _1993_LockingTreeTest
{
    [Theory]
    [InlineData(new string[] { "LockingTree", "lock", "unlock", "unlock", "lock", "upgrade", "lock", "unlock", "lock" }, "[[-1,0,0,1,1,2,2],[2,2],[2,3],[2,2],[4,5],[0,1],[0,1],[0,1],[0,1]]", "[null,true,false,true,true,true,false,true,true]")]
    [InlineData(new string[] { "LockingTree", "upgrade", "upgrade", "upgrade", "upgrade", "upgrade", "lock", "unlock", "upgrade", "upgrade", "upgrade", "lock", "upgrade", "upgrade", "upgrade", "lock", "unlock", "upgrade", "unlock", "unlock", "upgrade" }, "[[-1,4,9,0,6,1,0,6,3,1],[9,43],[4,27],[5,34],[7,31],[4,27],[2,47],[7,21],[4,12],[1,1],[8,20],[5,50],[5,28],[0,11],[6,19],[9,27],[5,6],[0,5],[4,49],[4,22],[5,27]]", "[null,false,false,false,false,false,true,false,true,false,false,true,false,true,false,true,false,false,false,false,false]")]
    [InlineData(new string[] { "LockingTree", "lock", "lock", "upgrade", "unlock", "upgrade" }, "[[-1,0,0,1,1,2,2],[3,2],[4,2],[0,2],[0,2],[1,5]]", "[null,true,true,true,true,false]")]
    public void LockingTree(string[] functions, string valStr, string expectedStr)
    {
        var vals = valStr.To2dArr();
        var expected = expectedStr.ToArr<bool?>();
        _1993_LockingTree obj = new(vals[0]);
        for (int i = 1; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
                case "lock":
                    var actual1 = obj.Lock(vals[i][0], vals[i][1]);
                    Assert.Equal(expected[i], actual1);
                    break;
                case "unlock":
                    var actual2 = obj.Unlock(vals[i][0], vals[i][1]);
                    Assert.Equal(expected[i], actual2);
                    break;
                case "upgrade":
                    var actual3 = obj.Upgrade(vals[i][0], vals[i][1]);
                    Assert.Equal(expected[i], actual3);
                    break;
                default:
                    break;
            }
        }
    }
}
