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
		/// <summary>
		/// нет
		/// </summary>
		no = 0,
		/// <summary>
		/// да
		/// </summary>
		yes = 1,
	}
}
