﻿using System;

using NUnit.Framework;

#pragma warning disable 649

namespace CodeJam.Mapping.Examples
{
	class Class1
	{
		public int    Prop1 { get; set; }
		public string Field1;
	}

	class Class2
	{
		public string    Prop1 { get; set; }
		public DateTime? Field1;
	}

	[TestFixture]
	public class MapTest
	{
		static readonly Mapper<Class1,Class2> _class1ToClass2Mapper = Map.GetMapper<Class1,Class2>();

		[Test]
		public void Test1()
		{
			// Create new Class2 and map Class1 to it.
			//
			var c2 = _class1ToClass2Mapper.Map(
				new Class1
				{
					Prop1  = 41,
					Field1 = "2016-01-01"
				});

			Assert.That(c2.Prop1,        Is.EqualTo("41"));
			Assert.That(c2.Field1?.Year, Is.EqualTo(2016));
		}

		[Test]
		public void Test2()
		{
			var c2 = new Class2();

			// Map Class1 to existing Class2.
			//
			_class1ToClass2Mapper.Map(
				new Class1
				{
					Prop1  = 41,
					Field1 = "2016-01-01"
				}, c2);

			Assert.That(c2.Prop1,        Is.EqualTo("41"));
			Assert.That(c2.Field1?.Year, Is.EqualTo(2016));
		}
	}
}