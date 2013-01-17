using System;

namespace ECM.Communication.Enums
{
	/// <summary>
	/// Метка ответственного исполнителя
	/// </summary>
	/// <remarks>
	/// Значение 1 может быть только у одного из списка исполнителей
	/// </remarks>
	[Serializable()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public enum ExecutorEnumType
	{
		/// <summary>
		/// соисполнитель
		/// </summary>
		accessory = 0,
		/// <summary>
		/// ответственный исполнитель
		/// </summary>
		executor = 1,
	}
}
