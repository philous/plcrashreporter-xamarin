using System;

namespace PLCrashreporterBinding {
	public enum PLCrashReporterSignalHandlerType : uint {
		BSD = 0,
		Mach = 1
	}

	public enum PLCrashReporterSymbolicationStrategy : uint {
		None = 0,
		SymbolTable = 1 << 0,
		ObjC = 1 << 1,
		All = (PLCrashReporterSymbolicationStrategy.SymbolTable | PLCrashReporterSymbolicationStrategy.ObjC)
	}
}

