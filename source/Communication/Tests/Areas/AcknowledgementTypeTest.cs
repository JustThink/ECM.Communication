using ECM.Communication.Areas;
using NUnit.Framework;

namespace ECM.Communication.Tests.Areas
{
	[TestFixture]
	public class AcknowledgementTypeTest
	{
		[Test]
		public void TestCreate()
		{
			var type = new AcknowledgementType();
			Assert.IsNullOrEmpty(type.msg_id);
			Assert.That(type.ask_type, Is.EqualTo((sbyte)0));
			Assert.IsNotNull(type.RegNumber);
			Assert.IsNotNull(type.AckResult);
			Assert.That(type.AckResult.Count, Is.EqualTo(0));
			Assert.IsNotNull(type.DocTransfer);
		}
	}
}
