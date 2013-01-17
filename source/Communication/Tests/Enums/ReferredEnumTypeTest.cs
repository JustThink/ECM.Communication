using System;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Enums
{
	[TestFixture]
	public class ReferredEnumTypeTest
	{
		[Test]
		public void Case01()
		{
			var type = (ReferredEnumType) Enum.ToObject(typeof(ReferredEnumType), 1);
			Assert.That(type, Is.EqualTo(ReferredEnumType.link_to_doc));
		}

		[Test]
		public void Case02()
		{
			var type = (ReferredEnumType) Enum.ToObject(typeof(ReferredEnumType), 2);
			Assert.That(type, Is.EqualTo(ReferredEnumType.link_to_task));
		}
	}
}
