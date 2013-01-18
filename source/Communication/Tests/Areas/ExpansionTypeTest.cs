using System;
using System.Linq;
using ECM.Communication.Areas;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Areas
{
	[TestFixture]
	public class ExpansionTypeTest : HelperTest
	{
		[Test]
		public void TestCreate()
		{
			var header = new ExpansionType();
			Assert.IsNullOrEmpty(header.organization);
		}

		[Test]
		public void TestMissingAreas_Format()
		{
			var ackResult = ((ExpansionType) null).Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.EqualTo(1));
			var obj = ackResult[0];
			EqualTo(obj, ErrorReceiptCode.MissingAreas_Format);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format()
		{
			var header = new ExpansionType();

			var ackResult = header.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "organization";
			var arg1 = ExpansionType.ElementName;
			string arg2 = ExpansionType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0)) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestRequiredAttribute_Format()
		{
			var header = new ExpansionType();
			header.organization = "organization";

			var ackResult = header.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "organization";
			var arg1 = ExpansionType.ElementName;
			string arg2 = ExpansionType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0)) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format2()
		{
			var header = new ExpansionType();

			var ackResult = header.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "exp_ver";
			var arg1 = ExpansionType.ElementName;
			string arg2 = ExpansionType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0)) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestRequiredAttribute_Format2()
		{
			var header = new ExpansionType();
			header.exp_ver = "exp_ver";

			var ackResult = header.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "exp_ver";
			var arg1 = ExpansionType.ElementName;
			string arg2 = ExpansionType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0)) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2))));
			Assert.IsNull(obj);
		}
	}
}
