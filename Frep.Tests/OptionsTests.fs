module OptionsTests

open Xunit
open Frep.Domain
open Frep.Options

[<Fact>]
let ``shouldIgnoreCase with valid inputs`` () =
    let res = shouldIgnoreCase [| "-i" |]
    Assert.True(res)

    let res = shouldIgnoreCase [| "--ignore-case" |]
    Assert.True(res)

[<Fact>]
let ``shouldIgnoreCase with invalid inputs`` () =
    let res = shouldIgnoreCase [| "-ia" |]
    Assert.False(res)

    let res = shouldIgnoreCase [| "--ignore--case" |]
    Assert.False(res)

    let res = shouldIgnoreCase [| "" |]
    Assert.False(res)

[<Fact>]
let ``parseOptions with valid inputs`` () =
    let res = parseOptions [| "-i" |]
    Assert.Equal({ ShouldIgnoreCase = true }, res)
    
    let res = parseOptions [| "--ignore-case" |]
    Assert.Equal({ ShouldIgnoreCase = true }, res)
    
    let res = parseOptions [| |]
    Assert.Equal({ ShouldIgnoreCase = false }, res)
    
    let res = parseOptions [| "-p" |]
    Assert.Equal({ ShouldIgnoreCase = false }, res)

[<Fact>]
let ``parseOptions with invalid inputs`` () =
    let res = parseOptions [| "-ia" |]
    Assert.Equal({ ShouldIgnoreCase = false }, res)
    
    let res = parseOptions [| "--ignore--case" |]
    Assert.Equal({ ShouldIgnoreCase = false }, res)