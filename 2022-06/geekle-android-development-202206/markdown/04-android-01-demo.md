### 4.1 .NET For Android Demo

<small>

```
$HOME/Library/Android/sdk/emulator/emulator -avd "Pixel_XL_API_30"
```

```
mkdir Geekle/ && cd Geekle/
```

```
dotnet new android --output AppAndroid 

dotnet build AppAndroid  

dotnet run --project AppAndroid/AppAndroid.csproj  
```

</small>