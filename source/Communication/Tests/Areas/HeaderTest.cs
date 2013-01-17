using System;
using System.Linq;
using ECM.Communication.Areas;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Areas
{
	[TestFixture]
	public class HeaderTest : HelperTest
	{
		[Test]
		public void TestCreate()
		{
			var header = new Header();
			Assert.IsNullOrEmpty(header.standart);
			Assert.IsNullOrEmpty(header.version);
			Assert.That(header.msg_type, Is.EqualTo(((sbyte) (HeaderAsknowEnumType.none))));
			Assert.That(header.msg_acknow, Is.EqualTo(((sbyte) (HeaderMessageEnumType.notification))));
		}

		[Test]
		public void TestMissingAreas_Format()
		{
			var ackResult = ((Header) null).Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.EqualTo(1));
			var obj = ackResult[0];
			EqualTo(obj, ErrorReceiptCode.MissingAreas_Format);
		}

		[Test]
		public void TestInvalidAttribute_Standard_in_Header_Format(
			[Values("Вид стандарта", "Допустимое значение")] string standart
			)
		{
			var header = new Header();
			header.standart = standart;

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.InvalidAttribute_Standard_in_Header_Format;
			var obj = ackResult.FirstOrDefault(p => p.errorcode == ex.errorcode);
			EqualTo(obj, ex);
		}

		[Test]
		public void TestStandartFieldDefault()
		{
			var header = new Header();
			header.standart = Header.StandartFieldDefault;

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.InvalidAttribute_Standard_in_Header_Format;
			var obj = ackResult.FirstOrDefault(p => p.errorcode == ex.errorcode);
			Assert.IsNull(obj);
		}

		[Test]
		public void TestInvalidAttribute_Version_in_Header_Format(
			[Values("Версия стандарта", "Допустимое значение")] string standart
			)
		{
			var header = new Header();
			header.standart = standart;

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.InvalidAttribute_Version_in_Header_Format;
			var obj = ackResult.FirstOrDefault(p => p.errorcode == ex.errorcode);
			EqualTo(obj, ex);
		}

		[Test]
		public void TestVersionFieldDefault()
		{
			var header = new Header();
			header.version = Header.VersionFieldDefault;

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.InvalidAttribute_Version_in_Header_Format;
			var obj = ackResult.FirstOrDefault(p => p.errorcode == ex.errorcode);
			Assert.IsNull(obj);
		}

		[Test]
		public void TestInvalidAttribute_MsgType_in_Header_Format(
			[Values(-2, -1,10,20)]sbyte msg_type
			)
		{
			var header = new Header();
			header.msg_type = msg_type;

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.InvalidAttribute_MsgType_in_Header_Format;
			var obj = ackResult.FirstOrDefault(p => p.errorcode == ex.errorcode);
			EqualTo(obj, ex);
		}

		[Test]
		public void TestAttribute_MsgType_in_Header_Format(
			[Values(0, 1, 2, 3, 4)]sbyte msg_type
			)
		{
			var type = (HeaderMessageEnumType) Enum.ToObject(typeof(HeaderMessageEnumType), msg_type);

			var header = new Header();
			header.msg_type = msg_type;

			var ackResult = header.Check(type);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.InvalidAttribute_MsgType_in_Header_Format;
			var obj = ackResult.FirstOrDefault(p => p.errorcode == ex.errorcode);
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingRequiredAttribute_in_Header_Format()
		{
			var header = new Header();

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
			var arg0 = "msg_id";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			EqualTo(obj, ex, arg0);
		}

		[Test]
		public void TestRequiredAttribute_in_Header_Format()
		{
			var header = new Header();
			header.msg_id = "msg_id";

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
			var arg0 = "msg_id";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingRequiredAttribute_in_Header_Format2()
		{
			var header = new Header();

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
			var arg0 = "from_org_id";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			EqualTo(obj, ex, arg0);
		}

		[Test]
		public void TestRequiredAttribute_in_Header_Format2()
		{
			var header = new Header();
			header.from_org_id = "from_org_id";

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
			var arg0 = "from_org_id";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingRequiredAttribute_in_Header_Format3()
		{
			var header = new Header();

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
			var arg0 = "from_organization";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			EqualTo(obj, ex, arg0);
		}

		[Test]
		public void TestRequiredAttribute_in_Header_Format3()
		{
			var header = new Header();
			header.from_organization = "from_organization";

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
			var arg0 = "from_organization";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingRequiredAttribute_in_Header_Format4()
		{
			var header = new Header();

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
			var arg0 = "from_sys_id";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			EqualTo(obj, ex, arg0);
		}

		[Test]
		public void TestRequiredAttribute_in_Header_Format4()
		{
			var header = new Header();
			header.from_sys_id = "from_sys_id";

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
			var arg0 = "from_sys_id";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingRequiredAttribute_in_Header_Format5()
		{
			var header = new Header();

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
			var arg0 = "from_system";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			EqualTo(obj, ex, arg0);
		}

		[Test]
		public void TestRequiredAttribute_in_Header_Format5()
		{
			var header = new Header();
			header.from_system = "from_system";

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
			var arg0 = "from_system";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingRequiredAttribute_in_Header_Format6()
		{
			var header = new Header();

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
			var arg0 = "from_system";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			EqualTo(obj, ex, arg0);
		}

		[Test]
		public void TestRequiredAttribute_in_Header_Format6()
		{
			var header = new Header();
			header.to_organization = "to_organization";

			var ackResult = header.Check(HeaderMessageEnumType.notification);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
			var arg0 = "to_organization";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			Assert.IsNull(obj);
		}
	}
}
