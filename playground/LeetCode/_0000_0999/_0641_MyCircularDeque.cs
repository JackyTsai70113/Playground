namespace playground.LeetCode._0000_0999;

public class _0641_MyCircularDeque
{
    private int volumn;
    private int count;
    private LinkedList first;
    private LinkedList last;
    public _0641_MyCircularDeque(int k)
    {
        volumn = k;
        count = 0;
    }

    public bool InsertFront(int value)
    {
        if (count == volumn)
        {
            return false;
        }
        var node = new LinkedList(value);
        if (count == 0)
        {
            first = node;
            last = node;
        }
        else
        {
            first.prev = node;
            node.next = first;
            first = node;
            if (count == 1)
            {
                last.prev = node;
            }
        }
        count++;
        return true;
    }

    public bool InsertLast(int value)
    {
        if (count == volumn)
        {
            return false;
        }
        var node = new LinkedList(value);
        if (count == 0)
        {
            first = node;
            last = node;
        }
        else
        {
            last.next = node;
            node.prev = last;
            last = node;
            if (count == 1)
            {
                first.next = node;
            }
        }
        count++;
        return true;
    }

    public bool DeleteFront()
    {
        if (count == 0)
        {
            return false;
        }
        if (count == 1)
        {
            first = null;
            last = null;
        }
        else
        {
            first.next.prev = null;
            first = first.next;
        }
        count--;
        return true;
    }

    public bool DeleteLast()
    {
        if (count == 0)
        {
            return false;
        }
        if (count == 1)
        {
            first = null;
            last = null;
        }
        else
        {
            last.prev.next = null;
            last = last.prev;
        }
        count--;
        return true;
    }

    public int GetFront()
    {
        if (count == 0)
        {
            return -1;
        }
        else
        {
            return first.val;
        }
    }

    public int GetRear()
    {
        if (count == 0)
        {
            return -1;
        }
        else
        {
            return last.val;
        }
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public bool IsFull()
    {
        return count == volumn;
    }

    public class LinkedList
    {
        public LinkedList prev;
        public LinkedList next;

        public int val;
        public LinkedList(int val = 0, LinkedList prev = null, LinkedList next = null)
        {
            this.val = val;
            this.prev = prev;
            this.next = next;
        }
    }
}
