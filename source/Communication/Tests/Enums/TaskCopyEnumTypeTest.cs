using System;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Enums
{
	[TestFixture]
	public class TaskCopyEnumTypeTest
	{
		[Test]
		public void Case00()
		{
			var type = (TaskCopyEnumType) Enum.ToObject(typeof(TaskCopyEnumType), 0);
			Assert.That(type, Is.EqualTo(TaskCopyEnumType.direct));
		}

		[Test]
		public void Case01()
		{
			var type = (TaskCopyEnumType) Enum.ToObject(typeof(TaskCopyEnumType), 1);
			Assert.That(type, Is.EqualTo(TaskCopyEnumType.copy));
		}
	}
}
