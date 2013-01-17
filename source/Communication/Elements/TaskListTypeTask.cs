using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using ECM.Communication.Enums;

namespace ECM.Communication.Elements
{
	/// <summary>
	/// Задания
	/// </summary>
	/// <remarks>
	/// Содержит информацию о выданных заданиях на исполнение и обработку документа (в виде резолюций, поручений, сопроводительных писем, напоминаний и т.д.) – как в объеме стандартизованного набора РКД, так и, возможно, в электронном виде (в виде файла, набора файлов).
	/// </remarks>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[Serializable()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TaskListTypeTask
	{
		#region Const & Static

		private static System.Xml.Serialization.XmlSerializer serializer;

		#endregion

		#region Properties

		private TaskNumber taskNumberField;

		private Confident confidentField;

		private List<Referred> referredField;

		private List<AuthorOrganization> authorOrganizationField;

		private List<DocTransfer> docTransferField;

		private List<Executor> executorField;

		private string idnumberField;

		private TaskRegistrationEnumType task_regField;

		private TaskCopyEnumType task_copyField;

		private string kindField;

		private string task_textField;

		private System.DateTime deadlineField;

		#endregion

		#region Constructor

		public TaskListTypeTask()
		{
			this.executorField = new List<Executor>();
			this.docTransferField = new List<DocTransfer>();
			this.authorOrganizationField = new List<AuthorOrganization>();
			this.referredField = new List<Referred>();
			this.confidentField = new Confident();
			this.taskNumberField = new TaskNumber();
		}

		#endregion

		#region Fields

		/// <summary>
		/// Номер задания.
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute(Order = 0)]
		public TaskNumber TaskNumber
		{
			get
			{
				return this.taskNumberField;
			}
			set
			{
				this.taskNumberField = value;
			}
		}

		/// <summary>
		/// Характеристика ограничений доступа к документу (гриф документа).
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute(Order = 1)]
		public Confident Confident
		{
			get
			{
				return this.confidentField;
			}
			set
			{
				this.confidentField = value;
			}
		}

		/// <summary>
		/// Список регистрационных номеров и дата документов или заданий
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("Referred", Order = 2)]
		public List<Referred> Referred
		{
			get
			{
				return this.referredField;
			}
			set
			{
				this.referredField = value;
			}
		}

		/// <summary>
		/// Список описаний авторов документа
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("AuthorOrganization", Order = 3)]
		public List<AuthorOrganization> AuthorOrganization
		{
			get
			{
				return this.authorOrganizationField;
			}
			set
			{
				this.authorOrganizationField = value;
			}
		}

		/// <summary>
		/// Список представлени1 передаваемых файлов документа.
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("DocTransfer", Order = 4)]
		public List<DocTransfer> DocTransfer
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
		/// Список исполнителей задания по документу.
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("Executor", Order = 5)]
		public List<Executor> Executor
		{
			get
			{
				return this.executorField;
			}
			set
			{
				this.executorField = value;
			}
		}

		/// <summary>
		/// Уникальный служебный идентификационный номер задания в передающей системе управления документами
		/// </summary>
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
		/// Отметка о регистрации задания
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public sbyte task_reg
		{
			get
			{
				return ((sbyte)(this.task_regField));
			}
			set
			{
				this.task_regField = (TaskRegistrationEnumType) Enum.ToObject(typeof(TaskRegistrationEnumType), value);
			}
		}

		/// <summary>
		/// Отметка о передаче копии задания
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public sbyte task_copy
		{
			get
			{
				return ((sbyte) (this.task_copyField));
			}
			set
			{
				this.task_copyField = (TaskCopyEnumType) Enum.ToObject(typeof(TaskCopyEnumType), value);
			}
		}

		/// <summary>
		/// Вид задания
		/// </summary>
		/// <remarks>
		/// Название задания: поручение, сопроводительное письмо и т.д.
		/// </remarks>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string kind
		{
			get
			{
				return this.kindField;
			}
			set
			{
				this.kindField = value;
			}
		}

		/// <summary>
		/// Текст задания
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string task_text
		{
			get
			{
				return this.task_textField;
			}
			set
			{
				this.task_textField = value;
			}
		}

		/// <summary>
		/// Срок исполнения
		/// </summary>
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

		private static System.Xml.Serialization.XmlSerializer Serializer
		{
			get
			{
				if ( (serializer == null) )
				{
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(TaskListTypeTask));
				}
				return serializer;
			}
		}

		#endregion

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current TaskListTypeTask object into an XML document
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
		/// Deserializes workflow markup into an TaskListTypeTask object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output TaskListTypeTask object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out TaskListTypeTask obj, out System.Exception exception)
		{
			exception = null;
			obj = default(TaskListTypeTask);
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

		public static bool Deserialize(string xml, out TaskListTypeTask obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static TaskListTypeTask Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((TaskListTypeTask) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
		/// Serializes current TaskListTypeTask object into file
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
		/// Deserializes xml markup from file into an TaskListTypeTask object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output TaskListTypeTask object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out TaskListTypeTask obj, out System.Exception exception)
		{
			exception = null;
			obj = default(TaskListTypeTask);
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

		public static bool LoadFromFile(string fileName, out TaskListTypeTask obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out TaskListTypeTask obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static TaskListTypeTask LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static TaskListTypeTask LoadFromFile(string fileName, System.Text.Encoding encoding)
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
