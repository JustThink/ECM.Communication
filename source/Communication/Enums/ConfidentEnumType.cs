using System;


namespace ECM.Communication.Enums
{
	/// <summary>
	/// Признак ограничения доступа к документу
	/// </summary>
	[Serializable()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public enum ConfidentEnumType
	{
		/// <summary>
		/// открытый документ
		/// </summary>
		open_doc = 0,
		/// <summary>
		/// документ с ограниченным доступом
		/// </summary>
		restrict_doc = 1,
	}
}
