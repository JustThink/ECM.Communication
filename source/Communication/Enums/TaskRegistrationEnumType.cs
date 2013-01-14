using System;


namespace ECM.Communication.Enums
{
	/// <summary>
	/// Отметка о регистрации задания
	/// </summary>
	[Serializable()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public enum TaskRegistrationEnumType
	{
		//задание не зарегистрировано в передающей организации
		not_registered = 0,
		//задание зарегистрировано в передающей организации
		registered = 1,

	}
}
