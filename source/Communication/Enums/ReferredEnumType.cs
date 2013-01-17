using System;
namespace ECM.Communication.Enums
{
	/// <summary>
	/// Определение вида ссылки
	/// </summary>
	/// <remarks>
	/// Используется только совместно с атрибутом idnumber
	/// </remarks>
	[Serializable()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public enum ReferredEnumType : sbyte
	{
		//ссылка на документ;
		link_to_doc = 1,
		//ссылка на задание
		link_to_task = 2,
	}
}
