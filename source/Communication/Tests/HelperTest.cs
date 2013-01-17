using System;
using System.Collections.Generic;
using ECM.Communication.Areas;
using ECM.Communication.Elements;
using ECM.Communication.Enums;
using NUnit.Framework;

namespace ECM.Communication.Tests
{
	public abstract class HelperTest
	{
		protected static void EqualTo(Address source, Address target)
		{
			Assert.IsNotNull(source);
			Assert.IsNotNull(target);

			Assert.That(source.street, Is.EqualTo(target.street));
			Assert.That(source.house, Is.EqualTo(target.house));
			Assert.That(source.building, Is.EqualTo(target.building));
			Assert.That(source.flat, Is.EqualTo(target.flat));
			Assert.That(source.settlement, Is.EqualTo(target.settlement));
			Assert.That(source.district, Is.EqualTo(target.district));
			Assert.That(source.region, Is.EqualTo(target.region));
			Assert.That(source.country, Is.EqualTo(target.country));
			Assert.That(source.postсode, Is.EqualTo(target.postсode));
			Assert.That(source.postbox, Is.EqualTo(target.postbox));
			Assert.That(source.nontypical, Is.EqualTo(target.nontypical));
			Assert.That(source.Value, Is.EqualTo(target.Value));
		}


		protected static void EqualTo(AcknowledgementType source, AcknowledgementType target)
		{
			Assert.IsNotNull(source);
			Assert.IsNotNull(target);

			EqualTo(source.RegNumber, target.RegNumber);
			EqualTo(source.AckResult, target.AckResult);
			EqualTo(source.DocTransfer, target.DocTransfer);
			Assert.That(source.msg_id, Is.EqualTo(target.msg_id));
			Assert.That(source.ask_type, Is.EqualTo(target.ask_type));
			var ask_typeField = (AcknowledgementEnumType) Enum.ToObject(typeof(AcknowledgementEnumType), source.ask_type);
		}

		protected static void EqualTo(List<AckResult> source, List<AckResult> target)
		{
			Assert.IsNotNull(source);
			Assert.IsNotNull(target);

			Assert.That(source.Count, Is.EqualTo(target.Count));
			for ( int i = 0; i < source.Count; i++ )
			{
				EqualTo(source[i],target[i]);
			}
		}

		protected static void EqualTo(AckResult source, AckResult target)
		{
			Assert.IsNotNull(source);
			Assert.IsNotNull(target);

			Assert.That(source.errorcode, Is.EqualTo(target.errorcode));
			Assert.That(source.Value, Is.EqualTo(target.Value));
		}

		protected static void EqualTo(DocTransfer source, DocTransfer target)
		{
			Assert.IsNotNull(source);
			Assert.IsNotNull(target);

			Assert.That(source.os, Is.EqualTo(target.os));
			Assert.That(source.type, Is.EqualTo(target.type));
			Assert.That(source.type_ver, Is.EqualTo(target.type_ver));
			Assert.That(source.char_set, Is.EqualTo(target.char_set));
			Assert.That(source.description, Is.EqualTo(target.description));
			Assert.That(source.transfertype, Is.EqualTo(target.transfertype));
			Assert.That(source.Value, Is.EqualTo(target.Value));
		}

		protected static void EqualTo(RegNumber source, RegNumber target)
		{
			Assert.IsNotNull(source);
			Assert.IsNotNull(target);

			Assert.That(source.regdate, Is.EqualTo(target.regdate));
			Assert.That(source.Value, Is.EqualTo(target.Value));
		}


	}
}
