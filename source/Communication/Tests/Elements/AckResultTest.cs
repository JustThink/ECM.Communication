using ECM.Communication.Elements;
using NUnit.Framework;

namespace ECM.Communication.Tests.Elements
{
	[TestFixture]
	public class AckResultTest
	{
		[Test]
		public void TestCreate()
		{
			var type = new AckResult();
			Assert.IsNullOrEmpty(type.Value);
			Assert.That(type.errorcode, Is.EqualTo((ulong)0));
		}
	}
}
