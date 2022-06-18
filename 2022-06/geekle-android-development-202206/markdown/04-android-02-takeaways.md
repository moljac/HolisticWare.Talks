### 4.2 .NET For Android Takeaways

<small>

![Architecture](https://docs.microsoft.com/en-us/xamarin/android/internals/architecture-images/architecture1.png "Architecture")

*   don't use Android types if not necessary

    *   marshalling/serialization/inter-op is expensive

*   use C#

    *   sharing the code (libraries, shared projects - similar symlinks)

</small>