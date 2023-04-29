using playground.UnionFind;
using playground.UnitTest.Utils;

namespace playground.UnitTest.UnionFind;

public class DistanceLimitedPathsExistTest
{
    [Theory]
    // [InlineData(3, "[[0,1,2],[1,2,4],[2,0,8],[1,0,16]]", "[[0, 1, 2],[0, 2, 5]]", "[false,true]")]
    // [InlineData(5, "[[2,3,88],[1,3,9],[4,2,25],[3,4,11]]", "[[2,1,73]]", "[true]")]
    // [InlineData(13, "[[9,1,53],[3,2,66],[12,5,99],[9,7,26],[1,4,78],[11,1,62],[3,10,50],[12,1,71],[12,6,63],[1,10,63],[9,10,88],[9,11,59],[1,4,37],[4,2,63],[0,2,26],[6,12,98],[9,11,99],[4,5,40],[2,8,25],[4,2,35],[8,10,9],[11,9,25],[10,11,11],[7,6,89],[2,4,99],[10,4,63]]", "[[9,7,65],[9,6,1],[4,5,34],[10,8,43],[3,7,76],[4,2,15],[7,6,52],[2,0,50],[7,6,62],[1,0,81],[4,5,35],[0,11,86],[12,5,50],[11,2,2],[9,5,6],[12,0,95],[10,6,9],[9,4,73],[6,10,48],[12,0,91],[9,10,58],[9,8,73],[2,3,44],[7,11,83],[5,3,14],[6,2,33]]", "[true,false,false,true,true,false,false,true,false,true,false,true,false,false,false,true,false,true,false,true,true,true,false,true,false,false]")]
    [InlineData(30, "[[9,14,88],[11,27,51],[29,22,58],[29,27,26],[18,20,97],[25,4,12],[2,4,16],[17,18,40],[21,9,37],[3,14,6],[8,23,24],[7,27,39],[24,16,95],[9,29,19],[9,18,22],[26,21,12],[12,14,81],[6,14,79],[3,16,47],[13,19,18],[24,15,59],[14,20,26],[24,20,14],[25,26,7],[13,12,81],[1,0,51],[17,4,39],[8,16,77],[28,9,53],[23,6,40],[29,18,31],[10,9,35],[29,27,7],[1,29,91],[10,19,70],[28,29,58],[20,17,86],[21,14,77],[19,4,43],[26,21,22],[2,26,61],[24,22,16]]", "[[21,10,1],[14,2,21],[15,11,64],[21,27,17],[3,26,1],[26,18,93],[8,6,5],[18,19,62],[19,18,30],[7,25,76],[0,20,78],[11,6,16],[16,2,91],[22,21,66],[28,24,95],[19,4,18],[14,23,37],[19,27,7],[15,10,83],[23,5,59],[17,12,9],[26,5,90],[26,24,46],[21,29,30],[24,18,54],[27,3,94],[1,23,75],[28,22,75],[27,11,32],[11,20,62],[12,11,10],[17,14,4],[27,22,67],[19,0,25],[16,24,38],[23,6,35],[11,21,96],[28,14,38],[29,17,8],[10,21,85],[2,27,97],[25,13,98]]", "[false,false,true,false,false,true,false,true,false,true,false,false,true,true,true,false,false,false,true,false,false,false,false,false,false,true,false,true,false,true,false,false,true,false,false,false,true,false,false,true,true,true]")]
    public void DistanceLimitedPathsExist(int n, string edgeListArr, string queriesArr, string expectedArr)
    {
        var edgeList = edgeListArr.To2dArr<int>();
        var queries = queriesArr.To2dArr<int>();
        var actual = DistanceLimitedPathsExistClass.DistanceLimitedPathsExist(n, edgeList, queries);
        Assert.Equal(expectedArr.ToArr<bool>(), actual);
    }
}
