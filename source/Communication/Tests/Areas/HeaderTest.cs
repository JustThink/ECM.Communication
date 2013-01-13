using ECM.Communication.Areas;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Areas
{
	[TestFixture]
	public class HeaderTest
	{
		[Test]
		public void TestFieldDefault()
		{
			var header = new Header();
			Assert.That(header.standart, Is.EqualTo("Стандарт системы управления документами"));
			Assert.That(header.version, Is.EqualTo("1.0"));
			Assert.That(header.msg_type, Is.EqualTo(((sbyte) (HeaderAsknowEnumType.none))));
			Assert.That(header.msg_acknow, Is.EqualTo(((sbyte) (HeaderMessageEnumType.notification))));
		}
	}
}
