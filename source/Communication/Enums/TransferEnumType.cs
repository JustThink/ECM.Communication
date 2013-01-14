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
		//передается непосредственно сам файл
		send_file = 0,
		//передается указатель местонахождения файла (ссылка на файл).
		send_file_ref = 1
	}
}
