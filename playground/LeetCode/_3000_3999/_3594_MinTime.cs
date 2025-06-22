namespace playground.LeetCode._3000_3999;

public class _3594_MinTime
{
    private int _n;
    private int _k;
    private int _m;
    private int[] _time;
    private double[] _mul;
    private Dictionary<(int mask, int stage, int boatLocation), double> _minTime;
    private SortedSet<(double time, int mask, int stage, int boatLocation)> _pq;

    // Custom comparer for the SortedSet (priority queue)
    private static readonly Comparer<(double time, int mask, int stage, int boatLocation)> _pqComparer =
        Comparer<(double time, int mask, int stage, int boatLocation)>.Create((a, b) =>
        {
            int cmp = a.time.CompareTo(b.time);
            if (cmp != 0) return cmp;
            cmp = a.mask.CompareTo(b.mask);
            if (cmp != 0) return cmp;
            cmp = a.stage.CompareTo(b.stage);
            if (cmp != 0) return cmp;
            return a.boatLocation.CompareTo(b.boatLocation);
        });

    public double MinTime(int n, int k, int m, int[] time, double[] mul)
    {
        if (k == 1 && n > 1)
        {
            return -1.0;
        }

        _n = n;
        _k = k;
        _m = m;
        _time = time;
        _mul = mul;
        _minTime = new Dictionary<(int mask, int stage, int boatLocation), double>();
        _pq = new SortedSet<(double time, int mask, int stage, int boatLocation)>(_pqComparer);

        int initialMask = (1 << _n) - 1;
        _minTime[(initialMask, 0, 0)] = 0.0;
        _pq.Add((0.0, initialMask, 0, 0));

        while (_pq.Count > 0)
        {
            var current = _pq.Min;
            _pq.Remove(current);

            double currentTime = current.time;
            int currentMask = current.mask;
            int currentStage = current.stage;
            int currentBoatLocation = current.boatLocation;

            if (_minTime.ContainsKey((currentMask, currentStage, currentBoatLocation)) && currentTime > _minTime[(currentMask, currentStage, currentBoatLocation)])
            {
                continue;
            }

            if (currentMask == 0)
            {
                return currentTime;
            }

            if (currentBoatLocation == 0)
            {
                HandleBoatCrossing(currentTime, currentMask, currentStage);
            }
            else
            {
                HandleBoatReturning(currentTime, currentMask, currentStage);
            }
        }

        return -1.0;
    }

    /// <summary>
    /// Handles the scenario where the boat is at the starting side (location 0)
    /// and a group of people needs to cross.
    /// </summary>
    private void HandleBoatCrossing(double currentTime, int currentMask, int currentStage)
    {
        for (int groupBitmask = 0; groupBitmask < (1 << _n); groupBitmask++)
        {
            if ((groupBitmask & currentMask) != groupBitmask)
            {
                continue;
            }

            int groupSize = 0;
            int maxTimeInGroup = 0;

            for (int personIdx = 0; personIdx < _n; personIdx++)
            {
                if (((groupBitmask >> personIdx) & 1) == 1)
                {
                    groupSize++;
                    maxTimeInGroup = Math.Max(maxTimeInGroup, _time[personIdx]);
                }
            }

            if (groupSize == 0 || groupSize > _k)
            {
                continue;
            }

            double crossingDuration = maxTimeInGroup * _mul[currentStage];
            int nextStage = (currentStage + (int)Math.Floor(crossingDuration)) % _m;

            int nextMask = currentMask ^ groupBitmask;
            int nextBoatLocation = 1;

            double newTotalTime = currentTime + crossingDuration;

            TryUpdateState(newTotalTime, nextMask, nextStage, nextBoatLocation);
        }
    }

    /// <summary>
    /// Handles the scenario where the boat is at the destination side (location 1)
    /// and a single person needs to return the boat to the starting side.
    /// </summary>
    private void HandleBoatReturning(double currentTime, int currentMask, int currentStage)
    {
        for (int personIdx = 0; personIdx < _n; personIdx++)
        {
            if (((currentMask >> personIdx) & 1) == 0)
            {
                double returnDuration = _time[personIdx] * _mul[currentStage];
                int nextStage = (currentStage + (int)Math.Floor(returnDuration)) % _m;

                int nextMask = currentMask | (1 << personIdx);
                int nextBoatLocation = 0;

                double newTotalTime = currentTime + returnDuration;

                TryUpdateState(newTotalTime, nextMask, nextStage, nextBoatLocation);
            }
        }
    }

    /// <summary>
    /// A helper method to update the Dijkstra's distance (minTime) and add/update the priority queue.
    /// </summary>
    private void TryUpdateState(double newTotalTime, int nextMask, int nextStage, int nextBoatLocation)
    {
        var nextState = (nextMask, nextStage, nextBoatLocation);
        if (!_minTime.ContainsKey(nextState) || newTotalTime < _minTime[nextState])
        {
            _minTime[nextState] = newTotalTime;
            _pq.Add((newTotalTime, nextMask, nextStage, nextBoatLocation));
        }
    }
}