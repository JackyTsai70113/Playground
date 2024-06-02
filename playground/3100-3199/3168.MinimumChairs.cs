namespace playground;

public class MinimumChairs3168
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-chairs-in-a-waiting-room
    /// </summary>
    public static int MinimumChairs(string s)
    {
        int chair = 0, people = 0;
        foreach (var c in s)
        {
            if (c == 'E')
                people++;
            else
                people--;
            chair = Math.Max(chair, people);
        }
        return chair;
    }
}
