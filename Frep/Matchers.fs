module Frep.Matchers

open Domain
open System

// base matchers
let matchContains (comparisonType : StringComparison) (pattern : Pattern) (row : Row) =
    row.Contains(pattern, comparisonType)

// resolve matcher
let pickMatcher options : Matcher =
    match options.ShouldIgnoreCase with
    | true -> matchContains StringComparison.CurrentCultureIgnoreCase
    | false -> matchContains StringComparison.CurrentCulture