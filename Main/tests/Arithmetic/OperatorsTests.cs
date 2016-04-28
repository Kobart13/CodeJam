﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using NUnit.Framework;

namespace CodeJam.Arithmetic
{
	[TestFixture(Category = "Operators")]
	[SuppressMessage("ReSharper", "ClassNeverInstantiated.Local")]
	[SuppressMessage("ReSharper", "UnusedParameter.Local")]
	public partial class OperatorsTests
	{
		#region Test helpers
		private class ClassNoComparable { }

		private class ClassComparable : IComparable
		{
			public int CompareTo(object obj) => 0;
		}

		private class ClassGenericComparable : IComparable<ClassGenericComparable>
		{
			public int CompareTo(ClassGenericComparable other) => 0;
		}

		private class ClassComparable2 : IComparable, IComparable<ClassComparable2>
		{
			public bool NonGenericCalled { get; set; }
			public bool GenericCalled { get; set; }

			public int CompareTo(object obj)
			{
				NonGenericCalled = true;
				return 0;
			}

			public int CompareTo(ClassComparable2 other)
			{
				GenericCalled = true;
				return 0;
			}
		}

		private class ClassOperatorsComparable : IComparable<ClassOperatorsComparable>
		{
			public static bool operator >=(ClassOperatorsComparable a, ClassOperatorsComparable b)
			{
				OpCalled = true;
				return true;
			}

			public static bool operator <=(ClassOperatorsComparable a, ClassOperatorsComparable b)
			{
				OpCalled = true;
				return true;
			}

			public static bool OpCalled { get; set; }
			public static bool GenericCalled { get; set; }

			public int CompareTo(ClassOperatorsComparable other)
			{
				GenericCalled = true;
				return 0;
			}
		}

		private class ClassOperatorsComparable2
		{
			public static bool operator >=(ClassOperatorsComparable2 a, ClassOperatorsComparable2 b) => true;

			public static bool operator <=(ClassOperatorsComparable2 a, ClassOperatorsComparable2 b) => true;
		}

		private enum SomeEnum
		{
			A = 1,
			B
		}

		private enum SomeEnumByte : byte
		{
			A = 1,
			B
		}

		private enum SomeEnumLong : long
		{
			A = 1,
			B
		}

		private static void AssertOperator<T>(Func<T> opGetter) =>
			Assert.DoesNotThrow(() => opGetter());

		private static void AssertNoOperator<T>(Func<T> opGetter) =>
			Assert.Throws<NotSupportedException>(() => opGetter());

		private static int NormalizeComparison(int value) =>
			value < 0 ? -1 : (value > 0 ? 1 : 0);

		private static void AssertComparison<T>(T value1, T value2)
		{
			var comparer = Comparer<T>.Default;
			var compare = Operators<T>.Compare;

			Assert.AreEqual(
				NormalizeComparison(comparer.Compare(value1, value2)),
				NormalizeComparison(compare(value1, value2)));

			Assert.AreEqual(
				NormalizeComparison(comparer.Compare(value2, value1)),
				NormalizeComparison(compare(value2, value1)));

			Assert.AreEqual(
				NormalizeComparison(comparer.Compare(value1, value1)),
				NormalizeComparison(compare(value1, value1)));

			Assert.AreEqual(
				NormalizeComparison(comparer.Compare(value2, value2)),
				NormalizeComparison(compare(value2, value2)));
		}

