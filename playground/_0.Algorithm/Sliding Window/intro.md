# Sliding Window

- 可以透過兩個 pointer 和 一個 hashmap 來尋找在限制底下的 substring

## template

    ```csharp
    int FindSubstring(string s){
        var chs = new int[128]; // hash map


        foreach(var c in s){
            // initialize the hash map
            // ex: chs[c]++;
        }
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
