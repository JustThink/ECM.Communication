using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace ECM.Communication.Elements
{
	/// <summary>
	/// История регистрации документа в разных организациях.
	/// </summary>
	/// <remarks>
	/// Вложенные элементы содержат все присваивавшиеся документу регистрационные номера за исключением последнего, 
	/// занесенного в элемент RegNumber элемента Document.
	/// </remarks>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class RegHistory
	{
		#region Const & Static

		public const string ElementName = "RegHistory";
		private static System.Xml.Serialization.XmlSerializer serializer;

		#endregion

		#region Properties

		private OrganizationOnly organizationOnlyField;

		private RegNumber regNumberField;

		private string idnumberField;

		#endregion 

		#region Constructor

		#endregion

		#region Fields

		/// <summary>
		/// Описание организации.
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute(Order = 0)]
		public OrganizationOnly OrganizationOnly
		{
			get
			{
				return this.organizationOnlyField;
			}
			set
			{
				this.organizationOnlyField = value;
			}
		}

		/// <summary>
		/// Регистрационный номер документа.
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
		/// Уникальный служебный идентификационный номер документа
		/// </summary>
		/// <remarks>
		/// Уникальный идентификатор документа в системе управления документами соответствующей организации (см. вложенные элементы).
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

		private static System.Xml.Serialization.XmlSerializer Serializer
		{
			get
			{
				if ( (serializer == null) )
				{
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(RegHistory));
				}
				return serializer;
			}
		}

		#endregion

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current RegHistory object into an XML document
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
		/// Deserializes workflow markup into an RegHistory object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output RegHistory object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out RegHistory obj, out System.Exception exception)
		{
			exception = null;
			obj = default(RegHistory);
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

		public static bool Deserialize(string xml, out RegHistory obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static RegHistory Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((RegHistory) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
		/// Serializes current RegHistory object into file
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
		/// Deserializes xml markup from file into an RegHistory object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output RegHistory object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out RegHistory obj, out System.Exception exception)
		{
			exception = null;
			obj = default(RegHistory);
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

		public static bool LoadFromFile(string fileName, out RegHistory obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out RegHistory obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static RegHistory LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static RegHistory LoadFromFile(string fileName, System.Text.Encoding encoding)
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
		public static List<AckResult> Check(this RegHistory source, string areaName)
		{
			var ackResult = new List<AckResult>();
			if ( source.OrganizationOnly == null )
			{
				var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "OrganizationOnly", RegHistory.ElementName, areaName) });
			}
			else
			{
				ackResult.AddRange(source.OrganizationOnly.Check(areaName));
			}
			if ( source.RegNumber == null )
			{
				var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "RegNumber", RegHistory.ElementName, areaName) });
			}
			else
			{
				ackResult.AddRange(source.RegNumber.Check(areaName));
			}
			return ackResult;
		}
	}
}