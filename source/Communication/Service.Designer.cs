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

			var msg_acknow = HeaderAsknowEnumTypeDefault;
			var ackResult = new List<AckResult>();

			if ( request.Header == null)
			{
				var ex = ErrorReceiptCode.MissingAreas_Format;
				ackResult.Add(new AckResult() { errorcode = ex.errorcode, Value = string.Format(ex.Value, "Header")});
			}

			//this.headerField = new Header();

			//this.standartField = StandartFieldDefault;
			//this.versionField = VersionFieldDefault;
			//this.time = DateTime.UtcNow;
			//this.msg_acknowField = ((sbyte) (HeaderMessageEnumType.notification));


			//this.headerField.msg_type = ((sbyte) HeaderMessageEnumType.main);
			//this.documentField = new DocumentType();
			//this.addDocumentsField = new List<AddDocumentsTypeFolder>();
			//this.taskListField = new List<TaskListTypeTask>();
			//this.expansionField = new ExpansionType();
			//this.docTransferField = new List<DocTransfer>();
			

			
			try
			{
				msg_acknow = (HeaderAsknowEnumType) Enum.ToObject(typeof(HeaderAsknowEnumType), request.Header.msg_acknow);
			}
			catch (Exception e)
			{
				throw;
			}


			
			
			
			


			
			var notification = new Notification();


			OnAfterValidationRequest(request, notification);

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
	}
}
