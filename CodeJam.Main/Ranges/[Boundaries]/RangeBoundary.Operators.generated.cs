﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;

using static CodeJam.PlatformDependent;

namespace CodeJam.Ranges
{
	/// <summary>The From boundary of the range.</summary>
	public partial struct RangeBoundaryFrom<T>
	{
		#region Operators
		#region Equality operators
		/// <summary>Implements the operator ==.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 == boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator ==(RangeBoundaryFrom<T> boundary1, RangeBoundaryFrom<T> boundary2) =>
			boundary1.Equals(boundary2);

		/// <summary>Implements the operator !=.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 != boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator !=(RangeBoundaryFrom<T> boundary1, RangeBoundaryFrom<T> boundary2) =>
			!boundary1.Equals(boundary2);
		#endregion

		#region Comparison operators
		/// <summary>Implements the operator &gt;.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >(RangeBoundaryFrom<T> boundary1, RangeBoundaryFrom<T> boundary2) =>
			boundary1.CompareTo(boundary2) > 0;

		/// <summary>Implements the operator &gt;.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >(RangeBoundaryFrom<T> boundary1, RangeBoundaryTo<T> boundary2) =>
			boundary1.CompareTo(boundary2) > 0;

		/// <summary>Implements the operator &gt;.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The value of the boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >(RangeBoundaryFrom<T> boundary1, T boundary2) =>
			boundary1.CompareTo(boundary2) > 0;

		/// <summary>Implements the operator &gt;.</summary>
		/// <param name="boundary1">The value of the boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >(T boundary1, RangeBoundaryFrom<T> boundary2) =>
			boundary2.CompareTo(boundary1) < 0;

		/// <summary>Implements the operator &gt;=.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >=(RangeBoundaryFrom<T> boundary1, RangeBoundaryFrom<T> boundary2) =>
			boundary1.CompareTo(boundary2) >= 0;

		/// <summary>Implements the operator &gt;=.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >=(RangeBoundaryFrom<T> boundary1, RangeBoundaryTo<T> boundary2) =>
			boundary1.CompareTo(boundary2) >= 0;

		/// <summary>Implements the operator &gt;=.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The value of the boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >=(RangeBoundaryFrom<T> boundary1, T boundary2) =>
			boundary1.CompareTo(boundary2) >= 0;

		/// <summary>Implements the operator &gt;=.</summary>
		/// <param name="boundary1">The value of the boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >=(T boundary1, RangeBoundaryFrom<T> boundary2) =>
			boundary2.CompareTo(boundary1) <= 0;

		/// <summary>Implements the operator &lt;.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <(RangeBoundaryFrom<T> boundary1, RangeBoundaryFrom<T> boundary2) =>
			boundary1.CompareTo(boundary2) < 0;

		/// <summary>Implements the operator &lt;.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <(RangeBoundaryFrom<T> boundary1, RangeBoundaryTo<T> boundary2) =>
			boundary1.CompareTo(boundary2) < 0;

		/// <summary>Implements the operator &lt;.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The value of the boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <(RangeBoundaryFrom<T> boundary1, T boundary2) =>
			boundary1.CompareTo(boundary2) < 0;

		/// <summary>Implements the operator &lt;.</summary>
		/// <param name="boundary1">The value of the boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <(T boundary1, RangeBoundaryFrom<T> boundary2) =>
			boundary2.CompareTo(boundary1) > 0;

		/// <summary>Implements the operator &lt;=.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <=(RangeBoundaryFrom<T> boundary1, RangeBoundaryFrom<T> boundary2) =>
			boundary1.CompareTo(boundary2) <= 0;

		/// <summary>Implements the operator &lt;=.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <=(RangeBoundaryFrom<T> boundary1, RangeBoundaryTo<T> boundary2) =>
			boundary1.CompareTo(boundary2) <= 0;

		/// <summary>Implements the operator &lt;=.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The value of the boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <=(RangeBoundaryFrom<T> boundary1, T boundary2) =>
			boundary1.CompareTo(boundary2) <= 0;

		/// <summary>Implements the operator &lt;=.</summary>
		/// <param name="boundary1">The value of the boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <=(T boundary1, RangeBoundaryFrom<T> boundary2) =>
			boundary2.CompareTo(boundary1) >= 0;
		#endregion
		#endregion
	}

