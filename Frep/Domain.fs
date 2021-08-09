module Frep.Domain

// domain types
type Pattern = string
type Row = string

type Options = { ShouldIgnoreCase: bool }

// fun types
type Matcher = Pattern -> Row -> bool