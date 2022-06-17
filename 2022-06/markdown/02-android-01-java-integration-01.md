### 2.2 .NET For Android Intro

<small>

3 possible ways to reuse Java libraries in a Xamarin.Android application:

https://docs.microsoft.com/en-us/xamarin/android/platform/java-integration/

*   Java Bindings Library

    *   C# wrappers around the Java types in `*.jar` or `*.aar`
     
    *   JNI based

*   Java Native Interface (JNI)

    *   framework that allows non-Java code (such as C++ or C#) 
        to call or be called by Java code running inside a JVM

*   Port the Code - Transpiling

    convert Java source code to C#
    
    *   manually
    
    *   tools like Sharpen


</small>