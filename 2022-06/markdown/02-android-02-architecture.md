### 2.1 .NET For Android Architecture

<small>

![Architecture](https://docs.microsoft.com/en-us/xamarin/android/internals/architecture-images/architecture1.png "Architecture")

*   .NET APIs == .NET BCL (currently .NET 5+ BCL,  was Mono BCL)

*   MONO = Mono VM (CLR) 

*   why Mono? 

Android Callable Wrappers
Android callable wrappers are a JNI bridge which are used any time the Android runtime needs to invoke managed code. Android callable wrappers are how virtual methods can be overridden and Java interfaces can be implemented

</small>