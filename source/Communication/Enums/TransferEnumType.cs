using System;

namespace ECM.Communication.Enums
{
	/// <summary>
	/// Определяет способ передачи файла
	/// </summary>
	[Serializable()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public enum TransferEnumType
	{
		/// <summary>
		/// передается непосредственно сам файл
		/// </summary>
		send_file = 0,
		/// <summary>
		/// передается указатель местонахождения файла (ссылка на файл).
		/// </summary>
		send_file_ref = 1
	}
}
