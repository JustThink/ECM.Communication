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
		/// <summary>
		/// задание не зарегистрировано в передающей организации
		/// </summary>
		not_registered = 0,
		/// <summary>
		/// задание зарегистрировано в передающей организации
		/// </summary>
		registered = 1,

	}
}
