open System.Text.RegularExpressions
/// dette er pt taget fra bogen af Jon Sporring 
let url2stream url = 
    let uri = System.Uri url 
    let request = System.Net.WebRequest.Create uri 
    let response = request.GetResponse () 
    response.GetResponseStream ()

let readURL url = 
    let stream = url2stream url 
    let reader = new System.IO.StreamReader (stream)
    reader.ReadToEnd ()

let url = "http://fsharp.org"
let a = 40

let html = readURL url 

printfn "Downloaded: %A. First %A Charecters are:\n %A" url a html.[0..a]
// printfn "Dette er HTML funktionen:%A" html

let c = Regex "<a href"

let f = c.IsMatch (html)

let e = c.IsMatch "<a href=\"#\">Link tekst</a>"

printfn "Is.match på c: %A" e

printfn "IsMatch på f: %A" f

let str = "<a href"
let strLength = String.length str
let mutable count = 0 
for i = 0 to strLength-1 do 
    let strOut = str.[i..(strLength-1)]
    let strOutLength = String.length strOut
    let strText = str.[i..strLength-1]
    if strText = "href" || strText = "ref" then 
        count <- count+1 
    printfn "String output:%A\nString length: %A\n Counter: %A\n String text: %A" strOut strOutLength count strText


/// Brug String.split til at klare næste opgave. 


let CountLinks (url:string) : int = 
    let link = url 
    let HTML = readURL link 
    let str = "<a href"
    let strLength = str.Length
    let HtmlLength = String.length (HTML)
    let mutable count = 0
    for i = 0 to HtmlLength-1-strLength do
        let strText = HTML.[i..(i+strLength)]
        if strText = str then
            count <- count + 1
    count
printfn "%A"  (CountLinks url)


// let koo = html
// let moo = String.length koo 
// printfn "%A" moo
