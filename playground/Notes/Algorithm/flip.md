# flip count

- Example
  - 給定 tops =  [2, 1, 2, 4, 2, 2], bottoms = [5, 2, 6, 2, 3, 2], 求 flip 後 tops 或是 bottoms 皆相同的個數
- 對於任一 index i, 只需檢查 tops[0] 或是 bottoms[0] 就好，其餘狀況代表無法成功
- 對於任一 index i, 皆須檢查其反轉的狀況。意思是不能只考慮 i > 0 時, tops[0] != tops[i] 的狀況，因為 tops[0] 也是可以反轉的。
- More challenges
  - 302. Smallest Rectangle Enclosing Black Pixels
  - 2091. Removing Minimum and Maximum From Array
  - 2470. Number of Subarrays With LCM Equal to K