# Median(中位數)

### 問題
- 維護一個動態的數列，支援以下操作：
  - 插入數字
  - 刪除數字
  - 隨時查詢中位數


### 解法
- 若 list 有 k 個元素，我們使用兩個 heap，low 為 maxheap, [0,k/2], high 為 minheap, [k/2,k]
- median 即為 (k%2==0 ? (low.Peek() + high.Peek()) / 2 : high)
- 增加的方式：
  - 如果 low.Count 和 high.Count 相同，則放入 low 再拿一個出來，放到 high。故 high 會多一個。
  - 否則 則放入 high 再拿一個出來，放到 low。故 low 會多一個。
- 減少的方式：
  - 設置一個 dictionary 記錄刪除元素。
  - `dict[element_to_delete] += 1`
  - 如果 element_to_delete 大於 low.Peek()，那 low 先拿一個 high.Peek()
  - 如果 low.Peek() 是被記錄要刪除的就要拿掉，並且從 dict 減少
  - 如果 high.Peek() 是被記錄要刪除的就要拿掉，並且從 dict 減少

### 題目與應用
  - leetcode#0295
  - leetcode#0480