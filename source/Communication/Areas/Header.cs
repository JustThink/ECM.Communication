using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using ECM.Communication.Elements;
using ECM.Communication.Enums;

namespace ECM.Communication.Areas
{
	/// <summary>
	/// Заголовок
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[Serializable()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Header
	{
		#region Const & Static

		public const string AreaName = "Заголовок";

		public const string StandartFieldDefault = @"Стандарт системы управления документами";
		public const string VersionFieldDefault = @"1.0";

		#endregion

		#region Properties

		private string standartField;

		private string versionField;

		private DateTime timeField;

		private HeaderMessageEnumType msg_typeField;

		private string msg_idField;

		private HeaderAsknowEnumType msg_acknowField;

		private string from_org_idField;

		private string from_organizationField;

		private string from_departmentField;

		private string from_sys_idField;

		private string from_systemField;

		private string from_system_detailsField;

		private string to_org_idField;

		private string to_organizationField;

		private string to_departmentField;

		private string to_sys_idField;

		private string to_systemField;

		private string to_system_detailsField;

		private static System.Xml.Serialization.XmlSerializer serializer;

		#endregion

		#region Constructor

		#endregion

		#region Fields

		/// <summary>
		/// Вид стандарта, по которому создано данное сообщение.
		/// </summary>
		/// <remarks>
		/// Допустимое значение: «Стандарт системы управления документами»
		/// </remarks>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string standart
		{
			get 
			{
				return this.standartField;
			}
			set
			{
				this.standartField = value;
			}
		}

		/// <summary>
		/// Версия стандарта
		/// </summary>
		/// <remarks>
		/// Допустимое значение: «1.0»
		/// </remarks>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
			}
		}

		/// <summary>
		/// Дата и время формирования сообщения
		/// </summary>
		/// <remarks>
		/// Дата и время в системе UTC
		/// </remarks>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public DateTime time
		{
			get
			{
				return this.timeField;
			}
			set
			{
				this.timeField = value;
			}
		}

		/// <summary>
		/// Вид сообщения
		/// Влияет на перечень допустимых элементов (зон) в сообщении
		/// </summary>
		/// <remarks>
		/// 0 - Уведомление,
		/// 1 - Основной документ,
		/// 2 - Дополнения к основному документу,
		/// 3 - Документ-ответ,
		/// 4 - Дополнения к документу-ответу
		/// </remarks>
		/// <seealso cref="HeaderMessageEnumType"/>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public sbyte msg_type
		{
			get
			{
				return ((sbyte) (this.msg_typeField));
			}
			set
			{
				this.msg_typeField = (HeaderMessageEnumType) Enum.ToObject(typeof(HeaderMessageEnumType), value);
			}
		}

		/// <summary>
		/// Уникальный служебный идентификационный номер сообщения
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string msg_id
		{
			get
			{
				return this.msg_idField;
			}
			set
			{
				this.msg_idField = value;
			}
		}

		/// <summary>
		/// Необходимость посылки уведомления
		/// </summary>
		/// <remarks>
		/// 0- Нет,
		/// 1- Только при ошибках,
		/// 2- Всегда.
		/// По умолчанию 
		/// (отсутствие атрибута) – 0
		/// </remarks>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(sbyte), "0")]
		public sbyte msg_acknow
		{
			get
			{
				return ((sbyte) (this.msg_acknowField));
			}
			set
			{
				this.msg_acknowField = (HeaderAsknowEnumType) Enum.ToObject(typeof(HeaderAsknowEnumType), value);
			}
		}

		/// <summary>
		/// Уникальный служебный идентификационный номер отправителя
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string from_org_id
		{
			get
			{
				return this.from_org_idField;
			}
			set
			{
				this.from_org_idField = value;
			}
		}

		/// <summary>
		/// Организация-отправитель
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string from_organization
		{
			get
			{
				return this.from_organizationField;
			}
			set
			{
				this.from_organizationField = value;
			}
		}

