using System.Collections.Generic;
using System.Linq;
using ECM.Communication.Areas;
using ECM.Communication.Elements;
using NUnit.Framework;

namespace ECM.Communication.Tests.Areas
{
	[TestFixture]
	public class DocumentTypeTest : HelperTest
	{
		[Test]
		public void TestCreate()
		{
			var type = new DocumentType();
			Assert.IsNull(type.RegNumber);
			Assert.IsNull(type.Confident);
			Assert.IsNull(type.Referred);
			Assert.IsNull(type.DocNumber);
			Assert.IsNull(type.Addressee);
			Assert.IsNull(type.DocTransfer);
			Assert.IsNull(type.RegHistory);
			Assert.IsNull(type.Author);
			Assert.IsNull(type.Validator);
			Assert.IsNull(type.Writer);
			Assert.IsNullOrEmpty(type.idnumber);
		}

		[Test]
		public void TestMissingAreas_Format()
		{
			var ackResult = ((DocumentType) null).Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.EqualTo(1));
			var obj = ackResult[0];
			EqualTo(obj, ErrorReceiptCode.MissingAreas_Format);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format()
		{
			var type = new DocumentType();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "RegNumber";
			var arg1 = DocumentType.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestRequiredAttribute_Format()
		{
			var type = new DocumentType();
			type.RegNumber = new RegNumber();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "RegNumber";
			var arg1 = PrivatePersonWithSign.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format2()
		{
			var type = new DocumentType();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "Confident";
			var arg1 = DocumentType.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestRequiredAttribute_Format2()
		{
			var type = new DocumentType();
			type.Confident = new Confident();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "Confident";
			var arg1 = PrivatePersonWithSign.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format3()
		{
			var type = new DocumentType();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "Author";
			var arg1 = DocumentType.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format3a()
		{
			var type = new DocumentType();
			type.Author = new List<Author>();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "Author";
			var arg1 = DocumentType.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestRequiredAttribute_Format3()
		{
			var type = new DocumentType();
			type.Author = new List<Author>();
			type.Author.Add(new Author());

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "Author";
			var arg1 = DocumentType.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format5()
		{
			var type = new DocumentType();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "idnumber";
			var arg1 = DocumentType.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestRequiredAttribute_Format5()
		{
			var type = new DocumentType();
			type.idnumber = "idnumber";

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "idnumber";
			var arg1 = DocumentType.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			Assert.IsNull(obj);
		}
	}
}
