using System;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests.Enums
{
	[TestFixture]
	public class FolderAddEnumTypeTest
	{
		[Test]
		public void Case00()
		{
			var type = (FolderAddEnumType) Enum.ToObject(typeof(FolderAddEnumType), 0);
			Assert.That(type, Is.EqualTo(FolderAddEnumType.attachment));
		}

		[Test]
		public void Case01()
		{
			var type = (FolderAddEnumType) Enum.ToObject(typeof(FolderAddEnumType), 1);
			Assert.That(type, Is.EqualTo(FolderAddEnumType.info_and_help));
		}

		[Test]
		public void Case02()
		{
			var type = (FolderAddEnumType) Enum.ToObject(typeof(FolderAddEnumType), 2);
			Assert.That(type, Is.EqualTo(FolderAddEnumType.doc_ref));
		}
	}
}