		/// <summary>
		/// Подразделение-отправитель
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string from_department
		{
			get
			{
				return this.from_departmentField;
			}
			set
			{
				this.from_departmentField = value;
			}
		}

		/// <summary>
		/// Уникальный служебный идентификационный номер системы отправителя
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string from_sys_id
		{
			get
			{
				return this.from_sys_idField;
			}
			set
			{
				this.from_sys_idField = value;
			}
		}

		/// <summary>
		/// Наименование системы управления документами отправителя
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string from_system
		{
			get
			{
				return this.from_systemField;
			}
			set
			{
				this.from_systemField = value;
			}
		}

		/// <summary>
		/// Дополнительные данные о системе управления документами отправителя
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string from_system_details
		{
			get
			{
				return this.from_system_detailsField;
			}
			set
			{
				this.from_system_detailsField = value;
			}
		}

		/// <summary>
		/// Уникальный служебный идентификационный номер получателя
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string to_org_id
		{
			get
			{
				return this.to_org_idField;
			}
			set
			{
				this.to_org_idField = value;
			}
		}

		/// <summary>
		/// Организация- получатель
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string to_organization
		{
			get
			{
				return this.to_organizationField;
			}
			set
			{
				this.to_organizationField = value;
			}
		}

		/// <summary>
		/// Подразделение-получатель
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string to_department
		{
			get
			{
				return this.to_departmentField;
			}
			set
			{
				this.to_departmentField = value;
			}
		}

		/// <summary>
		/// Уникальный служебный идентификационный номер системы получателя
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string to_sys_id
		{
			get
			{
				return this.to_sys_idField;
			}
			set
			{
				this.to_sys_idField = value;
			}
		}

		/// <summary>
		/// Наименование системы управления документами получателя
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string to_system
		{
			get
			{
				return this.to_systemField;
			}
			set
			{
				this.to_systemField = value;
			}
		}

		/// <summary>
		/// Дополнительные данные о системе управления документами получателя
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string to_system_details
		{
			get
			{
				return this.to_system_detailsField;
			}
			set
			{
				this.to_system_detailsField = value;
			}
		}

