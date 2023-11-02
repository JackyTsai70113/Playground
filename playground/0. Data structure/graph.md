# graph

## Minimum Spanning Tree(MST, 最小生成樹)

考慮一個connected、weighted的undirected graph，定義 Spanning Tree：

- 連結所有的 graph 的 vertex
- 沒有 cycle
- 若有 V 個 vertext，則只有 V-1 條 edge

Minimum Spanning Tree(MST)

- Spanning Tree 中，最小 weight 總和的 Tree
- 由於 weight 只要求是實數，且不要求 每一個 weight 是唯一，Graph 的 MST 可能不唯一
- 由於 MST 只要求「最小 weight 總和」，因此 `root` 是哪一個 vertex、樹是否平衡、height是否夠小、等問題皆不在必要的考慮範圍內。
