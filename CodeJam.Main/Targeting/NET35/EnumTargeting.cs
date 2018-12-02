﻿#if !LESSTHAN_NET35
#if LESSTHAN_NET40
using System;
using System.Globalization;

namespace CodeJam.Targeting
{
	/// <summary>
	/// Targeting methods for <see cref="Enum"/> class.
	/// </summary>
	public static class EnumTargeting
	{
		/// <summary>
		/// Converts the string representation of the name or numeric value of one or more enumerated constants to an
		/// equivalent enumerated object. A parameter specifies whether the operation is case-sensitive. The return value
		/// indicates whether the conversion succeeded.
		/// </summary>
		/// <typeparam name="TEnum">The enumeration type to which to convert <paramref name="value"/>.</typeparam>
		/// <param name="value">The string representation of the enumeration name or underlying value to convert.</param>
		/// <param name="result">
		/// When this method returns, <paramref name="result"/> contains an object of type <typeparamref name="TEnum"/>
		/// whose value is represented by <paramref name="value"/> if the parse operation succeeds. If the parse operation
		/// fails, <paramref name="result"/> contains the default value of the underlying type of
		/// <typeparamref name="TEnum"/>. Note that this value need not be a member of the <typeparamref name="TEnum"/>
		/// enumeration. This parameter is passed uninitialized.
		/// </param>
		/// <returns></returns>
		public static bool TryParse<TEnum>(string value, out TEnum result)
			where TEnum : struct, Enum =>
			TryParse(value, false, out result);

		/// <summary>
		/// Converts the string representation of the name or numeric value of one or more enumerated constants to an
		/// equivalent enumerated object. A parameter specifies whether the operation is case-sensitive. The return value
		/// indicates whether the conversion succeeded.
		/// </summary>
		/// <typeparam name="TEnum">The enumeration type to which to convert <paramref name="value"/>.</typeparam>
		/// <param name="value">The string representation of the enumeration name or underlying value to convert.</param>
		/// <param name="ignoreCase"><c>true</c> to ignore case; <c>false</c> to consider case.</param>
		/// <param name="result">
		/// When this method returns, <paramref name="result"/> contains an object of type <typeparamref name="TEnum"/>
		/// whose value is represented by <paramref name="value"/> if the parse operation succeeds. If the parse operation
		/// fails, <paramref name="result"/> contains the default value of the underlying type of
		/// <typeparamref name="TEnum"/>. Note that this value need not be a member of the <typeparamref name="TEnum"/>
		/// enumeration. This parameter is passed uninitialized.
		/// </param>
		/// <returns></returns>
		public static bool TryParse<TEnum>(
			string value,
			bool ignoreCase,
			out TEnum result)
			where TEnum : struct, Enum
		{
			if (Enum.IsDefined(typeof(TEnum), value))
			{
				result = (TEnum)Enum.Parse(typeof(TEnum), value);
				return true;
			}
			if (EnumHelper.IsFlagsEnum<TEnum>() && long.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsedValue))
			{
				try
				{
					result = (TEnum)Convert.ChangeType(parsedValue, Enum.GetUnderlyingType(typeof(TEnum)));
					return true;
				}
				catch (ArgumentException)
				{
				}
				catch (OverflowException)
				{
				}
			}
			result = default(TEnum);
			return false;
		}
	}
}
#endif
#endif