using ECM.Communication.Documents;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Documents
{
	[TestFixture]
	public class NotificationTest
	{
		[Test]
		public void TestCreate()
		{
			var doc = new Notification();
			Assert.IsNotNull(doc.Header);
			Assert.That(doc.Header.msg_type, Is.EqualTo((sbyte) HeaderMessageEnumType.notification));
			Assert.IsNotNull(doc.Document);
			Assert.IsNotNull(doc.Acknowledgement);
			Assert.IsNotNull(doc.DocTransfer);
			Assert.That(doc.DocTransfer.Count, Is.EqualTo(0));
		}
	}
}
