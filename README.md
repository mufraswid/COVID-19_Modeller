# COVID-19 Spread Modeller
__Spread modeller made using C# Language__ <br>
A group project for Algorithm Startegy assessment.

## Description
This is an application built using WPF on Visual Studio with C# and .Net Framework 4.8 to model the [COVID-19 virus spread](https://www.who.int/emergencies/diseases/novel-coronavirus-2019) using BFS Algorithm. The Graph modelled in the app is built using Microsoft Automatic Graph Layout ([MSAGL](https://github.com/microsoft/automatic-graph-layout)), a .NET library and tool to make graphs. It models the spread using Breadth First Search algorithm, with cities infected represented as nodes and their connectivites as edges on a graph.

## How to build

### Requirements
1. Visual Studio (recommended using 2019, the app is developed using VS2019) with C# Desktop App Package in VS
2. .NET Framework (v.4.8)

### Build steps
1. Open Project using Visual Studio 
2. In Solution Explorer, right click and select 'Batch Build'
3. Check the Production Build (if needed you can try the Debug option)
4. Click 'Build' button on the right side of the window
5. Now the build should have relative path from this project directory
      
        WpfApp1/bin/

    There should be Release and Debug version for which version that you have been checked.

## How to run

### Windows
1. Navigate to bin directory
2. Run `WpfApp1.exe`
3. Enjoy

### Linux
1. [Install .NET](https://docs.microsoft.com/en-us/dotnet/core/install/) in your Linux with the respective Linux package manager. 
2. [Install WINE](https://www.winehq.org/) for your Linux distro to run the windows exec file.
3. If for some reason you cannot run the executable with WINE, install .NET for WINE [here](https://appdb.winehq.org/objectManager.php?sClass=application&iId=2586).
4. Run `WpfApp1.exe` with WINE. Enjoy!


## How to use

<b>Prerequisite: </b>You should have open the program from the instruction before!

1. Select Place (Node) with press the button, and then select apropriate .txt file
2. Do the same for Route (Edge) with pressing other button there.
3. Input the days after first infection on given fields and press the button.
4. The result's graph now should have appeared in the middle window, followed by the step/path of the infection in the right side.

