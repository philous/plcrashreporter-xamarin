using System;
using MonoTouch.Foundation;

namespace PLCrashreporterBinding {
	[BaseType (typeof (NSObject))]
	public interface PLCrashReporter {

		[Static, Export ("sharedReporter")]
		PLCrashReporter SharedReporter { get; }

		[Export ("initWithConfiguration:")]
		IntPtr Constructor (PLCrashReporterConfig config);

		[Export ("hasPendingCrashReport")]
		bool HasPendingCrashReport { get; }

		[Export ("enableCrashReporterAndReturnError:")]
		bool EnableCrashReporterAndReturnError (out NSError outError);

		[Export ("enableCrashReporter")]
		bool EnableCrashReporter ();

		[Export ("loadPendingCrashReportDataAndReturnError:")]
		NSData LoadPendingCrashReportDataAndReturnError (out NSError outError);

		[Export ("purgePendingCrashReport")]
		bool PurgePendingCrashReport ();
	}

	[BaseType (typeof (NSObject))]
	public interface PLCrashReport {
		[Export ("initWithData:error:")]
		IntPtr Constructor (NSData encodedData, out NSError outError);

		[Export ("systemInfo")]
		PLCrashReportSystemInfo SystemInfo { get; }

		[Export ("applicationInfo")]
		PLCrashReportApplicationInfo ApplicationInfo { get; }

		[Export ("signalInfo")]
		PLCrashReportSignalInfo SignalInfo { get; }

		[Export ("exceptionInfo")]
		PLCrashReportExceptionInfo ExceptionInfo { get; }
	}

	[BaseType (typeof (NSObject))]
	public interface PLCrashReportSignalInfo {
		[Export ("name")]
		string Name { get; }

		[Export ("code")]
		string Code { get; }
	}

	[BaseType (typeof (NSObject))]
	public interface PLCrashReportApplicationInfo {
		[Export ("applicationIdentifier")]
		string ApplicationIdentifier { get; }

		[Export ("applicationVersion")]
		string ApplicationVersion { get; }
	}

	[BaseType (typeof (NSObject))]
	public interface PLCrashReportSystemInfo {
		[Export ("operatingSystemVersion")]
		string OperatingSystemVersion { get; }

		[Export ("operatingSystemBuild")]
		string OperatingSystemBuild { get; }

		[Export ("timestamp")]
		NSDate Timestamp { get; }
	}

	[BaseType (typeof (NSObject))]
	public interface PLCrashReportExceptionInfo {
		[Export ("exceptionName")]
		string ExceptionName { get; }

		[Export ("exceptionReason")]
		string ExceptionReason { get; }

		[Export ("stackFrames")]
		NSObject [] StackFrames { get; }
	}

	[BaseType (typeof (NSObject))]
	public interface PLCrashReporterConfig {
		[Export ("initWithSignalHandlerType:symbolicationStrategy:")]
		IntPtr Constructor (PLCrashReporterSignalHandlerType signalHandlerType, PLCrashReporterSymbolicationStrategy symbolicationStrategy);

		[Export ("signalHandlerType")]
		PLCrashReporterSignalHandlerType SignalHandlerType { get; }

		[Export ("symbolicationStrategy")]
		PLCrashReporterSymbolicationStrategy SymbolicationStrategy { get; }
	}
}
