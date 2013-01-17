using System;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Enums
{
	[TestFixture]
	public class ExecutorEnumTypeTest
	{
		[Test]
		public void Case00()
		{
			var type = (ExecutorEnumType) Enum.ToObject(typeof(ExecutorEnumType), 0);
			Assert.That(type, Is.EqualTo(ExecutorEnumType.accessory));
		}

		[Test]
		public void Case01()
		{
			var type = (ExecutorEnumType) Enum.ToObject(typeof(ExecutorEnumType), 1);
			Assert.That(type, Is.EqualTo(ExecutorEnumType.executor));
		}
	}
}
