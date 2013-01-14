using System;
namespace ECM.Communication.Enums
{
	/// <summary>
	/// Отметка о передаче копии задания
	/// </summary>
	[Serializable()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public enum TaskCopyEnumType
	{
		//задание из передающей организации
		direct = 0,
		//копия задания, направленного в передающую организацию
		copy = 1,
	}
}
