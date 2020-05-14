# _Numbers to Words_

#### _Epicodus Project May 14, 2020_

#### By _**Jessica Hvozdovich and Eric Settels**_

## Description

_A project to introduce the C# language and the .NET Core framework. The console application will act as a translator between numeric integers to written words. The lesson is meant to practice creating automated testing methods using MSTest and behavior driven development._

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the command dotnet run.

## Known Bugs

Functionality has not yet been achieved for multiple digit numbers.

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/jhvozdovich/numbers-to-words/issues) here on GitHub._

## Technologies Used

* C#
* .NET Core
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User enters a single digit number and is given a word** | User Input:”1” | Output: "one" |
| **User enters a number between 10 and 19 and is given a word** | User Input:”17” | Output: "seventeen" |
| **User enters a number between 20 and 99 and is given a word** | User Input:”42” | Output: "forty two" |
| **User enters a number between 100 and 999 and is given a value** | User Input:”713” | Output: "seven hundred thirteen" |
| **User enters a number between 1000 and 9999 and is given a value** | User Input:”7839” | Output: "seven thousand eight hundred thirty nine" |

### License
This software is licensed under the MIT license.

Copyright (c) 2020 **_Jessica Hvozdovich and Eric Settels_**