		private static System.Xml.Serialization.XmlSerializer Serializer
		{
			get
			{
				if ( (serializer == null) )
				{
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(Header));
				}
				return serializer;
			}
		}

		#endregion

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current Header object into an XML document
		/// </summary>
		/// <returns>string XML value</returns>
		public virtual string Serialize(System.Text.Encoding encoding)
		{
			System.IO.StreamReader streamReader = null;
			System.IO.MemoryStream memoryStream = null;
			try
			{
				memoryStream = new System.IO.MemoryStream();
				System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
				xmlWriterSettings.Encoding = encoding;
				System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
				Serializer.Serialize(xmlWriter, this);
				memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
				streamReader = new System.IO.StreamReader(memoryStream);
				return streamReader.ReadToEnd();
			}
			finally
			{
				if ( (streamReader != null) )
				{
					streamReader.Dispose();
				}
				if ( (memoryStream != null) )
				{
					memoryStream.Dispose();
				}
			}
		}

		public virtual string Serialize()
		{
			return Serialize(Encoding.UTF8);
		}

		/// <summary>
		/// Deserializes workflow markup into an Header object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output Header object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out Header obj, out System.Exception exception)
		{
			exception = null;
			obj = default(Header);
			try
			{
				obj = Deserialize(xml);
				return true;
			}
			catch ( System.Exception ex )
			{
				exception = ex;
				return false;
			}
		}

		public static bool Deserialize(string xml, out Header obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static Header Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((Header) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
			}
			finally
			{
				if ( (stringReader != null) )
				{
					stringReader.Dispose();
				}
			}
		}

		/// <summary>
		/// Serializes current Header object into file
		/// </summary>
		/// <param name="fileName">full path of outupt xml file</param>
		/// <param name="exception">output Exception value if failed</param>
		/// <returns>true if can serialize and save into file; otherwise, false</returns>
		public virtual bool SaveToFile(string fileName, System.Text.Encoding encoding, out System.Exception exception)
		{
			exception = null;
			try
			{
				SaveToFile(fileName, encoding);
				return true;
			}
			catch ( System.Exception e )
			{
				exception = e;
				return false;
			}
		}

		public virtual bool SaveToFile(string fileName, out System.Exception exception)
		{
			return SaveToFile(fileName, Encoding.UTF8, out exception);
		}

		public virtual void SaveToFile(string fileName)
		{
			SaveToFile(fileName, Encoding.UTF8);
		}

		public virtual void SaveToFile(string fileName, System.Text.Encoding encoding)
		{
			System.IO.StreamWriter streamWriter = null;
			try
			{
				string xmlString = Serialize(encoding);
				streamWriter = new System.IO.StreamWriter(fileName, false, Encoding.UTF8);
				streamWriter.WriteLine(xmlString);
				streamWriter.Close();
			}
			finally
			{
				if ( (streamWriter != null) )
				{
					streamWriter.Dispose();
				}
			}
		}

		/// <summary>
		/// Deserializes xml markup from file into an Header object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output Header object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out Header obj, out System.Exception exception)
		{
			exception = null;
			obj = default(Header);
			try
			{
				obj = LoadFromFile(fileName, encoding);
				return true;
			}
			catch ( System.Exception ex )
			{
				exception = ex;
				return false;
			}
		}

		public static bool LoadFromFile(string fileName, out Header obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out Header obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static Header LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static Header LoadFromFile(string fileName, System.Text.Encoding encoding)
		{
			System.IO.FileStream file = null;
			System.IO.StreamReader sr = null;
			try
			{
				file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
				sr = new System.IO.StreamReader(file, encoding);
				string xmlString = sr.ReadToEnd();
				sr.Close();
				file.Close();
				return Deserialize(xmlString);
			}
			finally
			{
				if ( (file != null) )
				{
					file.Dispose();
				}
				if ( (sr != null) )
				{
					sr.Dispose();
				}
			}
		}
		#endregion

	}

	internal static partial class Expansion
	{
		public static List<AckResult> Check(this Header header, HeaderMessageEnumType msg_type)
		{
			var ackResult = new List<AckResult>();

			if ( header == null )
			{
				var ex = ErrorReceiptCode.MissingAreas_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, Header.AreaName) });
				return ackResult;
			}

			if ( header.standart != Header.StandartFieldDefault )
			{
				var ex = ErrorReceiptCode.InvalidAttribute_Standard_in_Header_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, header.standart) });
			}
			if ( header.version != Header.VersionFieldDefault )
			{
				var ex = ErrorReceiptCode.InvalidAttribute_Version_in_Header_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, header.version) });
			}
			if ( header.msg_type != ((sbyte) msg_type) )
			{
				var ex = ErrorReceiptCode.InvalidAttribute_MsgType_in_Header_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, header.msg_type) });
			}
			if ( string.IsNullOrEmpty(header.msg_id) )
			{
				var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "msg_id") });
			}
			if ( string.IsNullOrEmpty(header.from_org_id) )
			{
				var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "from_org_id") });
			}
			if ( string.IsNullOrEmpty(header.from_organization) )
			{
				var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "from_organization") });
			}
			if ( string.IsNullOrEmpty(header.from_sys_id) )
			{
				var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "from_sys_id") });
			}
			if ( string.IsNullOrEmpty(header.from_system) )
			{
				var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "from_system") });
			}
			if ( string.IsNullOrEmpty(header.to_organization) )
			{
				var ex = ErrorReceiptCode.MissingRequiredAttribute_in_Header_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "to_organization") });
			}
			return ackResult;
		}
	}
}
