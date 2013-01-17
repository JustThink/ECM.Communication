using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace ECM.Communication.Elements
{
	/// <summary>
	/// Описание организации
	/// </summary>
	/// <remarks>
	/// Данные элементы различаются только допустимым составом вложенных элементов, в остальном они идентичны: 
	/// Элемент OrganizationOnly допускает только вложенные элементы Address и Econtact 
	/// Элемент Organization допускает вложенные элементы Address и Econtact и описание должностного лица этой организации – элемент OfficialPerson 
	/// Элемент OrganizationWithSign допускает вложенные элементы Address и Econtact и описание должностного лица этой организации с 
	/// указанием даты подписания документа этим должностным лицом – элемент OfficialPersonWithSign.
	/// </remarks>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class OrganizationWithSign
	{
		#region Const & Static

		public const string ElementName = "OrganizationWithSign";
		private static System.Xml.Serialization.XmlSerializer serializer;

		#endregion

		#region Properties

		private Address addressField;

		private List<Econtact> econtactField;

		private List<OfficialPersonWithSign> officialPersonWithSignField;

		private string organization_stringField;

		private string fullnameField;

		private string shortnameField;

		private string ownershipField;

		private ulong ogrnField;

		private bool ogrnFieldSpecified;

		private ulong innField;

		private bool innFieldSpecified;

		private ulong kppField;

		private bool kppFieldSpecified;

		#endregion

		#region Constructor

		#endregion

		#region Fields

		/// <summary>
		/// Описание почтового адреса.
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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
		[System.Xml.Serialization.XmlElementAttribute("Econtact", Order = 1)]
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

		/// <summary>
		/// Список описаний должностных лиц.
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("OfficialPersonWithSign", Order = 2)]
		public List<OfficialPersonWithSign> OfficialPersonWithSign
		{
			get
			{
				return this.officialPersonWithSignField;
			}
			set
			{
				this.officialPersonWithSignField = value;
			}
		}

		/// <summary>
		/// Единая строка, содержащая все атрибуты организации.
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string organization_string
		{
			get
			{
				return this.organization_stringField;
			}
			set
			{
				this.organization_stringField = value;
			}
		}

		/// <summary>
		/// Полное название организации
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string fullname
		{
			get
			{
				return this.fullnameField;
			}
			set
			{
				this.fullnameField = value;
			}
		}

		/// <summary>
		/// Краткое название организации
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string shortname
		{
			get
			{
				return this.shortnameField;
			}
			set
			{
				this.shortnameField = value;
			}
		}

		/// <summary>
		/// Аббревиатура, отражающая организационно-правовую форму (ЗАО, ООО, ГУП)
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ownership
		{
			get
			{
				return this.ownershipField;
			}
			set
			{
				this.ownershipField = value;
			}
		}

		/// <summary>
		/// Основной государственный регистрационный номер
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public ulong ogrn
		{
			get
			{
				return this.ogrnField;
			}
			set
			{
				this.ogrnField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ogrnSpecified
		{
			get
			{
				return this.ogrnFieldSpecified;
			}
			set
			{
				this.ogrnFieldSpecified = value;
			}
		}

		/// <summary>
		/// Идентификационный номер налогоплательщика (ИНН)
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public ulong inn
		{
			get
			{
				return this.innField;
			}
			set
			{
				this.innField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool innSpecified
		{
			get
			{
				return this.innFieldSpecified;
			}
			set
			{
				this.innFieldSpecified = value;
			}
		}

		/// <summary>
		/// Код причины постановки на учет (КПП)
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public ulong kpp
		{
			get
			{
				return this.kppField;
			}
			set
			{
				this.kppField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool kppSpecified
		{
			get
			{
				return this.kppFieldSpecified;
			}
			set
			{
				this.kppFieldSpecified = value;
			}
		}

		private static System.Xml.Serialization.XmlSerializer Serializer
		{
			get
			{
				if ( (serializer == null) )
				{
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrganizationWithSign));
				}
				return serializer;
			}
		}

		#endregion

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current OrganizationWithSign object into an XML document
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
		/// Deserializes workflow markup into an OrganizationWithSign object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output OrganizationWithSign object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out OrganizationWithSign obj, out System.Exception exception)
		{
			exception = null;
			obj = default(OrganizationWithSign);
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

		public static bool Deserialize(string xml, out OrganizationWithSign obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static OrganizationWithSign Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((OrganizationWithSign) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
		/// Serializes current OrganizationWithSign object into file
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
		/// Deserializes xml markup from file into an OrganizationWithSign object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output OrganizationWithSign object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out OrganizationWithSign obj, out System.Exception exception)
		{
			exception = null;
			obj = default(OrganizationWithSign);
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

		public static bool LoadFromFile(string fileName, out OrganizationWithSign obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out OrganizationWithSign obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static OrganizationWithSign LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static OrganizationWithSign LoadFromFile(string fileName, System.Text.Encoding encoding)
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
		public static List<AckResult> Check(this OrganizationWithSign source, string areaName)
		{
			var ackResult = new List<AckResult>();
			if ( string.IsNullOrEmpty(source.organization_string) )
			{
				var ex = ErrorReceiptCode.WrongMultiplicityOfElement_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "organization_string", areaName) });
			}
			if ( source.Address != null )
			{
				ackResult.AddRange(source.Address.Check(areaName));
			}
			if ( source.Econtact != null )
			{
				foreach ( var econtact in source.Econtact )
				{
					ackResult.AddRange(econtact.Check(areaName));
				}
			}
			if ( source.OfficialPersonWithSign == null)
			{
				var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "OfficialPersonWithSign", OrganizationWithSign.ElementName, areaName) });
			}
			else if ( source.OfficialPersonWithSign.Count == 1)
			{
				var data = source.OfficialPersonWithSign[0];
				data.Check(areaName);
			}
			else if ( source.OfficialPersonWithSign.Count > 1 )
			{
				var ex = ErrorReceiptCode.WrongMultiplicityOfElement_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "OfficialPersonWithSign", areaName) });
			}
			return ackResult;
		}
	}
}