﻿using System;
using System.Collections.Generic;

using JetBrains.Annotations;

namespace CodeJam.Collections
{
	partial class EnumerableExtensions
	{
		/// <summary>
		/// Splits the input sequence into a sequence of chunks of the specified size.
		/// </summary>
		/// <typeparam name="T">The type of the elements of source.</typeparam>
		/// <param name="source">The sequence to split into chunks.</param>
		/// <param name="size">The size of the chunks.</param>
		/// <returns>
		/// A sequence of chunks of the specified size.
		/// </returns>
		[NotNull, Pure, LinqTunnel]
		public static IEnumerable<T[]> Split<T>([NotNull] this IEnumerable<T> source, int size)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));

			if (size <= 0)
				throw new ArgumentOutOfRangeException(nameof(size));

			return SplitImpl(source, size);
		}

		[NotNull, Pure, LinqTunnel]
		private static IEnumerable<T[]> SplitImpl<T>([NotNull] IEnumerable<T> source, int size)
		{
			using var enumerator = source.GetEnumerator();
			while (enumerator.MoveNext())
				yield return SplitSequence(enumerator, size);
		}

		[NotNull]
		private static T[] SplitSequence<T>([NotNull] IEnumerator<T> enumerator, int size)
		{
			var count = 0;
			var items = new T[size];

			do
			{
				items[count++] = enumerator.Current;
			}
			while (count < size && enumerator.MoveNext());

			if (count < size)
				Array.Resize(ref items, count);

			return items;
		}

	}
}
