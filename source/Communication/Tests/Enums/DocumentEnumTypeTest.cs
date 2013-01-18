using System;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Enums
{
	[TestFixture]
	public class DocumentEnumTypeTest
	{
		[Test]
		public void Case00()
		{
			var type = (DocumentEnumType) Enum.ToObject(typeof(DocumentEnumType), 0);
			Assert.That(type, Is.EqualTo(DocumentEnumType.outbox));
		}

		[Test]
		public void Case01()
		{
			var type = (DocumentEnumType) Enum.ToObject(typeof(DocumentEnumType), 1);
			Assert.That(type, Is.EqualTo(DocumentEnumType.inbox));
		}

		[Test]
		public void Case02()
		{
			var type = (DocumentEnumType) Enum.ToObject(typeof(DocumentEnumType), 2);
			Assert.That(type, Is.EqualTo(DocumentEnumType.inside));
		}
	}
}
