using System.Collections.Generic;
using System.Linq;
using ECM.Communication.Areas;
using ECM.Communication.Elements;
using NUnit.Framework;

namespace ECM.Communication.Tests.Elements
{
	[TestFixture]
	public class TaskListTypeTaskTest : HelperTest
	{
		[Test]
		public void TestCreate()
		{
			var type = new TaskListTypeTask();
			Assert.IsNull(type.TaskNumber);
			Assert.IsNull(type.Confident);
			Assert.IsNull(type.Referred);
			Assert.IsNull(type.AuthorOrganization);
			Assert.IsNull(type.DocTransfer);
			Assert.IsNull(type.Executor);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format()
		{
			var type = new TaskListTypeTask();

			var ackResult = type.Check(DocumentType.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "TaskNumber";
			var arg1 = TaskListTypeTask.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestRequiredAttribute_Format()
		{
			var type = new TaskListTypeTask();
			type.TaskNumber = new TaskNumber();

			var ackResult = type.Check(DocumentType.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "TaskNumber";
			var arg1 = TaskListTypeTask.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format2()
		{
			var type = new TaskListTypeTask();

			var ackResult = type.Check(DocumentType.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "Confident";
			var arg1 = TaskListTypeTask.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestRequiredAttribute_Format2()
		{
			var type = new TaskListTypeTask();
			type.Confident = new Confident();

			var ackResult = type.Check(DocumentType.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(0));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "Confident";
			var arg1 = TaskListTypeTask.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			Assert.IsNull(obj);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format3()
		{
			var type = new TaskListTypeTask();

			var ackResult = type.Check(DocumentType.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "AuthorOrganization";
			var arg1 = TaskListTypeTask.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format3a()
		{
			var type = new TaskListTypeTask();
			type.AuthorOrganization = new List<AuthorOrganization>();

			var ackResult = type.Check(DocumentType.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "AuthorOrganization";
			var arg1 = TaskListTypeTask.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestRequiredAttribute_Format3()
		{
			var type = new TaskListTypeTask();
			type.AuthorOrganization = new List<AuthorOrganization>();
			type.AuthorOrganization.Add(new AuthorOrganization());

			var ackResult = type.Check(DocumentType.AreaName);
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "AuthorOrganization";
			var arg1 = TaskListTypeTask.ElementName;
			var arg2 = DocumentType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			Assert.IsNull(obj);
		}
	}
}
