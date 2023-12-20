namespace playground.UnitTest;

public class MyLinkedListTest
{
    [Theory]
    [InlineData(
        new string[] { "MyLinkedList", "addAtHead", "addAtTail", "addAtIndex", "get", "deleteAtIndex", "get" },
        "[[], [1], [3], [1, 2], [1], [1], [1]]",
        "[null, null, null, null, 2, null, 3]")]
    [InlineData(
        new string[] { "MyLinkedList", "addAtTail", "addAtHead", "addAtIndex", "get", "deleteAtIndex", "get", "deleteAtIndex", "addAtIndex" },
        "[[], [1], [1], [0, 1], [1], [0], [1], [100], [100, 1]]",
        "[null, null, null, null, 1, null, 1, null, null]")]
    [InlineData(
        new string[] { "MyLinkedList", "addAtTail", "addAtHead", "addAtIndex", "get", "deleteAtIndex", "get" },
        "[[], [1], [3], [1, 2], [1], [1], [1]]",
        "[null, null, null, null, 2, null, 1]")]
    [InlineData(
        new string[] { "MyLinkedList", "addAtHead", "addAtIndex", "addAtTail", "addAtHead", "addAtIndex", "addAtTail", "addAtTail", "addAtIndex", "deleteAtIndex", "deleteAtIndex", "addAtTail" },
        "[[],[0],[1,4],[8],[5],[4,3],[0],[5],[6,3],[7],[5],[4]]",
        "[null,null,null,null,null,null,null,null,null,null,null,null]")]
    [InlineData(
        new string[] { "MyLinkedList", "addAtHead", "addAtTail", "addAtTail", "get", "get", "addAtTail", "addAtIndex", "addAtHead", "addAtHead", "addAtTail", "addAtTail", "addAtTail", "addAtTail", "get", "addAtHead", "addAtHead", "addAtIndex", "addAtIndex", "addAtHead", "addAtTail", "deleteAtIndex", "addAtHead", "addAtHead", "addAtIndex", "addAtTail", "get", "addAtIndex", "addAtTail", "addAtHead", "addAtHead", "addAtIndex", "addAtTail", "addAtHead", "addAtHead", "get", "deleteAtIndex", "addAtTail", "addAtTail", "addAtHead", "addAtTail", "get", "deleteAtIndex", "addAtTail", "addAtHead", "addAtTail", "deleteAtIndex", "addAtTail", "deleteAtIndex", "addAtIndex", "deleteAtIndex", "addAtTail", "addAtHead", "addAtIndex", "addAtHead", "addAtHead", "get", "addAtHead", "get", "addAtHead", "deleteAtIndex", "get", "addAtHead", "addAtTail", "get", "addAtHead", "get", "addAtTail", "get", "addAtTail", "addAtHead", "addAtIndex", "addAtIndex", "addAtHead", "addAtHead", "deleteAtIndex", "get", "addAtHead", "addAtIndex", "addAtTail", "get", "addAtIndex", "get", "addAtIndex", "get", "addAtIndex", "addAtIndex", "addAtHead", "addAtHead", "addAtTail", "addAtIndex", "get",
        "addAtHead", "addAtTail", "addAtTail", "addAtHead", "get", "addAtTail", "addAtHead", "addAtTail", "get", "addAtIndex" },
        "[[],[84],[2],[39],[3],[1],[42],[1,80],[14],[1],[53],[98],[19],[12],[2],[16],[33],[4,17],[6,8],[37],[43],[11],[80],[31],[13,23],[17],[4],[10,0],[21],[73],[22],[24,37],[14],[97],[8],[6],[17],[50],[28],[76],[79],[18],[30],[5],[9],[83],[3],[40],[26],[20,90],[30],[40],[56],[15,23],[51],[21],[26],[83],[30],[12],[8],[4],[20],[45],[10],[56],[18],[33],[2],[70],[57],[31,24],[16,92],[40],[23],[26],[1],[92],[3,78],[42],[18],[39,9],[13],[33,17],[51],[18,95],[18,33],[80],[21],[7],[17,46],[33],[60],[26],[4],[9],[45],[38],[95],[78],[54],[42,86]]",
        "[null,null,null,null,-1,2,null,null,null,null,null,null,null,null,84,null,null,null,null,null,null,null,null,null,null,null,16,null,null,null,null,null,null,null,null,37,null,null,null,null,null,23,null,null,null,null,null,null,null,null,null,null,null,null,null,null,19,null,17,null,null,56,null,null,31,null,17,null,12,null,null,null,null,null,null,null,40,null,null,null,37,null,76,null,42,null,null,null,null,null,null,80,null,null,null,null,43,null,null,null,40,null]")]
    public void MyLinkedList(string[] functions, string valStr, string expectedStr)
    {
        var vals = valStr.To2dArr();
        var expected = expectedStr.ToArr<int?>();
        MyLinkedList_0707 linkedList = new();
        for (int i = 0; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
                case "MyLinkedList":
                    linkedList = new();
                    break;
                case "get":
                    var actual = linkedList.Get(vals[i][0]);
                    Assert.Equal(expected[i].Value, actual);
                    break;
                case "addAtHead":
                    linkedList.AddAtHead(vals[i][0]);
                    break;
                case "addAtTail":
                    linkedList.AddAtTail(vals[i][0]);
                    break;
                case "addAtIndex":
                    linkedList.AddAtIndex(vals[i][0], vals[i][1]);
                    break;
                case "deleteAtIndex":
                    linkedList.DeleteAtIndex(vals[i][0]);
                    break;
                default:
                    break;
            }
        }
    }
}
