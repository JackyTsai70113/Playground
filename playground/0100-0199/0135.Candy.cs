namespace playground;

public class Candy_0135
{
    /// <summary>
    /// https://leetcode.com/problems/candy
    /// </summary>
    public static int Candy(int[] A)
    {
        int n = A.Length, res = n, i = 1;
        while (i < n)
        {
            if (A[i - 1] == A[i])
            {
                i++;
                continue;
            }

            int peek = 0;
            while (i < n && A[i - 1] < A[i])
            {
                peek++;
                res += peek;
                i++;
            }

            int valley = 0;
            while (i < n && A[i - 1] > A[i])
            {
                valley++;
                res += valley;
                i++;
            }

            res -= Math.Min(peek, valley);
        }
        return res;
    }
}
/*
解題思路：
1. 每個人都先發 1 個，之後處理每個人從 0 開始。
2. 將問題視為 valley and peak problem，各迴圈從 valley(0 個糖果)開始，依序是 valley -> peek -> valley。
3. 迴圈內第一步，如果和前一個 rating 相同，則重置到 0 顆糖果。
4. 迴圈內第二步，持續尋找 rating 較高的 peak 並將 peak 加 1, 然後將結果加上 peak。
5. 迴圈內第三步，持續尋找 rating 較低的 valley 並將 valley 減 1, 然後將結果加上 valley。
6. 迴圈內第四步，我們希望下個迴圈要從 0 開始，所以要將結果減掉 min(peak, valley)。
- peak > valley:
    -  1(0),3(1),6(2),8(3),9(4),5(1),3(2)
    -> 1(0),3(1),6(2),8(3),9(4),5(2),3(1)
    -> 1(0),3(1),6(2),8(3),9(4),5(1),3(0)
- peak < valley:
    -  1(0),3(1),9(2),8(1),6(2),5(3),3(4)
    -> 1(1),3(2),9(4),8(3),6(2),5(1),3(0)
    -> 1(0),3(1),9(4),8(3),6(2),5(1),3(0)

-            (5)         (4)                         (3)
-             9           8                           9
-            /|\         /|\                         /|\
-           / | \       / | \                (3)    / | \
-       (4)8  |  5(2)  6  |  5(3)             7 __ 7  |  8(2)
-         /   |   \   (2) |   \              /|   (1) |   \
-        /    |    \ /    |    \            / |    |  |    \         (3)
-    (3)6     |     3     |     4(2)       3(2)    |  |     6 __ 6 __ 6    -> Total candy = 50
-      /      |    (1)    |      \        /   | Reset |    (1)  (1)   |\
-     /       |           |       \      /    |  to 1 |          |    | \
- (2)3        |           |        2 __ 2     |       |          |    |  4(2)
-   /         |           |       (1)  (1)    |       |        Reset  |   \
-  /          |           |                   |       |         to 1  |    \
- 1(1)        |           |                   |       |               |     2(1)
-     peak=max(5,3)  peak=max(3,4)     peak=max(3,0)  |          peak=max(0,3)
-                                                 peak=max(2,3)  
*/