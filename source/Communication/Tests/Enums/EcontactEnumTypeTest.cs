using System;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Enums
{
	[TestFixture]
	public class EcontactEnumTypeTest
	{
		[Test]
		public void Case01()
		{
			var type = (EcontactEnumType) Enum.ToObject(typeof(EcontactEnumType), 1);
			Assert.That(type, Is.EqualTo(EcontactEnumType.work_phone));
		}

		[Test]
		public void Case02()
		{
			var type = (EcontactEnumType) Enum.ToObject(typeof(EcontactEnumType), 2);
			Assert.That(type, Is.EqualTo(EcontactEnumType.home_phone));
		}

		[Test]
		public void Case03()
		{
			var type = (EcontactEnumType) Enum.ToObject(typeof(EcontactEnumType), 3);
			Assert.That(type, Is.EqualTo(EcontactEnumType.mobile_phone));
		}

		[Test]
		public void Case04()
		{
			var type = (EcontactEnumType) Enum.ToObject(typeof(EcontactEnumType), 4);
			Assert.That(type, Is.EqualTo(EcontactEnumType.fax));
		}

		[Test]
		public void Case05()
		{
			var type = (EcontactEnumType) Enum.ToObject(typeof(EcontactEnumType), 5);
			Assert.That(type, Is.EqualTo(EcontactEnumType.email));
		}

		[Test]
		public void Case06()
		{
			var type = (EcontactEnumType) Enum.ToObject(typeof(EcontactEnumType), 6);
			Assert.That(type, Is.EqualTo(EcontactEnumType.website));
		}

		[Test]
		public void Case00()
		{
			var type = (EcontactEnumType) Enum.ToObject(typeof(EcontactEnumType), 0);
			Assert.That(type, Is.EqualTo(EcontactEnumType.other));
		}
	}
}
