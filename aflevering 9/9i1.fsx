open System.Text.RegularExpressions
open System
open System.IO
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



/// Brug String.split til at klare næste opgave. 

/// <param name "url">
/// url functions as a string, in the form of a website domain
/// </param name>
/// <summary>
/// The functions uses some functions given in the book "Learning to program with F# - Jon sporring" where he gives examples. Else it uses a string to check, via a for-loop, if there exists any strings withing the HTML-code identical to the check, and sets the counter to +1. 
/// </summary>
/// <returns> 
/// returns number of times a given string is represented in the code by Integer 
/// </returns>

let CountLinks (url:string) : int = 
    let link = url 
    let HTML = readURL link 
    let str = "<a href"
    let strLength = str.Length
    let HtmlLength = String.length (HTML)
    let mutable count = 0
    for i = 0 to HtmlLength-1-strLength do
        let strText = HTML.[i..(i+strLength-1)]
        if strText = str then
            count <- count + 1
    count
printfn "How many matches do we get on (<a href): %A"  (CountLinks url)



/// Kan umiddelbart ikke finde svare på hvorfor at denne ikke burde virke ?