		private static void AssertOperatorsCompare<T>(T value1, T value2)
		{
			var compareResult12 = Comparer<T>.Default.Compare(value1, value2);
			var compareResult21 = Comparer<T>.Default.Compare(value2, value1);
			var compareResult11 = Comparer<T>.Default.Compare(value1, value1);
			var compareResult22 = Comparer<T>.Default.Compare(value2, value2);

			Assert.AreEqual(
				Operators<T>.AreEqual(value1, value2),
				compareResult12 == 0);
			Assert.AreEqual(
				Operators<T>.AreNotEqual(value1, value2),
				compareResult12 != 0);
			Assert.AreEqual(
				Operators<T>.GreaterThan(value1, value2),
				compareResult12 > 0);
			Assert.GreaterOrEqual(
				Operators<T>.GreaterThanOrEqual(value1, value2),
				compareResult12 >= 0);
			Assert.AreEqual(
				Operators<T>.LessThan(value1, value2),
				compareResult12 < 0);
			Assert.GreaterOrEqual(
				Operators<T>.LessThanOrEqual(value1, value2),
				compareResult12 <= 0);

			Assert.AreEqual(
				Operators<T>.AreEqual(value2, value1),
				compareResult21 == 0);
			Assert.AreEqual(
				Operators<T>.AreNotEqual(value2, value1),
				compareResult21 != 0);
			Assert.AreEqual(
				Operators<T>.GreaterThan(value2, value1),
				compareResult21 > 0);
			Assert.GreaterOrEqual(
				Operators<T>.GreaterThanOrEqual(value2, value1),
				compareResult21 >= 0);
			Assert.AreEqual(
				Operators<T>.LessThan(value2, value1),
				compareResult21 < 0);
			Assert.GreaterOrEqual(
				Operators<T>.LessThanOrEqual(value2, value1),
				compareResult21 <= 0);

			Assert.AreEqual(
				Operators<T>.AreEqual(value1, value1),
				compareResult11 == 0);
			Assert.AreEqual(
				Operators<T>.AreNotEqual(value1, value1),
				compareResult11 != 0);
			Assert.AreEqual(
				Operators<T>.GreaterThan(value1, value1),
				compareResult11 > 0);
			Assert.GreaterOrEqual(
				Operators<T>.GreaterThanOrEqual(value1, value1),
				compareResult11 >= 0);
			Assert.AreEqual(
				Operators<T>.LessThan(value1, value1),
				compareResult11 < 0);
			Assert.GreaterOrEqual(
				Operators<T>.LessThanOrEqual(value1, value1),
				compareResult11 <= 0);

			Assert.AreEqual(
				Operators<T>.AreEqual(value2, value2),
				compareResult22 == 0);
			Assert.AreEqual(
				Operators<T>.AreNotEqual(value2, value2),
				compareResult22 != 0);
			Assert.AreEqual(
				Operators<T>.GreaterThan(value2, value2),
				compareResult22 > 0);
			Assert.GreaterOrEqual(
				Operators<T>.GreaterThanOrEqual(value2, value2),
				compareResult22 >= 0);
			Assert.AreEqual(
				Operators<T>.LessThan(value2, value2),
				compareResult22 < 0);
			Assert.GreaterOrEqual(
				Operators<T>.LessThanOrEqual(value2, value2),
				compareResult22 <= 0);
		}
		#endregion

		[Test]
		public void Test00OperatorsSupported()
		{
			AssertNoOperator(() => Operators<ClassNoComparable>.Compare);
			AssertNoOperator(() => Operators<ClassNoComparable>.GreaterThanOrEqual);
			AssertOperator(() => Operators<ClassComparable>.Compare);
			AssertOperator(() => Operators<ClassComparable>.GreaterThanOrEqual);
			AssertOperator(() => Operators<ClassGenericComparable>.Compare);
			AssertOperator(() => Operators<ClassGenericComparable>.GreaterThanOrEqual);
			AssertOperator(() => Operators<ClassComparable2>.Compare);
			AssertOperator(() => Operators<ClassComparable2>.GreaterThanOrEqual);

			AssertOperator(() => Operators<ClassGenericComparable>.Compare);
			AssertOperator(() => Operators<ClassGenericComparable>.GreaterThanOrEqual);

			AssertOperator(() => Operators<ClassOperatorsComparable>.Compare);
			AssertOperator(() => Operators<ClassOperatorsComparable>.GreaterThanOrEqual);

			AssertNoOperator(() => Operators<ClassOperatorsComparable2>.Compare);
			AssertOperator(() => Operators<ClassOperatorsComparable2>.GreaterThanOrEqual);

			AssertNoOperator(() => Operators<int[]>.Compare);
			AssertNoOperator(() => Operators<int[]>.GreaterThanOrEqual);
		}

		[Test]
		public void Test01OperatorsDispatch()
		{
			// Proof: operators have higher precedence than IComparable
			var obj = new ClassOperatorsComparable();
			ClassOperatorsComparable.OpCalled = false;
			ClassOperatorsComparable.GenericCalled = false;
			Operators<ClassOperatorsComparable>.GreaterThanOrEqual(
				obj,
				new ClassOperatorsComparable());
			Assert.IsTrue(ClassOperatorsComparable.OpCalled);
			Assert.IsFalse(ClassOperatorsComparable.GenericCalled);

			// Proof: IComparable called for Compare method
			ClassOperatorsComparable.OpCalled = false;
			ClassOperatorsComparable.GenericCalled = false;
			Operators<ClassOperatorsComparable>.Compare(
				obj,
				new ClassOperatorsComparable());
			Assert.IsFalse(ClassOperatorsComparable.OpCalled);
			Assert.IsTrue(ClassOperatorsComparable.GenericCalled);

			// Proof: IComparable<T> has higher precedence than IComparable
			// ReSharper disable once UseObjectOrCollectionInitializer
			var obj2 = new ClassComparable2();
			obj2.NonGenericCalled = false;
			obj2.GenericCalled = false;
			Operators<ClassComparable2>.GreaterThanOrEqual(
				obj2,
				new ClassComparable2());
			Assert.IsFalse(obj2.NonGenericCalled);
			Assert.IsTrue(obj2.GenericCalled);

			// Proof: IComparable<T>  called for Compare method
			obj2.NonGenericCalled = false;
			obj2.GenericCalled = false;
			Operators<ClassComparable2>.Compare(
				obj2,
				new ClassComparable2());
			Assert.IsFalse(obj2.NonGenericCalled);
			Assert.IsTrue(obj2.GenericCalled);
		}

