using System;

namespace ECM.Communication.Enums
{
	/// <summary>
	/// Вид уведомления
	/// </summary>
	[Serializable()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public enum AcknowledgementEnumType : sbyte
	{
		/// <summary>
		/// уведомление о доставке и приеме сообщения;
		/// </summary>
		delivery_and_acceptance = 1,
		/// <summary>
		/// уведомление о регистрации документа в системе управления документами получателя
		/// </summary>
		registered = 2,
	}
}
