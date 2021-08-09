module Frep.Tests.MatchersTests

open Xunit
open Frep.Domain
open Frep.Matchers
open System

[<Fact>]
let ``matchContains with valid inputs`` () =
    let res = matchContains StringComparison.CurrentCulture "Hello" "Hello World!"
    Assert.True(res)
    
    let res = matchContains StringComparison.CurrentCulture "hello" "hello world!"
    Assert.True(res)
    
    let res = matchContains StringComparison.CurrentCulture "hello" "Hello world!"
    Assert.False(res)
    
    let res = matchContains StringComparison.CurrentCultureIgnoreCase "hello" "Hello world!"
    Assert.True(res)

[<Fact>]
let ``matchContains with empty pattern`` () =
    let res = matchContains StringComparison.CurrentCulture "" "Hello World!"
    Assert.True(res)
    
[<Fact>]
let ``pickMatcher with valid inputs`` () =
    let res = pickMatcher { ShouldIgnoreCase = true } "hello" "Hello World!"
    Assert.True(res)
    
    let res = pickMatcher { ShouldIgnoreCase = false } "hello" "Hello World!"
    Assert.False(res)