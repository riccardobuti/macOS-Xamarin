# Mac App with Xamarin

Bootstrap of a Cocoa Mac Application using Xamarin

## Requirements

* Xamarin Studio Community 6.0.1 (build 9)
* Xcode 7.3.1
* OSX 10.10 or higher

## Installation

To compile/run the application:
* open the solution with Xamarin Studio (macOS.sln)
* set macOS as the startup project (if it is not already)
* run by pressing Play or by pressing [Cmd + Enter]

## Project

The project is composed by three components:
* the mac application - macOS
* a pcl library - pclLibrary
* a pcl library test - pclLibrary

The pcl library contains all the code that is not dependent on the mac platform and that can be reused by other applications.

## Tests

To run the tests from the command line:
* build the pcl library 
* build the pcl library tests
* run the following command

```sh
mono packages/xunit.runner.console.2.1.0/tools/xunit.console.exe pclLibraryTests/bin/Debug/pclLibraryTests.dll
```
