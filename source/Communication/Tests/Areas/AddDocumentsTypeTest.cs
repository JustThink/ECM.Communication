using System.Collections.Generic;
using System.Linq;
using ECM.Communication.Areas;
using ECM.Communication.Elements;
using NUnit.Framework;

namespace ECM.Communication.Tests.Areas
{
	[TestFixture]
	public class AddDocumentsTypeTest : HelperTest
	{
		[Test]
		public void TestCreate()
		{
			var type = new AddDocumentsType();
			Assert.IsNull(type.Folder);
		}

		[Test]
		public void TestMissingAreas_Format()
		{
			var ackResult = ((AddDocumentsType) null).Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.EqualTo(1));
			var obj = ackResult[0];
			EqualTo(obj, ErrorReceiptCode.MissingAreas_Format);
		}

		[Test]
		public void TestRequiredAttribute_Format2()
		{
			var type = new AddDocumentsType();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "Folder";
			var arg1 = AddDocumentsType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestRequiredAttribute_Format2a()
		{
			var type = new AddDocumentsType();
			type.Folder = new List<AddDocumentsTypeFolder>();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "Folder";
			var arg1 = AddDocumentsType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format2b()
		{
			var type = new AddDocumentsType();
			type.Folder = new List<AddDocumentsTypeFolder>();
			type.Folder.Add(new AddDocumentsTypeFolder());
			type.Folder.Add(new AddDocumentsTypeFolder());

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.WrongMultiplicityOfElement_Format;
			var arg0 = "Folder";
			var arg1 = AddDocumentsType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)))));
			EqualTo(obj, ex, arg0, arg1);
		}

		[Test]
		public void TestRequiredAttribute_Format2c()
		{
			var type = new AddDocumentsType();
			type.Folder = new List<AddDocumentsTypeFolder>();
			type.Folder.Add(new AddDocumentsTypeFolder());

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.WrongMultiplicityOfElement_Format;
			var arg0 = "Folder";
			var arg1 = AddDocumentsType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)))));
			Assert.IsNull(obj);
		}
	}
}
