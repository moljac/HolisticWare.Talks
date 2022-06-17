### 2.3 .NET For Android Architecture ACW 3

<small>

```
obj/Debug/android/src/mono/androidx/fragment/app/FragmentOnAttachListenerImplementor.java
```

```java
package mono.androidx.activity.contextaware;

public class OnContextAvailableListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.activity.contextaware.OnContextAvailableListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onContextAvailable:(Landroid/content/Context;)V:GetOnContextAvailable_Landroid_content_Context_Handler:AndroidX.Activity.ContextAware.IOnContextAvailableListenerInvoker, Xamarin.AndroidX.Activity\n" +
			"";
		mono.android.Runtime.register ("AndroidX.Activity.ContextAware.IOnContextAvailableListenerImplementor, Xamarin.AndroidX.Activity", OnContextAvailableListenerImplementor.class, __md_methods);
	}

	public OnContextAvailableListenerImplementor ()
	{
		super ();
		if (getClass () == OnContextAvailableListenerImplementor.class)
			mono.android.TypeManager.Activate ("AndroidX.Activity.ContextAware.IOnContextAvailableListenerImplementor, Xamarin.AndroidX.Activity", "", this, new java.lang.Object[] {  });
	}
```

</small>