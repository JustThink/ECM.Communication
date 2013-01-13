using System;

namespace ECM.Communication.Enums
{
	/// <summary>
	/// Признак коллективности обращения
	/// </summary>
	[Serializable()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public enum CollectionEnumType : sbyte
	{
		//нет
		no = 0,
		//да
		yes = 1,
	}
}
