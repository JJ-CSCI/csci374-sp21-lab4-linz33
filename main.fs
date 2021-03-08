module Assignment

// Problem 1
let rec prod (lst:int list) =
    if list.isEmpty lst
		then 0
		else list.Head list * prod(list.tail lst)
sgn prod

// Problem 2
let rec map f (lst:int list) =
    [] -> []
		Head :: Tail (f Head) :: (map f Tail)

// Problem 3
let rec odd (lst:int list) =
    if head % 2 = 1 -> (odd tail list)
		else odd(lst+1)

// Problem 4
let rec filter f lst =
    // write your solution here
    lst
