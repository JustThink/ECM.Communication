using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace ECM.Communication.Elements
{
	/// <summary>
	/// Описание должностного лица.
	/// </summary>
	/// <remarks>
	/// Для элемента OfficialPersonWithSign кроме описания должностного лица (элементы Name, Official, Rank, Address, Econtact) в качестве вложенного элемента допускается указание даты подписания документа данным должностным лицом (элемент SignDate). В остальном данные элементы идентичны.
	/// </remarks>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class OfficialPerson
	{
		#region Const & Static

		public const string ElementName = "OfficialPerson";
		private static System.Xml.Serialization.XmlSerializer serializer;

		#endregion

		#region Properties

		private Name nameField;

		private List<Official> officialField;

		private List<Rank> rankField;

		private Address addressField;

		private List<Econtact> econtactField;

		#endregion

		#region Constructor

		#endregion

		#region Fields

		/// <summary>
		/// Фамилия, имя, отчество (ФИО).
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute(Order = 0)]
		public Name Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <summary>
		/// Список описаний штатных единиц (подразделений, должностей), занимаемых должностными лицами.
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("Official", Order = 1)]
		public List<Official> Official
		{
			get
			{
				return this.officialField;
			}
			set
			{
				this.officialField = value;
			}
		}

		/// <summary>
		/// Список ученых степеней, воинских званий, духовных имен и т.п.
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("Rank", Order = 2)]
		public List<Rank> Rank
		{
			get
			{
				return this.rankField;
			}
			set
			{
				this.rankField = value;
			}
		}

		/// <summary>
		/// Описание почтового адреса.
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute(Order = 3)]
		public Address Address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}

		/// <summary>
		/// Список номеров (адресов) имеющихся средств электросвязи
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("Econtact", Order = 4)]
		public List<Econtact> Econtact
		{
			get
			{
				return this.econtactField;
			}
			set
			{
				this.econtactField = value;
			}
		}

		private static System.Xml.Serialization.XmlSerializer Serializer
		{
			get
			{
				if ( (serializer == null) )
				{
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(OfficialPerson));
				}
				return serializer;
			}
		}

		#endregion

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current OfficialPerson object into an XML document
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
		/// Deserializes workflow markup into an OfficialPerson object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output OfficialPerson object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out OfficialPerson obj, out System.Exception exception)
		{
			exception = null;
			obj = default(OfficialPerson);
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

		public static bool Deserialize(string xml, out OfficialPerson obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static OfficialPerson Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((OfficialPerson) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
		/// Serializes current OfficialPerson object into file
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
		/// Deserializes xml markup from file into an OfficialPerson object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output OfficialPerson object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out OfficialPerson obj, out System.Exception exception)
		{
			exception = null;
			obj = default(OfficialPerson);
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

		public static bool LoadFromFile(string fileName, out OfficialPerson obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out OfficialPerson obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static OfficialPerson LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static OfficialPerson LoadFromFile(string fileName, System.Text.Encoding encoding)
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
		public static List<AckResult> Check(this OfficialPerson source, string areaName)
		{
			var ackResult = new List<AckResult>();
			if ( source.Name == null )
			{
				var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "Name", OfficialPerson.ElementName, areaName) });
			}
			else
			{
				ackResult.AddRange(source.Name.Check(areaName));
			}
			if ( source.Official != null )
			{
				foreach ( var official in source.Official )
				{
					ackResult.AddRange(official.Check(areaName));
				}
			}
			if ( source.Rank != null )
			{
				foreach ( var rank in source.Rank )
				{
					ackResult.AddRange(rank.Check(areaName));
				}
			}
			if ( source.Address != null )
			{
				source.Address.Check(areaName);
			}
			if ( source.Econtact != null )
			{
				foreach ( var econtact in source.Econtact )
				{
					ackResult.AddRange(econtact.Check(areaName));
				}
			}
			return ackResult;
		}
	}
}
