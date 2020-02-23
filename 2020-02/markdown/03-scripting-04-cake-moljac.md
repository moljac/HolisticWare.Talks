## Scripting - Cake `dotnet cake`

*   DevOps!

*   .NET Core tool

        dotnet tool uninstall --global Cake.Tool
        dotnet tool install --global Cake.Tool

*   execute

    *   bootstrapper

        *   mac/Linux: 
        
                ./build.sh -t=libs

        *   Windows: 
        
                .\build.ps1 -target=libs -v=diagnostic

