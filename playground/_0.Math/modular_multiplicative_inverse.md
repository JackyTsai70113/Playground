# modulo(模除)

## 性質及恆等式

- 恆等式：
  - $(a \mod n) \mod n = a \mod n$
  - 對所有的正數 $x$ 有：$n^x \mod n = 0$
  - 如果 $p$ 是一個質數，且不為 $b$ 的因數，此時由費馬小定理有：$ab^{p-1} \mod p = a \mod p$
- 逆運算：
  - $[(-a \mod n) + (a \mod n)] = 0 \mod n = 0$
  - $b^{-1} \mod n$ 表示模反元素。若且唯若 $b$ 與 $n$ 互質時，等式左側有定義：
    - $[(b^{-1} \mod n)(b \mod n)] \mod n = 1$
- 分配律：
  - $(a+b) \mod n = (a \mod n) + (b \mod n)$
  - $ab \mod n = [(a \mod n) (b \mod n)] \mod n$
- 除法定義：僅當式子右側有定義時，即 $b$, $n$ 互質時，$\frac{a}{b} \mod n = [(a \mod n) (b^{-1} \mod n)] \mod n$，其他情況為未定義的。
- 乘法逆元：$[(ab \mod n)(b^{-1} \mod n)] \mod n = a \mod n$
