﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using ECM.Communication.Enums;

namespace ECM.Communication.Elements
{
	/// <summary>
	/// Дополнительные материалы
	/// </summary>
	/// <remarks>
	/// Содержит информацию о дополнительных (справочных) материалах к документу, которые разъясняют отдельные, затронутые в документевопросы (в виде дополнительных документов, писем, справок и пр.).
	/// </remarks>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
	[Serializable()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class AddDocumentsTypeFolder
	{
		#region Const & Static

		private static System.Xml.Serialization.XmlSerializer serializer;

		#endregion

		#region Properties

		private List<DocTransfer> docTransferField;

		private List<Note> noteField;

		private List<Referred> referredField;

		private FolderAddEnumType add_typeField;

		#endregion

		#region Constructor

		public AddDocumentsTypeFolder()
		{
			this.referredField = new List<Referred>();
			this.noteField = new List<Note>();
			this.docTransferField = new List<DocTransfer>();
		}

		#endregion

		#region Fields

		[System.Xml.Serialization.XmlElementAttribute("DocTransfer", Order = 0)]
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

		[System.Xml.Serialization.XmlElementAttribute("Note", Order = 1)]
		public List<Note> Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
			}
		}

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
		/// Вид прилагаемых материалов
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public sbyte add_type
		{
			get
			{
				return ((sbyte)(this.add_typeField));
			}
			set
			{
				this.add_typeField = (FolderAddEnumType) Enum.ToObject(typeof(FolderAddEnumType), value);
			}
		}

		private static System.Xml.Serialization.XmlSerializer Serializer
		{
			get
			{
				if ( (serializer == null) )
				{
					serializer = new System.Xml.Serialization.XmlSerializer(typeof(AddDocumentsTypeFolder));
				}
				return serializer;
			}
		}

		#endregion

		#region Serialize/Deserialize
		/// <summary>
		/// Serializes current AddDocumentsTypeFolder object into an XML document
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
		/// Deserializes workflow markup into an AddDocumentsTypeFolder object
		/// </summary>
		/// <param name="xml">string workflow markup to deserialize</param>
		/// <param name="obj">Output AddDocumentsTypeFolder object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool Deserialize(string xml, out AddDocumentsTypeFolder obj, out System.Exception exception)
		{
			exception = null;
			obj = default(AddDocumentsTypeFolder);
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

		public static bool Deserialize(string xml, out AddDocumentsTypeFolder obj)
		{
			System.Exception exception = null;
			return Deserialize(xml, out obj, out exception);
		}

		public static AddDocumentsTypeFolder Deserialize(string xml)
		{
			System.IO.StringReader stringReader = null;
			try
			{
				stringReader = new System.IO.StringReader(xml);
				return ((AddDocumentsTypeFolder) (Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
		/// Serializes current AddDocumentsTypeFolder object into file
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
		/// Deserializes xml markup from file into an AddDocumentsTypeFolder object
		/// </summary>
		/// <param name="fileName">string xml file to load and deserialize</param>
		/// <param name="obj">Output AddDocumentsTypeFolder object</param>
		/// <param name="exception">output Exception value if deserialize failed</param>
		/// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
		public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out AddDocumentsTypeFolder obj, out System.Exception exception)
		{
			exception = null;
			obj = default(AddDocumentsTypeFolder);
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

		public static bool LoadFromFile(string fileName, out AddDocumentsTypeFolder obj, out System.Exception exception)
		{
			return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
		}

		public static bool LoadFromFile(string fileName, out AddDocumentsTypeFolder obj)
		{
			System.Exception exception = null;
			return LoadFromFile(fileName, out obj, out exception);
		}

		public static AddDocumentsTypeFolder LoadFromFile(string fileName)
		{
			return LoadFromFile(fileName, Encoding.UTF8);
		}

		public static AddDocumentsTypeFolder LoadFromFile(string fileName, System.Text.Encoding encoding)
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
		public static List<AckResult> Check(this AddDocumentsTypeFolder source, string areaName)
		{
			var ackResult = new List<AckResult>();
			if ( source.DocTransfer != null )
			{
				foreach ( var docTransfer in source.DocTransfer )
				{
					ackResult.AddRange(docTransfer.Check(areaName));
				}
			}
			if ( source.Note != null )
			{
				foreach ( var note in source.Note )
				{
					ackResult.AddRange(note.Check(areaName));
				}
			}
			if ( source.Referred != null )
			{
				foreach ( var referred in source.Referred )
				{
					ackResult.AddRange(referred.Check(areaName));
				}
			}
			return ackResult;
		}
	}
}
