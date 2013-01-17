using System;
using System.IO;
using System.Text;
using System.Xml;
using ECM.Communication.Enums;

namespace ECM.Communication.Elements
{
	/// <summary>
	/// Исполнитель задания по документу.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[Serializable()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Executor
	{
		#region Const & Static

		private static System.Xml.Serialization.XmlSerializer serializer;

		#endregion

		#region Properties

		private Organization organizationField;

		private ExecutorEnumType responsibleField;

		private bool responsibleFieldSpecified;

		private string task_specifiedField;

		private System.DateTime deadlineField;

		private bool deadlineFieldSpecified;

		#endregion

		#region Constructor

		public Executor()
		{
			this.organizationField = new Organization();
		}

		#endregion

		#region Fields

		[System.Xml.Serialization.XmlElementAttribute(Order = 0)]
		public Organization Organization
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
		/// Метка ответственного исполнителя
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public sbyte responsible
		{
			get
			{
				return ((sbyte)(this.responsibleField));
			}
			set
			{
				this.responsibleField = (ExecutorEnumType) Enum.ToObject(typeof(ExecutorEnumType), value);
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool responsibleSpecified
		{
			get
			{
				return this.responsibleFieldSpecified;
			}
			set
			{
				this.responsibleFieldSpecified = value;
			}
		}

		/// <summary>
		/// Уточнение задания для данного исполнителя
		/// </summary>
		/// <remarks>
		/// Например, номера пунктов задания, соответствующие поручения данному исполнителю из общего текста задания, «Для сведения» и т.п.
		/// </remarks>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string task_specified
		{
			get
			{
				return this.task_specifiedField;
			}
			set
			{
				this.task_specifiedField = value;
			}
		}

		/// <summary>
		/// Срок исполнения
		/// </summary>
		/// <remarks>
		/// Срок исполнения задания для данного исполнителя
		/// </remarks>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
		public System.DateTime deadline
		{
			get
			{
				return this.deadlineField;
			}
			set
			{
				this.deadlineField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool deadlineSpecified
		{
			get
			{
				return this.deadlineFieldSpecified;
			}
			set
			{
				this.deadlineFieldSpecified = value;
			}
		}

		private static System.Xml.Serialization.XmlSerializer Serializer
		{
			get
			{
				if ( (serializer == null) )
				{
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(Executor));
				}
				return serializer;
			}
		}

		#endregion

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current Executor object into an XML document
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
		/// Deserializes workflow markup into an Executor object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output Executor object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out Executor obj, out System.Exception exception)
		{
			exception = null;
			obj = default(Executor);
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

		public static bool Deserialize(string xml, out Executor obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static Executor Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((Executor) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
		/// Serializes current Executor object into file
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
		/// Deserializes xml markup from file into an Executor object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output Executor object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out Executor obj, out System.Exception exception)
		{
			exception = null;
			obj = default(Executor);
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

		public static bool LoadFromFile(string fileName, out Executor obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out Executor obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static Executor LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static Executor LoadFromFile(string fileName, System.Text.Encoding encoding)
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
