# Backtracking(回溯法，原路退回)

- 回溯法是一種通用的演算法，用於尋找某些計算問題的所有（或部分）解。該演算法逐步構建解的候選者，持續透過，設定下一個候選者，探索，回溯的流程尋找解答。
- 由於這種回溯行為，回溯演算法通常比暴力搜索演算法更快，因為它消除了許多不必要的探索。

## template

    ```csharp
    void Bt(candidate, result){
        if(any next_candidate is invalid){
            if(find solution(candidate)){
                result add candidate
            }
            return;
        }
        for(next_candidate in list_of_candidates){
            if(valid(next_candidate)){
                place(next_candidate)  // 尋找這部分解的候選者
                Bt(next_candidate)     // 再給定候選者的情況下，進一步探索。
                remove(next_candidate) // 回溯
            }
        }
    }
    ```

- 候選者的列舉分為兩個層級
  1. 第一層級，函數裡面透過遞迴尋找下一個候選者，每一次的遞迴，函數都會更接近最終解。
  2. 第二層級，遞迴裡面我們透過迭代，允許我們尋找符合最終解的候選人