	/// <summary>The To boundary of the range.</summary>
	public partial struct RangeBoundaryTo<T>
	{
		#region Operators
		#region Equality operators
		/// <summary>Implements the operator ==.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 == boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator ==(RangeBoundaryTo<T> boundary1, RangeBoundaryTo<T> boundary2) =>
			boundary1.Equals(boundary2);

		/// <summary>Implements the operator !=.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 != boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator !=(RangeBoundaryTo<T> boundary1, RangeBoundaryTo<T> boundary2) =>
			!boundary1.Equals(boundary2);
		#endregion

		#region Comparison operators
		/// <summary>Implements the operator &gt;.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >(RangeBoundaryTo<T> boundary1, RangeBoundaryTo<T> boundary2) =>
			boundary1.CompareTo(boundary2) > 0;

		/// <summary>Implements the operator &gt;.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >(RangeBoundaryTo<T> boundary1, RangeBoundaryFrom<T> boundary2) =>
			boundary1.CompareTo(boundary2) > 0;

		/// <summary>Implements the operator &gt;.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The value of the boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >(RangeBoundaryTo<T> boundary1, T boundary2) =>
			boundary1.CompareTo(boundary2) > 0;

		/// <summary>Implements the operator &gt;.</summary>
		/// <param name="boundary1">The value of the boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >(T boundary1, RangeBoundaryTo<T> boundary2) =>
			boundary2.CompareTo(boundary1) < 0;

		/// <summary>Implements the operator &gt;=.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >=(RangeBoundaryTo<T> boundary1, RangeBoundaryTo<T> boundary2) =>
			boundary1.CompareTo(boundary2) >= 0;

		/// <summary>Implements the operator &gt;=.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >=(RangeBoundaryTo<T> boundary1, RangeBoundaryFrom<T> boundary2) =>
			boundary1.CompareTo(boundary2) >= 0;

		/// <summary>Implements the operator &gt;=.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The value of the boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >=(RangeBoundaryTo<T> boundary1, T boundary2) =>
			boundary1.CompareTo(boundary2) >= 0;

		/// <summary>Implements the operator &gt;=.</summary>
		/// <param name="boundary1">The value of the boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &gt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator >=(T boundary1, RangeBoundaryTo<T> boundary2) =>
			boundary2.CompareTo(boundary1) <= 0;

		/// <summary>Implements the operator &lt;.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <(RangeBoundaryTo<T> boundary1, RangeBoundaryTo<T> boundary2) =>
			boundary1.CompareTo(boundary2) < 0;

		/// <summary>Implements the operator &lt;.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <(RangeBoundaryTo<T> boundary1, RangeBoundaryFrom<T> boundary2) =>
			boundary1.CompareTo(boundary2) < 0;

		/// <summary>Implements the operator &lt;.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The value of the boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <(RangeBoundaryTo<T> boundary1, T boundary2) =>
			boundary1.CompareTo(boundary2) < 0;

		/// <summary>Implements the operator &lt;.</summary>
		/// <param name="boundary1">The value of the boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt; boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <(T boundary1, RangeBoundaryTo<T> boundary2) =>
			boundary2.CompareTo(boundary1) > 0;

		/// <summary>Implements the operator &lt;=.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <=(RangeBoundaryTo<T> boundary1, RangeBoundaryTo<T> boundary2) =>
			boundary1.CompareTo(boundary2) <= 0;

		/// <summary>Implements the operator &lt;=.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <=(RangeBoundaryTo<T> boundary1, RangeBoundaryFrom<T> boundary2) =>
			boundary1.CompareTo(boundary2) <= 0;

		/// <summary>Implements the operator &lt;=.</summary>
		/// <param name="boundary1">The boundary1.</param>
		/// <param name="boundary2">The value of the boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <=(RangeBoundaryTo<T> boundary1, T boundary2) =>
			boundary1.CompareTo(boundary2) <= 0;

		/// <summary>Implements the operator &lt;=.</summary>
		/// <param name="boundary1">The value of the boundary1.</param>
		/// <param name="boundary2">The boundary2.</param>
		/// <returns><c>True</c>, if boundary1 &lt;= boundary2.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool operator <=(T boundary1, RangeBoundaryTo<T> boundary2) =>
			boundary2.CompareTo(boundary1) >= 0;
		#endregion
		#endregion
	}
}