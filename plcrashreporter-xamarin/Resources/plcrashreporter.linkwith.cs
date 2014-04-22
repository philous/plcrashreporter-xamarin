using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("plcrashreporter.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, SmartLink = true, ForceLoad = true, IsCxx = true, LinkerFlags="-lc++")]
