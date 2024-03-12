namespace playground.UnitTest;

public class TwitterTest0355
{
    [Theory]
    [InlineData(new string[] { "Twitter", "postTweet", "getNewsFeed", "follow", "postTweet", "getNewsFeed", "unfollow", "getNewsFeed" }, "[[], [1, 5], [1], [1, 2], [2, 6], [1], [1, 2], [1]]", new string[] { "null", "null", "[5]", "null", "null", "[6, 5]", "null", "[5]" })]
    [InlineData(new string[] { "Twitter", "follow", "getNewsFeed" }, "[[],[1,5],[1]]", new string[] { "null", "null", "[]" })]
    public void FrequencyTracker(string[] funcs, string valStr, string[] expected)
    {
        var vals = valStr.To2dArr();
        Twitter0355 twitter = new();
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "postTweet":
                    twitter.PostTweet(vals[i][0], vals[i][1]);
                    break;
                case "getNewsFeed":
                    Assert.Equal(expected[i].ToArr(), twitter.GetNewsFeed(vals[i][0]));
                    break;
                case "follow":
                    twitter.Follow(vals[i][0], vals[i][1]);
                    break;
                case "unfollow":
                    twitter.Unfollow(vals[i][0], vals[i][1]);
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
