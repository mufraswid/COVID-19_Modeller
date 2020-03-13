# Tubes2_STIMA 

Using WPF on Visual Studio with C# and .Net Framework 4.8

## Description
----------
This is an application built with C# and Visual Studio to model the [COVID-19 virus spread](https://www.who.int/emergencies/diseases/novel-coronavirus-2019) using BFS Algorithm. The Graph modelled in the app is built using Microsoft Automatic Graph Layout ([MSAGL](https://github.com/microsoft/automatic-graph-layout)), a .NET library and tool to make graphs.  

## How To Build Source Code
------
### Requirement
To build source code you must have:
1. Visual Studio (2019 recommended, as We developed this with it) with C# Desktop App Package in VS
2. .NET Framework (v.4.8)

### Step
1. Run Visual Studio
2. Open Project with 'Open a Solution or Project'
3. In Solution Explorer, right click and select 'Batch Build'
4. Check the Production Build (if needed you can try the Debug one, too)
5. Click 'Build' button on the right side of the window
6. Wait until finish
7. Now the build should have relative path from this project directory
      
        WpfApp1/bin/

    There should be Release and Debug version for which version that you have been checked.

## How To Run Binary
-----------
### Windows
1. Just go to the bin directory
2. Run WpfApp1.exe (executables) file.
3. Done and you can use the feature!!


### Linux
1. [Install .NET](https://docs.microsoft.com/en-us/dotnet/core/install/) in your Linux with the respective Linux package manager. 
2. [Install WINE](https://www.winehq.org/) for your Linux distro to run the windws exec file.
3. If for some reason you cannot run the executable with WINE, install .NET for WINE [here](https://appdb.winehq.org/objectManager.php?sClass=application&iId=2586).
4. Run WpfApp1.exe with WINE. Enjoy!


## How to Use the Apps
------------
<b>Prerequsites: </b>You should have open the program from the instruction before!

1. Select Place (Node) with press the button, and then select apriorate .txt file
2. Do the same for Route (Edge) with pressing other button there.
3. Input the days after first infection on given fields and press the button.
4. The result's graph now should have appeared in the middle side of Apps, followed by the step/path of the infection in the right side.

