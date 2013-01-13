using System;

namespace ECM.Communication.Enums
{
	/// <summary>
	/// Тип документа
	/// </summary>
	[Serializable()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public enum DocumentEnumType : sbyte
	{
		/// <summary>
		/// Исходящий
		/// </summary>
		outbox = 0,
		/// <summary>
		/// Входящий
		/// </summary>
		inbox = 1,
		/// <summary>
		/// Внутренний
		/// </summary>
		inside = 2,

	}
}
