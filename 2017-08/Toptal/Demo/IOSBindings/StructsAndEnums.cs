using System;
using ObjCRuntime;

namespace Garmin.ConnectIQ
{
	[Native]
	public enum IQSendMessageResult : ulong //nint
	{
		Success,
		Failure_Unknown,
		Failure_InternalError,
		Failure_DeviceNotAvailable,
		Failure_AppNotFound,
		Failure_DeviceIsBusy,
		Failure_UnsupportedType,
		Failure_InsufficientMemory,
		Failure_Timeout,
		Failure_MaxRetries,
		Failure_PromptNotDisplayed,
		Failure_AppAlreadyRunning
	}

	[Native]
	public enum IQDeviceStatus : ulong //nint
	{
		InvalidDevice,
		BluetoothNotReady,
		NotFound,
		NotConnected,
		Connected
	}
}
