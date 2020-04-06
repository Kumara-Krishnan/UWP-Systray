UWP Systray

Purpose: This repo is a sample to reproduce an issue with .NET standard library throwing an exception when being added as a dependency to a full trust win forms app which is part of a UWP application.

Prerequisites

SDK 17763

Desktop extensions sdk 17763

.NET Standard 2.0

.NET Framework 4.7.2


Steps:
Clean and rebuild the project and set deploy project as SystrayExtension (the uwp app) and solution platform as x64.
Now if you run it, a full trust win32 component will open in system tray.
Right click the tray icon and 'choose perform domain logic'.
Now it will throw a FileNotFound saying that it cannot find the assembly 'DomainLibrary'.


Now terminate the debugger and set deploy project as SystrayComponent (win forms component) and start.
Now in the tray icon, right click and choose 'perform domain logic'.
It will print a debug output 'Hello World!!' successfully.


Why is it throwing exception in the first scenario and how to resolve it?
