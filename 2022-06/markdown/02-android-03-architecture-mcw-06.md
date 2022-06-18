### 2.3 .NET For Android Architecture MCW 7

<small>

generated C# code:

```csharp
namespace Org.Koin.Android.Ext.Koin {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.android.ext.koin']/class[@name='KoinExtKt']"
	[global::Android.Runtime.Register ("org/koin/android/ext/koin/KoinExtKt", DoNotGenerateAcw=true)]
	public sealed partial class KoinExtKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/koin/android/ext/koin/KoinExtKt", typeof (KoinExtKt));

        // ... snip ...

		internal KoinExtKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.android.ext.koin']/class[@name='KoinExtKt']/method[@name='androidContext' and count(parameter)=2 and parameter[1][@type='org.koin.core.KoinApplication'] and parameter[2][@type='android.content.Context']]"
		[Register ("androidContext", "(Lorg/koin/core/KoinApplication;Landroid/content/Context;)Lorg/koin/core/KoinApplication;", "")]
		public static unsafe global::Org.Koin.Core.KoinApplication AndroidContext (global::Org.Koin.Core.KoinApplication obj, global::Android.Content.Context androidContext)
		{
			const string __id = "androidContext.(Lorg/koin/core/KoinApplication;Landroid/content/Context;)Lorg/koin/core/KoinApplication;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue ((androidContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) androidContext).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.KoinApplication> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (androidContext);
			}
		}
    }
}
```

</small>
