using System.Linq;
using ECM.Communication.Areas;
using ECM.Communication.Documents;
using NUnit.Framework;

namespace ECM.Communication.Tests.Documents
{
	[TestFixture]
	public class ResponseTest : HelperTest
	{
		[Test]
		public void TestCreate()
		{
			var doc = new Response();
			Assert.IsNull(doc.Header);
			Assert.IsNull(doc.Document);
			Assert.IsNull(doc.AddDocuments);
			Assert.IsNull(doc.Expansion);
			Assert.IsNull(doc.DocTransfer);
		}

		[Test]
		public void TestMissingAreas_Format()
		{
			var type = new Response();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingAreas_Format;
			var arg0 = "Header";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			EqualTo(obj, ex, arg0);
		}

		[Test]
		public void TestAreas_Format()
		{
			var type = new Response();
			type.Header = new Header();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingAreas_Format;
			var arg0 = "Header";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingAreas_Format2()
		{
			var type = new Response();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingAreas_Format;
			var arg0 = "Document";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			EqualTo(obj, ex, arg0);
		}

		[Test]
		public void TestAreas_Format2()
		{
			var type = new Response();
			type.Document = new DocumentType();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingAreas_Format;
			var arg0 = "Document";
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0))));
			Assert.IsNull(obj);
		}
	}
}
