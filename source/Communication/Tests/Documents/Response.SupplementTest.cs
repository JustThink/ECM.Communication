using ECM.Communication.Documents;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Documents
{
	[TestFixture]
	public class ResponseSupplementTest
	{
		[Test]
		public void TestCreate()
		{
			var doc = new ResponseSupplement();
			Assert.IsNotNull(doc.Header);
			Assert.That(doc.Header.msg_type, Is.EqualTo((sbyte) HeaderMessageEnumType.response_supplement));
			Assert.IsNotNull(doc.Document);
			Assert.IsNotNull(doc.AddDocuments);
			Assert.That(doc.AddDocuments.Count, Is.EqualTo(0));
			Assert.IsNotNull(doc.Expansion);
			Assert.IsNotNull(doc.DocTransfer);
			Assert.That(doc.DocTransfer.Count, Is.EqualTo(0));
		}
	}
}
