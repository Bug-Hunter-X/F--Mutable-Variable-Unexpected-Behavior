let x = ref 1
let y = ref 2
let z = (!x) + (!y)
printf "%d" z
x := 3
printf "%d" z // z now prints 5

//Using ref cells ensures that dependent values are updated when mutable variables change.