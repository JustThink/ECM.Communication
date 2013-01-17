using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECM.Communication.Areas;
using ECM.Communication.Documents;
using ECM.Communication.Elements;
using ECM.Communication.Enums;

namespace ECM.Communication
{
	partial class Service : IService
	{
		private static readonly IService m_instance = new Service();
		public static IService Instance { get { return m_instance; } }
		static Service() { }
		private Service() { }

		/// <summary>
		/// Изменить необходимость посылки уведомления
		/// </summary>
		public HeaderAsknowEnumType HeaderAsknowEnumType
		{
			get { return HeaderAsknowEnumTypeDefault; }
			set { HeaderAsknowEnumTypeDefault = value; }
		}

		#region AddRequest

		public Notification AddRequest(Main request)
		{
			OnBeforeValidationRequest(request);

			var ackResult = new List<AckResult>();
			ackResult.AddRange(request.Header.Check(HeaderMessageEnumType.main));
			
			

			if ( request.Document != null)
			{
				//this.documentField = new DocumentType();
			}
			else
			{
				var ex = ErrorReceiptCode.MissingAreas_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, DocumentType.AreaName) });
			}

			if ( request.TaskList != null )
			{
				//this.taskListField = new List<TaskListTypeTask>();
			}

			if ( request.AddDocuments != null )
			{
				//this.addDocumentsField = new List<AddDocumentsTypeFolder>();
			}

			if ( request.Expansion != null )
			{
				//this.expansionField = new ExpansionType();
			}

			if ( request.DocTransfer != null)
			{
				//this.docTransferField = new List<DocTransfer>();
			}

			var notification = new Notification();


			OnAfterValidationRequest(request, notification);

			var msg_acknow = GetMsgAcknow(request.Header);

			return notification;
		}

		partial void OnBeforeValidationRequest(Main request);
		partial void OnAfterValidationRequest(Main request, Notification notification);

		#endregion

		public Notification ChangeRequest(MainSupplement request)
		{
			throw new NotImplementedException();
		}

		public Notification GetResponse(Response response)
		{
			throw new NotImplementedException();
		}

		public Notification ChangeResponse(Response response)
		{
			throw new NotImplementedException();
		}

		private HeaderAsknowEnumType GetMsgAcknow(Header header)
		{
			if ( header == null)
				return HeaderAsknowEnumTypeDefault;

			try
			{
				return (HeaderAsknowEnumType) Enum.ToObject(typeof(HeaderAsknowEnumType), header.msg_acknow);
			}
			catch
			{
				// TODO: В стандарте отсутствует код ошибки 
				return HeaderAsknowEnumTypeDefault;
			}
		}
	}
}
