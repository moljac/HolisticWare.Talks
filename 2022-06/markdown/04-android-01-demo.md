### 4.1 .NET For Android Demo

<small>

```bash
$HOME/Library/Android/sdk/emulator/emulator -avd "Pixel_XL_API_30"
```

```bash
mkdir Geekle/ && cd Geekle/
```

```bash
dotnet new android --output AppAndroid 

dotnet build AppAndroid  

dotnet run --project AppAndroid/AppAndroid.csproj  

dotnet new sln

# bash/zsh
dotnet sln add $(ls -r **/*.csproj)
# pwsh
# dotnet sln add (ls -r **/*.csproj)

```

```
code -n .
```

Cmd+Shift+P Presentation Mode

CopyPasta

</small>