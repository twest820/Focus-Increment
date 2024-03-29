﻿### Overview
Focus Increment is intended to become a set of tools useful in automating focus stacking tasks from PowerShell scripts. Currently, it
contains two cmdlets.

* Convert-Helicon: Converts saved Helicon projects (.hproj and _files directory) to Zerene projects (.zsj and directories) 
by translating project XML and copying outputs. Helicon's input files can be used as retouching sources in Zerene if Helicon's outputs
are uncropped (uncheck Edit → Preferences → Autoadjustments → Crop output automatically).
* Get-Alignment: Extracts alignment information from Helicon and Zerene project files (.hproj and .zsj) and saves it in a .csv adjacent 
to the project file.

### Development Environment
A default install of [Visual Studio 2019 Community](https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx) 16.4 
or newer should suffice. Higher Visual Studio SKUs such as Enterprise are fine.
