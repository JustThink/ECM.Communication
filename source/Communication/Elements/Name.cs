﻿using System.IO;
using System.Text;
using System.Xml;

namespace ECM.Communication.Elements
{
	/// <summary>
	/// Фамилия, имя, отчество (ФИО).
	/// <remarks>
	/// Единая строка, содержащая все элементы ФИО. 
	/// Заполняется в системах управления документами, не хранящих ФИО фрагментарно или для отдельных сложносоставных имен некоторых народов РФ.
	/// </remarks>
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Name
	{

		private string secnameField;

		private string firstnameField;

		private string fathersnameField;

		private string valueField;

		private static System.Xml.Serialization.XmlSerializer serializer;

		/// <summary>
		/// Фамилия
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string secname
		{
			get
			{
				return this.secnameField;
			}
			set
			{
				this.secnameField = value;
			}
		}

		/// <summary>
		/// Имя
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string firstname
		{
			get
			{
				return this.firstnameField;
			}
			set
			{
				this.firstnameField = value;
			}
		}

		/// <summary>
		/// Отчество
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string fathersname
		{
			get
			{
				return this.fathersnameField;
			}
			set
			{
				this.fathersnameField = value;
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
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(Name));
				}
				return serializer;
			}
		}

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current Name object into an XML document
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
		/// Deserializes workflow markup into an Name object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output Name object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out Name obj, out System.Exception exception)
		{
			exception = null;
			obj = default(Name);
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

		public static bool Deserialize(string xml, out Name obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static Name Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((Name) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
		/// Serializes current Name object into file
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
		/// Deserializes xml markup from file into an Name object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output Name object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out Name obj, out System.Exception exception)
		{
			exception = null;
			obj = default(Name);
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

		public static bool LoadFromFile(string fileName, out Name obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out Name obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static Name LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static Name LoadFromFile(string fileName, System.Text.Encoding encoding)
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
