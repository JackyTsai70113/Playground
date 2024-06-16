# Segment Tree

- balance binary tree. `O(logN)` height given n elements.

## Example

```csharp
var nums = new int[] {2,1,5,3,4}
```

```mermaid
flowchart TD
A[15, 0-4] --> B[8, 0-2]
A --> C[7,3-4]
B --> D[3,0-1]
B --> E[5, 2-2]
C --> F[3, 3-3]
C --> G[4, 4-4]
D --> H[2, 0-0]
D --> I[1, 1-1]
```

## Operations

1. build(`O(N)`)
1. update(`O(logN)`)
1. range query(`O(logN + k)`), k: number of reported segments
