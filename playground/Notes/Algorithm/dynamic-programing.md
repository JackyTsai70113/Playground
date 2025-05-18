# Dynamic Programing

## Steps（以 Rod cutting 為例）

1. [Recursive] 描述問題的最基本架構和轉移邏輯，寫出遞迴
   - 「如果我知道子問題的答案，我該怎麼解原問題？」
   - ex: `f(n) = max(price[0]+f(n-1), price[1]+f(n-2), ...)`
   - 暴力解
2. [State] 決定狀態該怎麼定義，辨識狀態
   - 「有哪些參數是遞迴時會變化的？」
   - ex: `f(i)` 中的 `i` 是長度，`f(i)` 是該長度最大價值
3. [Memoize] 避免重複運算，記憶化已運算的結果
   - 「這個子問題是否會重複遇到? 有的話記錄運算結果」
   - ex: `f(1)`,`f(2)`,`f(3)` 皆為重複運算的結果
   - top-down with memoization
4. [Iteration] 找出狀態之間的依賴順序，轉為迭代
   - 避免 stack overflow，提升穩定性與效率
   - ex: 先計算`f(1)`，這樣`f(2)`可以用，算完`f(2)`，可以算`f(3)`
   - bottom-up with tabulation
5. [Optimization] 確認能否透過重建路徑節省空間
   - 「空間壓縮？可重複使用變數？」
   - 「可以從 `O(n^2)` 優化為 `O(n)` 嗎？是否能使用 rolling array？」
   - try to save memory

[Recursion] → [StateDefinition] → [Memoization] → [Iterative] → [Optimization]