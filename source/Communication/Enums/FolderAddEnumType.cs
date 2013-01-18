using System;

namespace ECM.Communication.Enums
{
	/// <summary>
	/// Вид прилагаемых материалов
	/// </summary>
	[Serializable()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public enum FolderAddEnumType
	{
		/// <summary>
		/// данные материалы являются приложениями документа (его составной частью)
		/// </summary>
		attachment = 0,
		/// <summary>
		/// материалы носят информационно-справочный характер (ответы на запросы, сделанные для исполнения документа, и т.п.)
		/// </summary>
		info_and_help = 1,
		/// <summary>
		/// данные материалы являются ссылками на другие документы (документы, отменяемые данным документом, документы, во исполнение которых подготовлен данный документ и т.п.)
		/// </summary>
		doc_ref = 2,

	}
}
