using System.Collections.Generic;
using System.Linq;
using ECM.Communication.Areas;
using ECM.Communication.Elements;
using NUnit.Framework;

namespace ECM.Communication.Tests.Elements
{
	[TestFixture]
	public class OrganizationWithSignTest : HelperTest
	{
		[Test]
		public void TestCreate()
		{
			var type = new OrganizationWithSign();
			Assert.IsNull(type.organization_string);
			Assert.IsNull(type.Address);
			Assert.IsNull(type.Econtact);
			Assert.IsNull(type.OfficialPersonWithSign);
		}

		[Test]
		public void TestWrongMultiplicityOfElement_Format()
		{
			var type = new OrganizationWithSign();

			var ackResult = type.Check(Header.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.WrongMultiplicityOfElement_Format;
			var arg0 = "organization_string";
			var arg1 = Header.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)))));
			EqualTo(obj, ex, arg0, arg1);
		}

		[Test]
		public void TestMultiplicityOfElement_Format()
		{
			var type = new OrganizationWithSign();
			type.organization_string = "organization_string";

			var ackResult = type.Check(Header.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.WrongMultiplicityOfElement_Format;
			var arg0 = "organization_string";
			var arg1 = Header.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format2()
		{
			var type = new OrganizationWithSign();

			var ackResult = type.Check(Header.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "OfficialPersonWithSign";
			var arg1 = OrganizationWithSign.ElementName;
			var arg2 = Header.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestWrongMultiplicityOfElement_Format2()
		{
			var type = new OrganizationWithSign();
			type.OfficialPersonWithSign = new List<OfficialPersonWithSign>();
			type.OfficialPersonWithSign.Add(new OfficialPersonWithSign());
			type.OfficialPersonWithSign.Add(new OfficialPersonWithSign());

			var ackResult = type.Check(Header.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.WrongMultiplicityOfElement_Format;
			var arg0 = "OfficialPersonWithSign";
			var arg1 = Header.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)))));
			EqualTo(obj, ex, arg0, arg1);
		}

		[Test]
		public void TestMultiplicityOfElement_Format2()
		{
			var type = new OrganizationWithSign();
			type.OfficialPersonWithSign = new List<OfficialPersonWithSign>();
			type.OfficialPersonWithSign.Add(new OfficialPersonWithSign());

			var ackResult = type.Check(Header.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.WrongMultiplicityOfElement_Format;
			var arg0 = "OfficialPersonWithSign";
			var arg1 = Header.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)))));
			Assert.IsNull(obj);
		}

	}
}
