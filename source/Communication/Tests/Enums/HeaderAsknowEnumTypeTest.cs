using System;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Enums
{
	[TestFixture]
	public class HeaderAsknowEnumTypeTest
	{
		[Test]
		public void Case00()
		{
			var type = (HeaderAsknowEnumType) Enum.ToObject(typeof(HeaderAsknowEnumType), 0);
			Assert.That(type, Is.EqualTo(HeaderAsknowEnumType.none));
		}

		[Test]
		public void Case01()
		{
			var type = (HeaderAsknowEnumType) Enum.ToObject(typeof(HeaderAsknowEnumType), 1);
			Assert.That(type, Is.EqualTo(HeaderAsknowEnumType.only_when_errors));
		}

		[Test]
		public void Case02()
		{
			var type = (HeaderAsknowEnumType) Enum.ToObject(typeof(HeaderAsknowEnumType), 2);
			Assert.That(type, Is.EqualTo(HeaderAsknowEnumType.always));
		}
	}
}
