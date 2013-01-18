using System;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Enums
{
	[TestFixture]
	public class AcknowledgementEnumTypeTest
	{
		[Test]
		public void Case01()
		{
			var type = (AcknowledgementEnumType) Enum.ToObject(typeof(AcknowledgementEnumType), 1);
			Assert.That(type, Is.EqualTo(AcknowledgementEnumType.delivery_and_acceptance));
		}

		[Test]
		public void Case02()
		{
			var type = (AcknowledgementEnumType) Enum.ToObject(typeof(AcknowledgementEnumType), 2);
			Assert.That(type, Is.EqualTo(AcknowledgementEnumType.registered));
		}
	}
}
