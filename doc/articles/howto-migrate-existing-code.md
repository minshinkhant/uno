# How to migrate existing UWP code to Uno

There are two separate paths for using an existing UWP codebase on top of uno:
- An existing UWP application
- An existing UWP library

For migrating UWP application, see [this article](migrating-apps.md).

## Migrate an existing library

To migrate an existing library, the shortest path is to create a Cross-Platform library and replace the existing library's project with it.

### Steps
Here's how to do it, from scratch. Let's start by creating a basic UWP library, so we can transform it to a cross-platform one:
- In Visual Studio, create a **Class Library (Universal Windows)** project named `MyLibrary`
- Make sure it builds.
- Using the Uno Visual Studio Extension, create a **Cross-Platform Library (Uno Platform)** project in the same solution, and name it `TempUno`
- Right click on `MyLibrary`, then **Unload Project**
- Right click again on `MyLibrary`, then **Edit MyLibrary.csproj**
- Right click on `TempUno`, then **Edit TempUno.csproj** _(There is no need to unload this type of project)_
-  Copy the whole content of the `TempUno` csproj, and paste it in the `MyLibrary` project file.
-  Right click on the `MyLibrary` project, then **Reload Project**
-  Delete the `TempUno` project from your solution
-  In the **Properties** folder, you'll need to remove the `AssemblyVersion` and similar properties as those are now generated by [msbuild using AssemblyInfo properties](https://docs.microsoft.com/en-us/dotnet/core/tools/csproj#assemblyinfo-properties).

Your Library project is now ready to be used on iOS, Android and WebAssembly.

### Dependencies
If you have a set of existing nuget dependencies in your project:
- If the dependency **is using .NET Standard 2.0**, there's no need to make any changes, the library will be used as-is. This type of dependency will generally work on other platforms, depending on the type of APIs used, and runtime platform features.
- If the dependency **is not using .NET Standard 2.0**:
  - It may already support the iOS and Android targets, in which case it can be used directly
  - If it does not, the Uno Platform team may have already created an Uno port of the library available on Nuget.
