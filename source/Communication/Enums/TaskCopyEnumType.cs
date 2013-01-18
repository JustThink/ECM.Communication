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
		/// <summary>
		/// задание из передающей организации
		/// </summary>
		direct = 0,
		/// <summary>
		/// копия задания, направленного в передающую организацию
		/// </summary>
		copy = 1,
	}
}
