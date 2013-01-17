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
	/// Уведомление (подтверждение приема)
	/// </summary>
	/// <remarks>
	/// Содержит ответную информацию о доставке сообщения, об ошибках приема и интерпретации сообщения, о регистрации полученного документа и др.
	/// Данная зона в сообщении может передаваться только с заголовком сообщения и с зоной Расширение
	/// </remarks>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[Serializable()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class AcknowledgementType
	{
		#region Const & Static

		public const string AreaName = "Уведомление (подтверждение приема)";

		private static System.Xml.Serialization.XmlSerializer serializer;

		#endregion

		#region Properties

		private RegNumber regNumberField;

		private List<AckResult> ackResultField;

		private DocTransfer docTransferField;

		private string msg_idField;

		private AcknowledgementEnumType ask_typeField;

		#endregion

		#region Constructor

		public AcknowledgementType()
		{
			this.regNumberField = new RegNumber();
			this.ackResultField = new List<AckResult>();
			this.docTransferField = new DocTransfer();
		}

		#endregion

		#region Fields

		/// <summary>
		/// Регистрационный номер документа, присвоенный в системе-получателе.
		/// Кратность = 1 для сообщений об успешной регистрации документа (вид сообщения - «Уведомление о регистрации документа»)
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute(Order = 0)]
		public RegNumber RegNumber
		{
			get
			{
				return this.regNumberField;
			}
			set
			{
				this.regNumberField = value;
			}
		}

		/// <summary>
		/// Содержательная часть уведомления
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("AckResult", Order = 1)]
		public List<AckResult> AckResult
		{
			get
			{
				return this.ackResultField;
			}
			set
			{
				this.ackResultField = value;
			}
		}

		/// <summary>
		/// Файл не разобранного сообщения 
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute(Order = 2)]
		public DocTransfer DocTransfer
		{
			get
			{
				return this.docTransferField;
			}
			set
			{
				this.docTransferField = value;
			}
		}

		/// <summary>
		/// Уникальный служебный идентификационный номер поступившего сообщения
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
		/// Вид уведомления
		/// </summary>
		/// <remarks>
		/// 1 - уведомление о доставке и приеме сообщения;
		/// 2 - уведомление о регистрации документа в системе управления документами получателя
		/// </remarks>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public sbyte ask_type
		{
			get
			{
				return ((sbyte)this.ask_typeField);
			}
			set
			{
				this.ask_typeField = (AcknowledgementEnumType) Enum.ToObject(typeof(AcknowledgementEnumType), value);
			}
		}

		private static System.Xml.Serialization.XmlSerializer Serializer
		{
			get
			{
				if ( (serializer == null) )
				{
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(AcknowledgementType));
				}
				return serializer;
			}
		}

		#endregion

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current AcknowledgementType object into an XML document
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
		/// Deserializes workflow markup into an AcknowledgementType object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output AcknowledgementType object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out AcknowledgementType obj, out System.Exception exception)
		{
			exception = null;
			obj = default(AcknowledgementType);
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

		public static bool Deserialize(string xml, out AcknowledgementType obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static AcknowledgementType Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((AcknowledgementType) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
		/// Serializes current AcknowledgementType object into file
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
		/// Deserializes xml markup from file into an AcknowledgementType object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output AcknowledgementType object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out AcknowledgementType obj, out System.Exception exception)
		{
			exception = null;
			obj = default(AcknowledgementType);
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

		public static bool LoadFromFile(string fileName, out AcknowledgementType obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out AcknowledgementType obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static AcknowledgementType LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static AcknowledgementType LoadFromFile(string fileName, System.Text.Encoding encoding)
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
}
