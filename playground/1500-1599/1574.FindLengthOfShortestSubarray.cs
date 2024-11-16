namespace playground._1500_1599;

public class _1574_FindLengthOfShortestSubarray
{
    public int FindLengthOfShortestSubarray(int[] arr) {
        var list = new List<int[]>();
        int left = arr.Length, right = 0;
        int last = 0;
        for(int i = 0; i<arr.Length; i++){
            int index = BS(list, last, arr[i]);
            if(index != last){
                left = Math.Min(left, list[index][1]);
                right = Math.Max(right, i);
                list[index]=new int[]{arr[i], i};
            } else {
                list.Add(new int[]{arr[i], i});
            }
            last = index+1;
        }
        return left == arr.Length ? 0 : right-left;
    }
    
    public int BS(List<int[]> list, int r, int val){
        int l = 0;
        while(l<r){
            int m = l+(r-l)/2;
            if(list[m][0]>val)
                r=m;
            else
                l=m+1;
        }
        return l;
    }
}
