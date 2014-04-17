using System;
using MonoTouch.Foundation;

namespace PLCrashreporterBinding {
	[BaseType (typeof (NSObject))]
	public partial interface PLCrashReporter {

		[Static, Export ("sharedReporter")]
		PLCrashReporter SharedReporter { get; }

		[Export ("hasPendingCrashReport")]
		bool HasPendingCrashReport { get; }

		[Export ("enableCrashReporterAndReturnError:")]
		bool EnableCrashReporterAndReturnError (out NSError outError);

		[Export ("loadPendingCrashReportDataAndReturnError:")]
		NSData LoadPendingCrashReportDataAndReturnError (out NSError outError);
	}

	[BaseType (typeof (NSObject))]
	public partial interface PLCrashReport {

		[Export ("initWithData:error:")]
		IntPtr Constructor (NSData crashData, out NSError outError);

		[Export ("signalInfo")]
		PLCrashReportSignalInfo SignalInfo { get; }

		[Export ("systemInfo")]
		PLCrashReportSystemInfo SystemInfo { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface PLCrashReportSignalInfo {
		[Export ("name")]
		string Name { get; }

		[Export ("code")]
		string Code { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface PLCrashReportSystemInfo {
		[Export ("operatingSystemVersion")]
		string OperatingSystemVersion { get; }

		[Export ("operatingSystemBuild")]
		string OperatingSystemBuild { get; }

		[Export ("timestamp")]
		NSDate Timestamp { get; }
	}
}
