using System.Collections.Generic;
using System.Linq;
using ECM.Communication.Areas;
using ECM.Communication.Elements;
using NUnit.Framework;

namespace ECM.Communication.Tests.Elements
{
	[TestFixture]
	public class OrganizationTest : HelperTest
	{
		[Test]
		public void TestCreate()
		{
			var type = new Organization();
			Assert.IsNull(type.organization_string);
		}

		[Test]
		public void TestWrongMultiplicityOfElement_Format()
		{
			var type = new Organization();

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
			var type = new Organization();
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
		public void TestWrongMultiplicityOfElement_Format2()
		{
			var type = new Organization();
			type.OfficialPerson = new List<OfficialPerson>();
			type.OfficialPerson.Add(new OfficialPerson());
			type.OfficialPerson.Add(new OfficialPerson());

			var ackResult = type.Check(Header.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.WrongMultiplicityOfElement_Format;
			var arg0 = "OfficialPerson";
			var arg1 = Header.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)))));
			EqualTo(obj, ex, arg0, arg1);
		}

		[Test]
		public void TestMultiplicityOfElement_Format2()
		{
			var type = new Organization();
			type.OfficialPerson = new List<OfficialPerson>();
			type.OfficialPerson.Add(new OfficialPerson());

			var ackResult = type.Check(Header.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.WrongMultiplicityOfElement_Format;
			var arg0 = "OfficialPerson";
			var arg1 = Header.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)))));
			Assert.IsNull(obj);
		}

	}
}
