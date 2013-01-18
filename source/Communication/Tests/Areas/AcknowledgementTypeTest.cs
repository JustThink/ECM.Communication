using System.Collections.Generic;
using System.Linq;
using ECM.Communication.Areas;
using ECM.Communication.Elements;
using NUnit.Framework;

namespace ECM.Communication.Tests.Areas
{
	[TestFixture]
	public class AcknowledgementTypeTest : HelperTest
	{
		[Test]
		public void TestCreate()
		{
			var type = new AcknowledgementType();
			Assert.IsNullOrEmpty(type.msg_id);
			Assert.IsNull(type.AckResult);
		}

		[Test]
		public void TestMissingAreas_Format()
		{
			var ackResult = ((AcknowledgementType) null).Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.EqualTo(1));
			var obj = ackResult[0];
			EqualTo(obj, ErrorReceiptCode.MissingAreas_Format);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format()
		{
			var type = new AcknowledgementType();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "AckResult";
			var arg1 = AcknowledgementType.ElementName;
			var arg2 = AcknowledgementType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestMissingRequiredAttribute_Formata()
		{
			var type = new AcknowledgementType();
			type.AckResult = new List<AckResult>();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "AckResult";
			var arg1 = AcknowledgementType.ElementName;
			var arg2 = AcknowledgementType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestRequiredAttribute_Format()
		{
			var type = new AcknowledgementType();
			type.AckResult = new List<AckResult>();
			type.AckResult.Add(new AckResult());

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "AckResult";
			var arg1 = AcknowledgementType.ElementName;
			var arg2 = AcknowledgementType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains("<" + arg1 + ">")) && (p.Value.Contains(arg2)))));
			Assert.IsNull(obj);
		}


		[Test]
		public void TestMissingRequiredAttribute_Format2()
		{
			var type = new AcknowledgementType();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "msg_id";
			var arg1 = AcknowledgementType.ElementName;
			var arg2 = AcknowledgementType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestRequiredAttribute_Format2()
		{
			var type = new AcknowledgementType();
			type.msg_id = "msg_id";

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "msg_id";
			var arg1 = AcknowledgementType.ElementName;
			var arg2 = AcknowledgementType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			Assert.IsNull(obj);
		}
	}
}
