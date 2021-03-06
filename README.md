<h2 align="center">Frep</h2>

<div align="center">

[![Status](https://github.com/artipo/frep/actions/workflows/dotnet.yml/badge.svg)]()
[![GitHub Issues](https://img.shields.io/github/issues/artipo/frep.svg)](https://github.com/artipo/frep/issues)
[![GitHub Pull Requests](https://img.shields.io/github/issues-pr/artipo/frep.svg)](https://github.com/artipo/frep/pulls)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](/LICENSE)

</div>

---

<p align="center">Grep-like F# implementation.</p>

## 📝 Table of Contents
- [About](#about)
- [Installation](#installation)
- [Examples](#examples)

## 🧐 About <a name = "about"></a>
_Frep_, as its unix counterpart _Grep_, it's a command-line utility tool that searches for and prints matching patterns found inside one or more files. Frep supports Regular Expressions and wildcards both inside patterns and input files selector.

## 🏁 Installation <a name = "installation"></a>
To install _Frep_ via [.NET Core SDK](https://docs.microsoft.com/en-us/dotnet/core/tools/) use: `dotnet tool install -g frep`.

## 🎈 Examples <a name="examples"></a>
`dotnet frep .com "list-of-sites.txt"`