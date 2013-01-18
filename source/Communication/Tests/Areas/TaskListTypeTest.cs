using System.Collections.Generic;
using System.Linq;
using ECM.Communication.Areas;
using ECM.Communication.Elements;
using NUnit.Framework;

namespace ECM.Communication.Tests.Areas
{
	[TestFixture]
	public class TaskListTypeTest : HelperTest
	{
		[Test]
		public void TestCreate()
		{
			var type = new TaskListType();
			Assert.IsNull(type.Task);
		}

		[Test]
		public void TestMissingAreas_Format()
		{
			var ackResult = ((TaskListType) null).Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.EqualTo(1));
			var obj = ackResult[0];
			EqualTo(obj, ErrorReceiptCode.MissingAreas_Format);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format2()
		{
			var type = new TaskListType();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "Task";
			var arg1 = TaskListType.ElementName;
			var arg2 = TaskListType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestMissingRequiredAttribute_Format2a()
		{
			var type = new TaskListType();
			type.Task = new List<TaskListTypeTask>();

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "Task";
			var arg1 = TaskListType.ElementName;
			var arg2 = TaskListType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains(arg1)) && (p.Value.Contains(arg2)))));
			EqualTo(obj, ex, arg0, arg1, arg2);
		}

		[Test]
		public void TestRequiredAttribute_Format2()
		{
			var type = new TaskListType();
			type.Task = new List<TaskListTypeTask>();
			type.Task.Add(new TaskListTypeTask());

			var ackResult = type.Check();
			Assert.IsNotNull(ackResult);
			Assert.That(ackResult.Count, Is.GreaterThanOrEqualTo(1));
			var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
			var arg0 = "Task";
			var arg1 = TaskListType.ElementName;
			var arg2 = TaskListType.AreaName;
			var obj = ackResult.FirstOrDefault(p => ((p.errorcode == ex.errorcode) && (p.Value.Contains(arg0) && (p.Value.Contains("<" + arg1 + ">")) && (p.Value.Contains(arg2)))));
			Assert.IsNull(obj);
		}
	}
}
