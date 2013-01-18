using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using ECM.Communication.Enums;

namespace ECM.Communication.Elements
{
	/// <summary>
	/// Представление передаваемого файла документа.
	/// </summary>
	/// <remarks>
	/// Файл в двоичном виде или указатель местонахождения файла (ссылка на файл) в кодировке Base64.
	/// </remarks>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class DocTransfer
	{
		#region Const & Static

		public const string ElementName = "DocTransfer";
		private static System.Xml.Serialization.XmlSerializer serializer;

		#endregion

		#region Properties

		private string osField;

		private string typeField;

		private string type_verField;

		private string char_setField;

		private string descriptionField;

		private TransferEnumType transfertypeField;

		private byte[] valueField;

		#endregion

		#region Constructor

		#endregion

		#region Fields

		/// <summary>
		/// Операционная система, в среде которой определен файл
		/// </summary>
		/// <remarks>
		/// Указывается условное наименование операционной системы, например: Dos, Windows, Solaris, AIX, Linux и т.д.
		/// </remarks>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string os
		{
			get
			{
				return this.osField;
			}
			set
			{
				this.osField = value;
			}
		}

		/// <summary>
		/// Формат файла, определяющий программные средства его обработки (например, визуализации)
		/// </summary>
		/// <remarks>
		/// В качестве типа может использоваться mime тип, расширение файла и т.п.; 
		/// обеспечивающее просмотр этого файла стандартными процедурами операционной системы.
		/// </remarks>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		/// <summary>
		/// Версия формата файла
		/// </summary>
		/// <remarks>
		/// Указывается условное обозначение приложения и/или формата в котором файл был создан.
		/// </remarks>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string type_ver
		{
			get
			{
				return this.type_verField;
			}
			set
			{
				this.type_verField = value;
			}
		}

		/// <summary>
		/// Кодировка текст
		/// </summary>
		/// <remarks>
		/// Согласно установленным видам кодировки: win 1251, КОИ – 8 и т.д.
		/// Указывается в соответствии с международным стандартом именования кодировок.
		/// </remarks>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string char_set
		{
			get
			{
				return this.char_setField;
			}
			set
			{
				this.char_setField = value;
			}
		}

		/// <summary>
		/// Описание документа (файла)
		/// </summary>
		/// <remarks>
		/// Текстовое описание содержимого файла (например, наименование соответствующего документа)
		/// </remarks>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <summary>
		/// Определяет способ передачи файла
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public sbyte transfertype
		{
			get
			{
				return ((sbyte)(this.transfertypeField));
			}
			set
			{
				this.transfertypeField = (TransferEnumType) Enum.ToObject(typeof(TransferEnumType), value);
			}
		}

		[System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
		public byte[] Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		private static System.Xml.Serialization.XmlSerializer Serializer
		{
			get
			{
				if ( (serializer == null) )
				{
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(DocTransfer));
				}
				return serializer;
			}
		}

		#endregion

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current DocTransfer object into an XML document
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
		/// Deserializes workflow markup into an DocTransfer object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output DocTransfer object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out DocTransfer obj, out System.Exception exception)
		{
			exception = null;
			obj = default(DocTransfer);
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

		public static bool Deserialize(string xml, out DocTransfer obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static DocTransfer Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((DocTransfer) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
		/// Serializes current DocTransfer object into file
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
		/// Deserializes xml markup from file into an DocTransfer object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output DocTransfer object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out DocTransfer obj, out System.Exception exception)
		{
			exception = null;
			obj = default(DocTransfer);
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

		public static bool LoadFromFile(string fileName, out DocTransfer obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out DocTransfer obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static DocTransfer LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static DocTransfer LoadFromFile(string fileName, System.Text.Encoding encoding)
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
		public static List<AckResult> Check(this DocTransfer source, string areaName)
		{
			var ackResult = new List<AckResult>();
			if ( string.IsNullOrEmpty(source.os) )
			{
				var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "os", DocTransfer.ElementName, areaName) });
			}
			if ( string.IsNullOrEmpty(source.type) )
			{
				var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "type", DocTransfer.ElementName, areaName) });
			}
			if ( string.IsNullOrEmpty(source.description) )
			{
				var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "description", DocTransfer.ElementName, areaName) });
			}
			return ackResult;
		}
	}
}
