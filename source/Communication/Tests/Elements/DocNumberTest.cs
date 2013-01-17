using System.Linq;
using ECM.Communication.Areas;
using ECM.Communication.Elements;
using NUnit.Framework;

namespace ECM.Communication.Tests.Elements
{
	[TestFixture]
	public class DocNumberTest : HelperTest
	{
		[Test]
		public void TestCreate()
		{
			var type = new DocNumber();
			Assert.IsNull(type.OrganizationOnly);
			Assert.IsNull(type.RegNumber);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format()
		{
			var type = new DocNumber();

			var ackResult = type.Check(Header.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "OrganizationOnly";
			var arg1 = DocNumber.ElementName;
			var arg2 = Header.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestRequiredAttribute_Format()
		{
			var type = new DocNumber();
			type.OrganizationOnly = new OrganizationOnly();

			var ackResult = type.Check(Header.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "OrganizationOnly";
			var arg1 = OfficialPerson.ElementName;
			var arg2 = Header.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format2()
		{
			var type = new DocNumber();

			var ackResult = type.Check(Header.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "RegNumber";
			var arg1 = DocNumber.ElementName;
			var arg2 = Header.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestRequiredAttribute_Format2()
		{
			var type = new DocNumber();
			type.RegNumber = new RegNumber();

			var ackResult = type.Check(Header.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "RegNumber";
			var arg1 = OfficialPerson.ElementName;
			var arg2 = Header.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			Assert.IsNull(obj);
		}
	}
}
