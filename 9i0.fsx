
let safeIndexIf (arr: 'a array) (i:int) : 'a =
    if i > arr.Length then 
       arr.[i]
    else 
        arr.[i]
printfn "%s" "Assaignment 9i0: SafeIndexIf"
printfn "%A" (safeIndexIf [|1;2;3;4;5;6;7;8;9;10|] 2)
printfn "%A" (safeIndexIf [|1;2;3;4;5;6;7;8;9;10|] 50)

let safeIndexTry (arr: 'a array) (i:int) : 'a = 
    try 
        arr.[i]
    with 
        | ex when i > arr.Length -> ex.Message

let abc = (safeIndexTry [|"1";"2";"3";"4";"5";"6";"7"|] 2 )
printfn "%s" "Assaignment 9i0: SafeIndexTry"
printfn "%A" abc
printfn "%A\n" (safeIndexTry [|"1";"2";"3";"4";"5";"6";"7"|] 50 ) 
/// Jeg har ingen ide om hvordan jeg skal få det til at virke med alle typer .... ) 

// /// let safeIndextry (arr: 'a array) (i:int) : 'a =
//     printf "Trying to index with number: "
//     try 
//         printfn "%A" i 
//         arr.[i]
//     finally  
//         printfn "Indexing complete"

// printfn "%s" "Assignment 9i0 : SafeIndexIf"
// printfn "Index: %A " (try safeIndexIf [|1;2;3;4;5;6|] 2 with ex -> 0 )
// printfn "Index: %A\n " (try safeIndexIf [|1;2;3;4;5;6|] 8 with ex -> 0 )

// Ovenover ses en funktion som bruger Try og With nede i print satementet.. Ved ikke om dette er en mulighed man eller skal gøre det på.. Ellers er jeg nok på bar bund.


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