		[Test]
		[SuppressMessage("ReSharper", "RedundantCast")]
		[SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
		public void Test02NullableComparisonOperators()
		{
			Assert.AreNotEqual(
				1.CompareTo(null) > 0,
				Operators<int?>.GreaterThan(1, null));

			Assert.AreEqual(
#pragma warning disable CS0464 // Comparing with null of struct type always produces 'false'
				(int?)1 > null,
#pragma warning restore CS0464 // Comparing with null of struct type always produces 'false'
				Operators<int?>.GreaterThan(1, null));
		}

		[Test]
		public void Test03OperatorsCompareMethod()
		{
			AssertComparison(1, 2);
			AssertComparison<byte>(1, 2);
			AssertComparison<double>(1, 2);
			AssertComparison<decimal>(1, 2);
			AssertComparison("1", "2");
			AssertComparison(DateTime.Today, DateTime.Today.AddDays(1));
			AssertComparison(SomeEnum.A, SomeEnum.B);
			AssertComparison(SomeEnumByte.A, SomeEnumByte.B);
			AssertComparison(SomeEnumLong.A, SomeEnumLong.B);

			AssertComparison<int?>(1, 2);
			AssertComparison<byte?>(1, 2);
			AssertComparison<double?>(1, 2);
			AssertComparison<decimal?>(1, 2);
			AssertComparison("1", "2");
			AssertComparison<DateTime?>(DateTime.Today, DateTime.Today.AddDays(1));
			AssertComparison<SomeEnum?>(SomeEnum.A, SomeEnum.B);
			AssertComparison<SomeEnumByte?>(SomeEnumByte.A, SomeEnumByte.B);
			AssertComparison<SomeEnumLong?>(SomeEnumLong.A, SomeEnumLong.B);

			AssertComparison<int?>(1, null);
			AssertComparison<byte?>(1, null);
			AssertComparison<double?>(1, null);
			AssertComparison<decimal?>(1, null);
			AssertComparison("1", null);
			AssertComparison<DateTime?>(DateTime.Today, null);
			AssertComparison<SomeEnum?>(SomeEnum.A, null);
			AssertComparison<SomeEnumByte?>(SomeEnumByte.A, null);
			AssertComparison<SomeEnumLong?>(SomeEnumLong.A, null);
		}

		[Test]
		public void Test04OperatorsCompare()
		{
			AssertOperatorsCompare(1, 2);
			AssertOperatorsCompare<byte>(1, 2);
			AssertOperatorsCompare<double>(1, 2);
			AssertOperatorsCompare<decimal>(1, 2);
			AssertOperatorsCompare("1", "2");
			AssertOperatorsCompare(DateTime.Today, DateTime.Today.AddDays(1));
			AssertOperatorsCompare(SomeEnum.A, SomeEnum.B);
			AssertOperatorsCompare(SomeEnumByte.A, SomeEnumByte.B);
			AssertOperatorsCompare(SomeEnumLong.A, SomeEnumLong.B);

			AssertOperatorsCompare<int?>(1, 2);
			AssertOperatorsCompare<byte?>(1, 2);
			AssertOperatorsCompare<double?>(1, 2);
			AssertOperatorsCompare<decimal?>(1, 2);
			AssertOperatorsCompare("1", "2");
			AssertOperatorsCompare<DateTime?>(DateTime.Today, DateTime.Today.AddDays(1));
			AssertOperatorsCompare<SomeEnum?>(SomeEnum.A, SomeEnum.B);
			AssertOperatorsCompare<SomeEnumByte?>(SomeEnumByte.A, SomeEnumByte.B);
			AssertOperatorsCompare<SomeEnumLong?>(SomeEnumLong.A, SomeEnumLong.B);

			/* These will fail as Comparer<T> does not threat 1 > null as false
				AssertOperatorsCompare<int?>(1, null);
				AssertOperatorsCompare<byte?>(1, null);
				AssertOperatorsCompare<double?>(1, null);
				AssertOperatorsCompare<decimal?>(1, null);
				AssertOperatorsCompare("1", null);
				AssertOperatorsCompare<DateTime?>(DateTime.Today, null);
				AssertOperatorsCompare<SomeEnum?>(SomeEnum.A, null);
				AssertOperatorsCompare<SomeEnumByte?>(SomeEnumByte.A, null);
				AssertOperatorsCompare<SomeEnumLong?>(SomeEnumLong.A, null);
			*/
		}
	}
}