open System
open System.IO


let Lines = File.ReadAllLines (@"/Users/bertrampedersen/Documents/GitHub/Aflevering-9/storeClausLilleClaus.txt")

let list = Seq.toList Lines 
let listLength = List.length list 
let str = list.[0..3]

let strings = ["one";"two";"three"]
let read = str |> List.fold (+) "  "
let sndread = String.concat " " str
let LilleOgStoreKlaus = String.concat " " Lines
let ListSplit = LilleOgStoreKlaus.Split [|' '|]

let words = ListSplit |> Array.filter (fun x -> x = "Claus")
printfn "Liste med ordet Claus:\n %A" words 
printfn "List Split :\n%A" ListSplit
let længde = Array.length ListSplit
for i = 0 to længde-1 do 
    let word = ListSplit.[i]
    let list = ListSplit |> Array.filter (fun x -> x = word)
    let arraylength = list.Length


    let tupple = (list.[0], arraylength)
    // let NewArray = Array.map2 (fun x y -> (x,y) )list NewNewArray
    // printfn "%A" list 
    // printfn "længden af arrayet; %A"  arraylength
    printfn "En tupple som viser ordet, og antal gentagelser: %A" tupple
    // printfn "NewArray: %A" NewArray

