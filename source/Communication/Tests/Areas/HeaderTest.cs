using ECM.Communication.Areas;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Areas
{
	[TestFixture]
	public class HeaderTest
	{
		[Test]
		public void TestCreate()
		{
			var header = new Header();
			Assert.IsNullOrEmpty(header.standart);
			Assert.IsNullOrEmpty(header.version);
			Assert.That(header.msg_type, Is.EqualTo(((sbyte) (HeaderAsknowEnumType.none))));
			Assert.That(header.msg_acknow, Is.EqualTo(((sbyte) (HeaderMessageEnumType.notification))));
		}
	}
}
