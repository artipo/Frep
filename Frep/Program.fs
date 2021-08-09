module Frep.Program

// domain
open Domain
open Options
open Matchers

// system
open System
open System.IO

// bll
let tryResolve filePath matcher : Result<Row[], string> =
    match (File.Exists(filePath)) with
    | true ->
        File.ReadAllLines(filePath)
        |> Array.filter matcher
        |> Ok
    | false ->
        Error("File does not exists")

let print (message : string) = Console.WriteLine(message)

[<EntryPoint>]
let main argv =
    
    let pattern = argv.[0]
    let filePath = argv.[1]
    
    let resolve = tryResolve filePath
    
    argv
    |> Array.skip 2
    |> parseOptions
    |> pickMatcher
    <| pattern
    |> resolve
    |> function
        | Ok(result) -> result |> Array.iter print
        | Error(errorMessage) -> print errorMessage
    0