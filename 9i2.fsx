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
// printfn "List.fold: %s" read 
// printfn "%A" str
// printfn "Second Read: %s" sndread 
// printfn "Lille og Store Klaus :\n %s " LilleOgStoreKlaus
let ListSplit = LilleOgStoreKlaus.Split [|' '|]

let words = ListSplit |> Array.filter (fun x -> x = "Claus")
printfn "Liste med ordet Claus:\n %A" words 
printfn "List Split :\n%A" ListSplit
let længde = Array.length ListSplit
for i = 0 to længde-1 do 
    let word = ListSplit.[i]
    let list = ListSplit |> Array.filter (fun x -> x = word)
    printfn "%A" list 

// let xmd = [|"23";"42";"54";"14";"54";"66";"22"|]

// printfn "Array længde: %A" længde 