using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using ECM.Communication.Elements;

namespace ECM.Communication.Documents
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[Serializable()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Header
	{

		private DocumentType documentField;

		private List<TaskListTypeTask> taskListField;

		private List<AddDocumentsTypeFolder> addDocumentsField;

		private ExpansionType expansionField;

		private AcknowledgementType acknowledgementField;

		private string standartField;

		private string versionField;

		private System.DateTime timeField;

		private sbyte msg_typeField;

		private string msg_idField;

		private sbyte msg_acknowField;

		private string from_org_idField;

		private string from_organizationField;

		private string from_departmentField;

		private string from_sys_idField;

		private string from_systemField;

		private string from_system_detailsField;

		private string to_org_idField;

		private string to_organizationField;

		private string to_departmentField;

		private string to_sys_idField;

		private string to_systemField;

		private string to_system_detailsField;

		private static System.Xml.Serialization.XmlSerializer serializer;

		public Header()
		{
			this.acknowledgementField = new AcknowledgementType();
			this.expansionField = new ExpansionType();
			this.addDocumentsField = new List<AddDocumentsTypeFolder>();
			this.taskListField = new List<TaskListTypeTask>();
			this.documentField = new DocumentType();
			this.msg_acknowField = ((sbyte) (0));
		}

		[System.Xml.Serialization.XmlElementAttribute(Order = 0)]
		public DocumentType Document
		{
			get
			{
				return this.documentField;
			}
			set
			{
				this.documentField = value;
			}
		}

		[System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
		[System.Xml.Serialization.XmlArrayItemAttribute("Task", IsNullable = false)]
		public List<TaskListTypeTask> TaskList
		{
			get
			{
				return this.taskListField;
			}
			set
			{
				this.taskListField = value;
			}
		}

		[System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
		[System.Xml.Serialization.XmlArrayItemAttribute("Folder", IsNullable = false)]
		public List<AddDocumentsTypeFolder> AddDocuments
		{
			get
			{
				return this.addDocumentsField;
			}
			set
			{
				this.addDocumentsField = value;
			}
		}

		[System.Xml.Serialization.XmlElementAttribute(Order = 3)]
		public ExpansionType Expansion
		{
			get
			{
				return this.expansionField;
			}
			set
			{
				this.expansionField = value;
			}
		}

		[System.Xml.Serialization.XmlElementAttribute(Order = 4)]
		public AcknowledgementType Acknowledgement
		{
			get
			{
				return this.acknowledgementField;
			}
			set
			{
				this.acknowledgementField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string standart
		{
			get
			{
				return this.standartField;
			}
			set
			{
				this.standartField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public System.DateTime time
		{
			get
			{
				return this.timeField;
			}
			set
			{
				this.timeField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public sbyte msg_type
		{
			get
			{
				return this.msg_typeField;
			}
			set
			{
				this.msg_typeField = value;
			}
		}

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

		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(typeof(sbyte), "0")]
		public sbyte msg_acknow
		{
			get
			{
				return this.msg_acknowField;
			}
			set
			{
				this.msg_acknowField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string from_org_id
		{
			get
			{
				return this.from_org_idField;
			}
			set
			{
				this.from_org_idField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string from_organization
		{
			get
			{
				return this.from_organizationField;
			}
			set
			{
				this.from_organizationField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string from_department
		{
			get
			{
				return this.from_departmentField;
			}
			set
			{
				this.from_departmentField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string from_sys_id
		{
			get
			{
				return this.from_sys_idField;
			}
			set
			{
				this.from_sys_idField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string from_system
		{
			get
			{
				return this.from_systemField;
			}
			set
			{
				this.from_systemField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string from_system_details
		{
			get
			{
				return this.from_system_detailsField;
			}
			set
			{
				this.from_system_detailsField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string to_org_id
		{
			get
			{
				return this.to_org_idField;
			}
			set
			{
				this.to_org_idField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string to_organization
		{
			get
			{
				return this.to_organizationField;
			}
			set
			{
				this.to_organizationField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string to_department
		{
			get
			{
				return this.to_departmentField;
			}
			set
			{
				this.to_departmentField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string to_sys_id
		{
			get
			{
				return this.to_sys_idField;
			}
			set
			{
				this.to_sys_idField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string to_system
		{
			get
			{
				return this.to_systemField;
			}
			set
			{
				this.to_systemField = value;
			}
		}

		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string to_system_details
		{
			get
			{
				return this.to_system_detailsField;
			}
			set
			{
				this.to_system_detailsField = value;
			}
		}

		private static System.Xml.Serialization.XmlSerializer Serializer
		{
			get
			{
				if ( (serializer == null) )
				{
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(Header));
				}
				return serializer;
			}
		}

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current Header object into an XML document
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
		/// Deserializes workflow markup into an Header object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output Header object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out Header obj, out System.Exception exception)
		{
			exception = null;
			obj = default(Header);
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

		public static bool Deserialize(string xml, out Header obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static Header Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((Header) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
		/// Serializes current Header object into file
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
		/// Deserializes xml markup from file into an Header object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output Header object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out Header obj, out System.Exception exception)
		{
			exception = null;
			obj = default(Header);
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

		public static bool LoadFromFile(string fileName, out Header obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out Header obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static Header LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static Header LoadFromFile(string fileName, System.Text.Encoding encoding)
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
