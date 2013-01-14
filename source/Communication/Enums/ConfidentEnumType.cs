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
		//открытый документ
		open_doc = 0,
		//документ с ограниченным доступом
		restrict_doc = 1,
	}
}
