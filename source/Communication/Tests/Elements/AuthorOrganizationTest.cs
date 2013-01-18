using System.Linq;
using ECM.Communication.Areas;
using ECM.Communication.Elements;
using NUnit.Framework;

namespace ECM.Communication.Tests.Elements
{
	[TestFixture]
	public class AuthorOrganizationTest : HelperTest
	{
		[Test]
		public void TestCreate()
		{
			var type = new AuthorOrganization();
			Assert.IsNull(type.OrganizationWithSign);
		}

		[Test]
		public void TestWrongMultiplicityOfElement_Format()
		{
			var type = new AuthorOrganization();

			var ackResult = type.Check(Header.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.WrongMultiplicityOfElement_Format;
			var arg0 = "OrganizationWithSign";
			var arg1 = Header.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)))));
			EqualTo(obj, ex, arg0, arg1);
		}

		[Test]
		public void TestMultiplicityOfElement_Format()
		{
			var type = new AuthorOrganization();
			type.OrganizationWithSign = new OrganizationWithSign();

			var ackResult = type.Check(Header.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.WrongMultiplicityOfElement_Format;
			var arg0 = "OrganizationWithSign";
			var arg1 = Header.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)))));
			Assert.IsNull(obj);
		}
	}
}
