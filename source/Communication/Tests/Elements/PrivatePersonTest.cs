﻿using System.Linq;
using ECM.Communication.Areas;
using ECM.Communication.Elements;
using NUnit.Framework;

namespace ECM.Communication.Tests.Elements
{
	[TestFixture]
	public class PrivatePersonTest : HelperTest
	{
		[Test]
		public void TestCreate()
		{
			var type = new PrivatePerson();
			Assert.IsNull(type.Name);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format()
		{
			var type = new PrivatePerson();

			var ackResult = type.Check(Header.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "Name";
			var arg1 = PrivatePerson.ElementName;
			var arg2 = Header.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestRequiredAttribute_Format()
		{
			var type = new PrivatePerson();
			type.Name = new Name();

			var ackResult = type.Check(Header.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "Name";
			var arg1 = PrivatePerson.ElementName;
			var arg2 = Header.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			Assert.IsNull(obj);
		}
	}
}
