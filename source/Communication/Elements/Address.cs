using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECM.Communication.Elements
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Address
	{

		private string streetField;

		private string houseField;

		private string buildingField;

		private string flatField;

		private string settlementField;

		private string districtField;

		private string regionField;

		private string countryField;

		private string postсodeField;

		private string postboxField;

		private string nontypicalField;

		private string valueField;

		private static System.Xml.Serialization.XmlSerializer serializer;

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string street
		{
			get
			{
				return this.streetField;
			}
			set
			{
				this.streetField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string house
		{
			get
			{
				return this.houseField;
			}
			set
			{
				this.houseField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string building
		{
			get
			{
				return this.buildingField;
			}
			set
			{
				this.buildingField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string flat
		{
			get
			{
				return this.flatField;
			}
			set
			{
				this.flatField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string settlement
		{
			get
			{
				return this.settlementField;
			}
			set
			{
				this.settlementField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string district
		{
			get
			{
				return this.districtField;
			}
			set
			{
				this.districtField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string region
		{
			get
			{
				return this.regionField;
			}
			set
			{
				this.regionField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string country
		{
			get
			{
				return this.countryField;
			}
			set
			{
				this.countryField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string postсode
		{
			get
			{
				return this.postсodeField;
			}
			set
			{
				this.postсodeField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string postbox
		{
			get
			{
				return this.postboxField;
			}
			set
			{
				this.postboxField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string nontypical
		{
			get
			{
				return this.nontypicalField;
			}
			set
			{
				this.nontypicalField = value;
			}
		}

		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
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
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(Address));
				}
				return serializer;
			}
		}

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current Address object into an XML document
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
		/// Deserializes workflow markup into an Address object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output Address object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out Address obj, out System.Exception exception)
		{
			exception = null;
			obj = default(Address);
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

		public static bool Deserialize(string xml, out Address obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static Address Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((Address) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
		/// Serializes current Address object into file
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
		/// Deserializes xml markup from file into an Address object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output Address object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out Address obj, out System.Exception exception)
		{
			exception = null;
			obj = default(Address);
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

		public static bool LoadFromFile(string fileName, out Address obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out Address obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static Address LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static Address LoadFromFile(string fileName, System.Text.Encoding encoding)
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
