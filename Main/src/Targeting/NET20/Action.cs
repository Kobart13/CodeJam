﻿#if TARGETS_NET && LESSTHAN_NET35
// BASEDON: https://github.com/dotnet/coreclr/blob/76c62b72ef2642c3ad91209acf02db6c8b42aff7/src/mscorlib/src/System/Action.cs

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System
{
	public delegate void Action<T>(T obj);

	// Action/Func delegates first shipped with .NET Framework 3.5 in System.Core.dll as part of LINQ
	// These were type forwarded to mscorlib.dll in .NET Framework 4.0 and in Silverlight 5.0
	public delegate void Action();
	public delegate void Action<T1,T2>(T1 arg1, T2 arg2);
	public delegate void Action<T1,T2,T3>(T1 arg1, T2 arg2, T3 arg3);
	public delegate void Action<T1,T2,T3,T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
}
#endif