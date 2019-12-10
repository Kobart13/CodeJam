﻿#if LESSTHAN_NET40 || LESSTHAN_NETSTANDARD10 || LESSTHAN_NETCOREAPP10 // PUBLIC_API_CHANGES. TODO: update after fixes in Theraot.Core
// Some expression types are missing if targeting to these frameworks
#else
using System;
using System.Runtime.Serialization;

using JetBrains.Annotations;

namespace CodeJam.Mapping
{
	/// <summary>
	/// Defines the base class for the namespace exceptions.
	/// </summary>
	/// <remarks>
	/// This class is the base class for exceptions that may occur during
	/// execution of the namespace members.
	/// </remarks>
	[PublicAPI]
	[Serializable]
	public class CodeJamConvertException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CodeJamConvertException"/> class.
		/// </summary>
		/// <remarks>
		/// This constructor initializes the <see cref="Exception.Message"/>
		/// property of the new instance such as "A Build Type exception has occurred."
		/// </remarks>
		public CodeJamConvertException()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CodeJamConvertException"/> class
		/// with the specified error message.
		/// </summary>
		/// <param name="message">The message to display to the client when the
		/// exception is thrown.</param>
		/// <seealso cref="Exception.Message"/>
		public CodeJamConvertException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CodeJamConvertException"/> class
		/// with the specified error message and InnerException property.
		/// </summary>
		/// <param name="message">The message to display to the client when the
		/// exception is thrown.</param>
		/// <param name="innerException">The InnerException, if any, that threw
		/// the current exception.</param>
		/// <seealso cref="Exception.Message"/>
		/// <seealso cref="Exception.InnerException"/>
		public CodeJamConvertException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CodeJamConvertException"/> class
		/// with the specified InnerException property.
		/// </summary>
		/// <param name="innerException">The InnerException, if any, that threw
		/// the current exception.</param>
		/// <seealso cref="Exception.InnerException"/>
		public CodeJamConvertException([NotNull] Exception innerException)
			: base(innerException.Message, innerException)
		{
		}

#if LESSTHAN_NET20 || LESSTHAN_NETSTANDARD20 || LESSTHAN_NETCOREAPP20
		// Exception(SerializationInfo, StreamingContext) is missing when targeting to these frameworks
#else
		/// <summary>
		/// Initializes a new instance of the <see cref="CodeJamConvertException"/> class
		/// with serialized data.
		/// </summary>
		/// <param name="info">The object that holds the serialized object data.</param>
		/// <param name="context">The contextual information about the source or
		/// destination.</param>
		/// <remarks>This constructor is called during deserialization to
		/// reconstitute the exception object transmitted over a stream.</remarks>
		protected CodeJamConvertException([NotNull] SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
#endif
	}
}
#endif