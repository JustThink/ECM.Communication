using System;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Enums
{
	[TestFixture]
	public class TaskRegistrationEnumTypeTest
	{
		[Test]
		public void Case00()
		{
			var type = (TaskRegistrationEnumType) Enum.ToObject(typeof(TaskRegistrationEnumType), 0);
			Assert.That(type, Is.EqualTo(TaskRegistrationEnumType.not_registered));
		}

		[Test]
		public void Case01()
		{
			var type = (TaskRegistrationEnumType) Enum.ToObject(typeof(TaskRegistrationEnumType), 1);
			Assert.That(type, Is.EqualTo(TaskRegistrationEnumType.registered));
		}
	}
}
