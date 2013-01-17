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
		//соисполнитель
		accessory = 0,
		//ответственный исполнитель
		executor = 1,
	}
}
