### 2.3 .NET For Android Architecture MCW 1

<small>

*   MCW  Managed Callable Wrappers

    *   C# code generated in bindings project
    
*   Bindings

    *   `android.jar` => `mono.android.dll`

    *   tools

        *   `class-parse`

            *   `api.xml` AOSP format for API

        *   `generator`

            *   generates C# from `api.xml` 

        *   metadata (`Metadata.xml`) XPath to customize `api.xml`

</small>