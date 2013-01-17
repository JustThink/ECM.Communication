using System;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Enums
{
	[TestFixture]
	public class HeaderMessageEnumTypeTest
	{
		[Test]
		public void Case00()
		{
			var type = (HeaderMessageEnumType) Enum.ToObject(typeof(HeaderMessageEnumType), 0);
			Assert.That(type, Is.EqualTo(HeaderMessageEnumType.notification));
		}

		[Test]
		public void Case01()
		{
			var type = (HeaderMessageEnumType) Enum.ToObject(typeof(HeaderMessageEnumType), 1);
			Assert.That(type, Is.EqualTo(HeaderMessageEnumType.main));
		}

		[Test]
		public void Case02()
		{
			var type = (HeaderMessageEnumType) Enum.ToObject(typeof(HeaderMessageEnumType), 2);
			Assert.That(type, Is.EqualTo(HeaderMessageEnumType.main_supplement));
		}

		[Test]
		public void Case03()
		{
			var type = (HeaderMessageEnumType) Enum.ToObject(typeof(HeaderMessageEnumType), 3);
			Assert.That(type, Is.EqualTo(HeaderMessageEnumType.response));
		}

		[Test]
		public void Case04()
		{
			var type = (HeaderMessageEnumType) Enum.ToObject(typeof(HeaderMessageEnumType), 4);
			Assert.That(type, Is.EqualTo(HeaderMessageEnumType.response_supplement));
		}
	}
}
