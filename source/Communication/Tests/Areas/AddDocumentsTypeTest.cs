using ECM.Communication.Areas;
using NUnit.Framework;

namespace ECM.Communication.Tests.Areas
{
	[TestFixture]
	public class AddDocumentsTypeTest
	{
		[Test]
		public void TestCreate()
		{
			var type = new AddDocumentsType();
			Assert.IsNotNull(type.Folder);
			Assert.That(type.Folder.Count, Is.EqualTo(0));
		}
	}
}
