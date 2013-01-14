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
		//рабочий телефо
		work_phone = 1,
		//домашний телефон
		home_phone = 2,
		//мобильный телефон
		mobile_phone = 3,
		//факс
		fax = 4,
		//адрес электронной почты (email)
		email = 5,
		//адрес web-сайта (страницы)
		website = 6,
		//прочее
		other = 0,


	}
}
