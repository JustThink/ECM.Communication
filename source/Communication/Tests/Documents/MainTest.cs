using ECM.Communication.Documents;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Documents
{
	[TestFixture]
	public class MainTest
	{
		[Test]
		public void TestCreate()
		{
			var doc = new Main();
			Assert.IsNull(doc.Header);
			Assert.IsNull(doc.Document);
			Assert.IsNull(doc.TaskList);
			Assert.IsNull(doc.AddDocuments);
			Assert.IsNull(doc.Expansion);
			Assert.IsNull(doc.DocTransfer);
		}
	}
}
