using Foundation;

namespace Garmin.ConnectIQ
{
	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const int IQSDKVersion;
		[Field ("IQSDKVersion", "__Internal")]
		int IQSDKVersion { get; }

		// extern NSString *const IQGCMBundle;
		[Field ("IQGCMBundle", "__Internal")]
		NSString IQGCMBundle { get; }
	}

	// typedef void (^IQSendMessageProgress)(uint32_t, uint32_t);
	delegate void IQSendMessageProgress (uint arg0, uint arg1);

	// typedef void (^IQSendMessageCompletion)(IQSendMessageResult);
	delegate void IQSendMessageCompletion (IQSendMessageResult arg0);
}
