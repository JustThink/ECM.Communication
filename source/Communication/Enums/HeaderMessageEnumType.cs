using System;

namespace ECM.Communication.Enums
{
	/// <summary>
	/// Вид сообщения
	/// </summary>
	[Serializable()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public enum HeaderMessageEnumType : sbyte
	{
		/// <summary>
		/// Уведомление
		/// </summary>
		notification = 0,
		/// <summary>
		/// Основной документ
		/// </summary>
		main = 1,
		/// <summary>
		/// Дополнения к основному документу
		/// </summary>
		main_supplement = 2,
		/// <summary>
		/// Документ-ответ
		/// </summary>
		response = 3,
		/// <summary>
		/// Дополнения к документу-ответу
		/// </summary>
		response_supplement = 4,
	}
}
