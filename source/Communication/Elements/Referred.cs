using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using ECM.Communication.Enums;

namespace ECM.Communication.Elements
{
	/// <summary>
	/// Регистрационный номер и дата документа или задания
	/// </summary>
	/// <remarks>
	/// Регистрационный номер и дата документа или задания, на который дается ссылка, определяются, соответственно, вложенным элементом RegNumber или TaskNumber.
	/// Если документ (задание) был передан ранее, то допускается передача его идентификатора посредством атрибутов retype и idnumber и вложенные элементы RegNumber или TaskNumber могут не использоваться.
	/// </remarks>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Referred
	{
		#region Const & Static

		private static System.Xml.Serialization.XmlSerializer serializer;

		#endregion

		#region Properties

		private object itemField;

		private string idnumberField;

		private ReferredEnumType retypeField;

		private bool retypeFieldSpecified;

		#endregion

		#region Constructor

		#endregion

		#region Fields

		[System.Xml.Serialization.XmlElementAttribute("RegNumber", typeof(RegNumber), Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute("TaskNumber", typeof(TaskNumber), Order = 0)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		/// <summary>
		/// Уникальный служебный идентификационный номер
		/// </summary>
		/// <remarks>
		/// Идентификационный номер документа или задания, на который дается ссылка, в зависимости от значения атрибута retype.
		/// </remarks>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string idnumber
		{
			get
			{
				return this.idnumberField;
			}
			set
			{
				this.idnumberField = value;
			}
		}

		/// <summary>
		/// Определяет вид ссылки
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public sbyte retype
		{
			get
			{
				return ((sbyte)(this.retypeField));
			}
			set
			{
				this.retypeField = (ReferredEnumType) Enum.ToObject(typeof(ReferredEnumType), value);
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool retypeSpecified
		{
			get
			{
				return this.retypeFieldSpecified;
			}
			set
			{
				this.retypeFieldSpecified = value;
			}
		}

		private static System.Xml.Serialization.XmlSerializer Serializer
		{
			get
			{
				if ( (serializer == null) )
				{
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(Referred));
				}
				return serializer;
			}
		}

		#endregion

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current Referred object into an XML document
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
		/// Deserializes workflow markup into an Referred object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output Referred object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out Referred obj, out System.Exception exception)
		{
			exception = null;
			obj = default(Referred);
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

		public static bool Deserialize(string xml, out Referred obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static Referred Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((Referred) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
		/// Serializes current Referred object into file
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
		/// Deserializes xml markup from file into an Referred object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output Referred object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out Referred obj, out System.Exception exception)
		{
			exception = null;
			obj = default(Referred);
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

		public static bool LoadFromFile(string fileName, out Referred obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out Referred obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static Referred LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static Referred LoadFromFile(string fileName, System.Text.Encoding encoding)
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
		public static List<AckResult> Check(this Referred source, string areaName)
		{
			var ackResult = new List<AckResult>();
			if ( source.Item != null )
			{
				if (source.Item is RegNumber)
				{
					ackResult.AddRange(((RegNumber) source.Item).Check(areaName));
				}
				else if (source.Item is TaskNumber)
				{
					ackResult.AddRange(((TaskNumber) source.Item).Check(areaName));
				}
			}
			return ackResult;
		}
	}
}
