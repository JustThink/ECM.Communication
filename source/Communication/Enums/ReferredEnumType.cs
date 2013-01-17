using System;

namespace ECM.Communication.Enums
{
	/// <summary>
	/// Определение вида ссылки (в стандарте приводиться как тип String, в схеме как Enum)
	/// </summary>
	/// <remarks>
	/// Используется только совместно с атрибутом idnumber
	/// </remarks>
	[Serializable()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public enum ReferredEnumType : sbyte
	{
		/// <summary>
		/// ссылка на документ
		/// </summary>
		link_to_doc = 1,
		/// <summary>
		/// ссылка на задание
		/// </summary>
		link_to_task = 2,
	}
}
