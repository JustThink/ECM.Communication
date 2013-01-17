using System;

namespace ECM.Communication.Enums
{
	/// <summary>
	/// Тип номера (адреса)
	/// </summary>
	[Serializable()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public enum EcontactEnumType
	{
		/// <summary>
		/// рабочий телефон
		/// </summary>
		work_phone = 1,
		/// <summary>
		/// домашний телефон
		/// </summary>
		home_phone = 2,
		/// <summary>
		/// мобильный телефон
		/// </summary>
		mobile_phone = 3,
		/// <summary>
		/// факс
		/// </summary>
		fax = 4,
		/// <summary>
		/// адрес электронной почты (email)
		/// </summary>
		email = 5,
		/// <summary>
		/// адрес web-сайта (страницы)
		/// </summary>
		website = 6,
		/// <summary>
		/// прочее
		/// </summary>
		other = 0,
	}
}
