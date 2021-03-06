﻿using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using ECM.Communication.Elements;

namespace ECM.Communication.Areas
{
	/// <summary>
	/// Расширение
	/// </summary>
	/// <remarks>
	/// Содержит дополнительные, не стандартизованные в рамках настоящего стандарта, данные из передающей системы.
	/// Назначение зоны – определение стандартного пути расширения стандарта.
	/// Состав зоны документируется разработчиком соответствующей системы управления документами.
	/// </remarks>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class ExpansionType
	{
		#region Const & Static

		public const string AreaName = "Расширение";
		public const string ElementName = "ExpansionType";

		private static System.Xml.Serialization.XmlSerializer serializer;

		#endregion

		#region Properties

		private List<Econtact> econtactField;

		private ExpansionTypeAnyData anyDataField;

		private string organizationField;

		private string exp_verField;

		#endregion

		#region Constructor

		#endregion

		#region Fields

		/// <summary>
		/// Список номеров (адресов) имеющихся средств электросвязи
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("Econtact", Order = 0)]
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

		[System.Xml.Serialization.XmlElementAttribute(Order = 1)]
		public ExpansionTypeAnyData AnyData
		{
			get
			{
				return this.anyDataField;
			}
			set
			{
				this.anyDataField = value;
			}
		}

		/// <summary>
		/// Организация-разработчик
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string organization
		{
			get
			{
				return this.organizationField;
			}
			set
			{
				this.organizationField = value;
			}
		}

		/// <summary>
		/// Версия зоны «Расширение»
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string exp_ver
		{
			get
			{
				return this.exp_verField;
			}
			set
			{
				this.exp_verField = value;
			}
		}

		private static System.Xml.Serialization.XmlSerializer Serializer
		{
			get
			{
				if ( (serializer == null) )
				{
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(ExpansionType));
				}
				return serializer;
			}
		}

		#endregion

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current ExpansionType object into an XML document
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
		/// Deserializes workflow markup into an ExpansionType object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output ExpansionType object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out ExpansionType obj, out System.Exception exception)
		{
			exception = null;
			obj = default(ExpansionType);
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

		public static bool Deserialize(string xml, out ExpansionType obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static ExpansionType Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((ExpansionType) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
		/// Serializes current ExpansionType object into file
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
		/// Deserializes xml markup from file into an ExpansionType object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output ExpansionType object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out ExpansionType obj, out System.Exception exception)
		{
			exception = null;
			obj = default(ExpansionType);
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

		public static bool LoadFromFile(string fileName, out ExpansionType obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out ExpansionType obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static ExpansionType LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static ExpansionType LoadFromFile(string fileName, System.Text.Encoding encoding)
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
		public static List<AckResult> Check(this ExpansionType source)
		{
			const string areaName = ExpansionType.AreaName;

			var ackResult = new List<AckResult>();

			if ( source == null )
			{
				var ex = ErrorReceiptCode.MissingAreas_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, areaName) });
				return ackResult;
			}

			if ( source.Econtact != null)
			{
				foreach ( var econtact in source.Econtact )
				{
					ackResult.AddRange(econtact.Check(areaName));
				}
			}
			if ( source.AnyData != null )
			{
				ackResult.AddRange(source.AnyData.Check(areaName));
			}
			if ( string.IsNullOrEmpty(source.organization) )
			{
				var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "organization", ExpansionType.ElementName, areaName) });
			}
			if ( string.IsNullOrEmpty(source.exp_ver) )
			{
				var ex = ErrorReceiptCode.MissingRequiredAttribute_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "exp_ver", ExpansionType.ElementName, areaName) });
			}
			return ackResult;
		}
	}
}
