let x = 10
let y = 20

let add x y = 
    let newX = x + y
    let newY = y + newX
    (newX, newY)

let newX, newY = add x y
printf "%d %d %d %d" x y newX newY