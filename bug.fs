let mutable x = 1
let mutable y = 2
let z = x + y
printf "%d" z
x <- 3
printf "%d" z // z still prints 3, not 4

//This demonstrates that let mutable does not change the value of variables that depend on it. The solution is to use ref cells instead.