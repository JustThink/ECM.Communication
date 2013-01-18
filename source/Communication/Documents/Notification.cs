using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using ECM.Communication.Areas;
using ECM.Communication.Elements;
using ECM.Communication.Enums;

namespace ECM.Communication.Documents
{
	/// <summary>
	/// Уведомление
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[Serializable()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Notification
	{
		#region Const & Static

		public const string AreaName = "Notification";
		private static System.Xml.Serialization.XmlSerializer serializer;

		#endregion

		#region Properties

		private Header headerField;

		private AcknowledgementType acknowledgementField;

		private ExpansionType expansionField;

		private List<DocTransfer> docTransferField;

		#endregion

		#region Constructor

		#endregion

		#region Fields

		/// <summary>
		/// Заголовок
		/// </summary>
		[System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
		public Header Header
		{
			get
			{
				return this.headerField;
			}
			set
			{
				this.headerField = value;
			}
		}

		/// <summary>
		/// Уведомление (подтверждение приема)
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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

		/// <summary>
		/// Расширение
		/// </summary>
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

		/// <summary>
		/// Для передачи файла в сообщении
		/// </summary>
		[System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
		[System.Xml.Serialization.XmlArrayItemAttribute("DocTransfer", IsNullable = false)]
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

		private static System.Xml.Serialization.XmlSerializer Serializer
		{
			get
			{
				if ( (serializer == null) )
				{
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(Notification));
				}
				return serializer;
			}
		}

		#endregion

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

	internal static partial class Expansion
	{
		public static List<AckResult> Check(this Notification source)
		{
			var ackResult = new List<AckResult>();
			if ( source.Header == null )
			{
				var ex = ErrorReceiptCode.MissingAreas_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "Header") });
			}
			else
			{
				ackResult.AddRange(source.Header.Check(HeaderMessageEnumType.notification));
			}
			if ( source.Acknowledgement == null )
			{
				var ex = ErrorReceiptCode.MissingAreas_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "Acknowledgement") });
			}
			else
			{
				ackResult.AddRange(source.Acknowledgement.Check());
			}
			if ( source.Expansion != null )
			{
				ackResult.AddRange(source.Expansion.Check());
			}
			if ( source.DocTransfer != null )
			{
				foreach ( var docTransfer in source.DocTransfer )
				{
					ackResult.AddRange(docTransfer.Check(ResponseSupplement.AreaName));
				}
			}
			return ackResult;
		}
	}
}
