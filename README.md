# F# Mutable Variable Unexpected Behavior

This repository demonstrates a common, yet subtle, issue in F# related to the use of `let mutable` and its interaction with expressions. The code in `bug.fs` shows that simply changing a mutable variable doesn't automatically update expressions that depend on it.  The solution in `bugSolution.fs` illustrates the correct approach using `ref` cells to achieve the desired behavior.