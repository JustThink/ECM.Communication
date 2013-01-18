using System;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Enums
{
	[TestFixture]
	public class TransferEnumTypeTest
	{
		[Test]
		public void Case00()
		{
			var type = (TransferEnumType) Enum.ToObject(typeof(TransferEnumType), 0);
			Assert.That(type, Is.EqualTo(TransferEnumType.send_file));
		}

		[Test]
		public void Case01()
		{
			var type = (TransferEnumType) Enum.ToObject(typeof(TransferEnumType), 1);
			Assert.That(type, Is.EqualTo(TransferEnumType.send_file_ref));
		}
	}
}
