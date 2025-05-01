namespace playground.LeetCode._0000_0999;

public class _0355_Twitter
{
    readonly Dictionary<int, HashSet<int>> _userToFollowers = new();
    readonly Dictionary<int, List<(int tweetId, int time)>> _userToTweets = new();
    int _tweetCount = 0;

    public _0355_Twitter()
    {
        _tweetCount = 0;
    }

    /// <summary>
    /// Composes a new tweet with ID tweetId by the user userId. Each call to this function will be made with a unique tweetId.
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="tweetId"></param>
    public void PostTweet(int userId, int tweetId)
    {
        if (!_userToTweets.ContainsKey(userId))
            _userToTweets[userId] = new();
        _userToTweets[userId].Add((tweetId, _tweetCount++));
    }

    /// <summary>
    /// Retrieves the 10 most recent tweet IDs in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user themself. Tweets must be ordered from most recent to least recent.
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public IList<int> GetNewsFeed(int userId)
    {
        List<(int tweetId, int time)> res = new();
        if (_userToTweets.ContainsKey(userId))
        {
            res.AddRange(_userToTweets[userId]);
        }
        if (_userToFollowers.ContainsKey(userId))
        {
            foreach (var followerId in _userToFollowers[userId])
            {
                if (_userToTweets.ContainsKey(followerId))
                {
                    res.AddRange(_userToTweets[followerId]);
                }
            }
        }
        return res.OrderByDescending(x => x.time).Take(10).Select(x => x.tweetId).ToList();
    }

    /// <summary>
    /// The user with ID followerId started following the user with ID followeeId.
    /// </summary>
    /// <param name="followerId"></param>
    /// <param name="followeeId"></param>
    public void Follow(int followerId, int followeeId)
    {
        if (!_userToFollowers.ContainsKey(followerId))
        {
            _userToFollowers[followerId] = new();
        }
        _userToFollowers[followerId].Add(followeeId);
    }

    /// <summary>
    /// The user with ID followerId started unfollowing the user with ID followeeId.
    /// </summary>
    /// <param name="followerId"></param>
    /// <param name="followeeId"></param>
    public void Unfollow(int followerId, int followeeId)
    {
        if (_userToFollowers.ContainsKey(followerId))
        {
            _userToFollowers[followerId].Remove(followeeId);
        }
    }
}

