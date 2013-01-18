using System;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Enums
{
	[TestFixture]
	public class CollectionEnumTypeTest
	{
		[Test]
		public void Case00()
		{
			var type = (CollectionEnumType) Enum.ToObject(typeof(CollectionEnumType), 0);
			Assert.That(type, Is.EqualTo(CollectionEnumType.no));
		}

		[Test]
		public void Case01()
		{
			var type = (CollectionEnumType) Enum.ToObject(typeof(CollectionEnumType), 1);
			Assert.That(type, Is.EqualTo(CollectionEnumType.yes));
		}
	}
}
