open System

#load "Domain.fs"
#load "Options.fs"
#load "Matchers.fs"

open Frep.Domain
open Frep.Options
open Frep.Matchers

// code

// tests
let text1 = "Hello World!"
let text2 = "Hi World!"

let match_ignoreCase_contains_hello = matchContains StringComparison.InvariantCultureIgnoreCase "Hello" 

match_ignoreCase_contains_hello text1 // should be true
match_ignoreCase_contains_hello text2 // should be false

