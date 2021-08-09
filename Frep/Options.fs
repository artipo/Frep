module Frep.Options

open Domain

// -i --ignore-case
let shouldIgnoreCase argv =
    argv
    |> Array.exists (fun o -> o = "-i" || o = "--ignore-case")

let parseOptions argv =
    { ShouldIgnoreCase = shouldIgnoreCase argv }
