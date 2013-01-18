using System;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Enums
{
	[TestFixture]
	public class ConfidentEnumTypeTest
	{
		[Test]
		public void Case00()
		{
			var type = (ConfidentEnumType) Enum.ToObject(typeof(ConfidentEnumType), 0);
			Assert.That(type, Is.EqualTo(ConfidentEnumType.open_doc));
		}

		[Test]
		public void Case01()
		{
			var type = (ConfidentEnumType) Enum.ToObject(typeof(ConfidentEnumType), 1);
			Assert.That(type, Is.EqualTo(ConfidentEnumType.restrict_doc));
		}
	}
}
