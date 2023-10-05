using playground.Design;

namespace playground.UnitTest.Design;

public class MyHashMapTest
{
    [Theory]
    [InlineData(new string[] { "MyHashMap", "put", "put", "get", "get", "put", "get", "remove", "get" }, "[[], [1, 1], [2, 2], [1], [3], [2, 1], [2], [2], [2]]", new string[] { null, null, null, "1", "-1", null, "1", null, "-1" })]
    [InlineData(
        new string[] { "MyHashMap", "put", "put", "put", "get", "get" },
        "[[], [1, 2], [1, 1], [1001, 1], [1], [1001]]",
        new string[] { null, null, null, null, "1", "1" })]
    [InlineData(
        new string[] { "MyHashMap", "put", "put", "put", "remove", "remove", "remove", "remove" },
        "[[], [1, 1], [1001, 1], [2001, 1],[2001], [1001], [1], [1]]",
        new string[] { null, null, null, null, null, null, null })]
    public void MyHashMap(string[] funcs, string valArr, string[] expected)
    {
        var vals = valArr.To2dArr();
        MyHashMap myHashMap = new();
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "put":
                    myHashMap.Put(vals[i][0], vals[i][1]);
                    break;
                case "get":
                    Assert.Equal(int.Parse(expected[i]), myHashMap.Get(vals[i][0]));
                    break;
                case "remove":
                    myHashMap.Remove(vals[i][0]);
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
