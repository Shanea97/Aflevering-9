// let safeIndexIf (arr: 'a array) (i:int) : 'a =
//     if i > arr.Length then 
//        arr.[i]
//     else 
//         arr.[i]
// printfn "%A" (safeIndexIf [|1;2;3;4;5;6;7;8;9;10|] 2)
// printfn "%A" (safeIndexIf [|1;2;3;4;5;6;7;8;9;10|] 50)

// let safeIndexTry (arr: 'a array) (i:int) : 'a = 
//     try 
//         arr.[i]
//     with 
//         | ex when i > arr.Length -> ex.Message

// let abc = (safeIndexTry [|"1";"2";"3";"4";"5";"6";"7"|] 2 )
// // printfn "%s" "Assaignment 9i0: SafeIndexTry"
// printfn "%A" abc
// printfn "%A\n" (safeIndexTry [|"1";"2";"3";"4";"5";"6";"7"|] 50 ) 
// /// Jeg har ingen ide om hvordan jeg skal få det til at virke med alle typer .... 

open System
open System.IO

let filename = File.Create "Filnavn123.txt"
let text = StreamWriter "Hej med dig"
text
filename