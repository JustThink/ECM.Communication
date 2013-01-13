using System;

namespace ECM.Communication.Enums
{
	/// <summary>
	/// Необходимость посылки уведомления
	/// </summary>
	[Serializable()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public enum HeaderAsknowEnumType : sbyte
	{
		/// <summary>
		/// Нет
		/// </summary>
		none = 0,
		/// <summary>
		/// Только при ошибках
		/// </summary>
		only_when_errors = 1,
		/// <summary>
		/// Всегда
		/// </summary>
		always = 2,
	}
}
