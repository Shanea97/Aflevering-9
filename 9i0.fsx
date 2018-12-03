let safeIndexIf (arr: 'a array) (i:int) : 'a =
    printf "Trying to index with number: "
    try 
        printfn "%A" i 
        arr.[i]
    finally 
        printfn "Indexing complete"

printfn "%s" "Assignment 9i0 : SafeIndexIf"
printfn "Index: %A " (try safeIndexIf [|1;2;3;4;5;6|] 2 with ex -> 0 )
printfn "Index: %A\n " (try safeIndexIf [|1;2;3;4;5;6|] 8 with ex -> 0 )
// printfn "Indexing 8 = %s\n" (try (safeIndexIf [|1;2;3;4;5;6|] 8 |> string) with ex -> ex.Message)

let safeIndexTry (arr: 'a array) (i:int) : 'a = 
    try 
        arr.[i]
    with 
        failwith "Shit"

printfn "%s" "Assaignment 9i0: SafeIndexTry"
printfn "%A" (safeIndexTry [|1;2;3;4;5;6|] 2 )
printfn "%A\n" (safeIndexTry [|1;2;3;4;5;6|] 8 ) 

printfn "%s" "Assaignment 9i0: SafeIndexOption"
let safeIndexOption (arr: 'a array) (i:int) : 'a option =
    try 
        Some (arr.[i])
    with 
        | :? System.IndexOutOfRangeException -> None 
let a = (safeIndexOption [|1;2;3;4;5;6|] 7 )
printfn "%A" (safeIndexOption [|1;2;3;4;5;6|] 2 )
printfn "%A" (safeIndexOption [|1;2;3;4;5;6|] 7 )
printfn "Check to see, if SafeIndexOption returns None: %A" a.IsNone

// let a = [|1;2;3;4|]
// let b = a.[2]
// printfn "%A" b