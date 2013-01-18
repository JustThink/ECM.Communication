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
			var ackResult = request.Check();
			var notification = CreateNotification(request, ackResult);
			return ReturnNotification(request.Header, notification);
		}

		partial void OnBeforeValidationRequest(Main request);

		#endregion

		#region ChangeRequest

		public Notification ChangeRequest(MainSupplement request)
		{
			OnBeforeValidationRequest(request);
			var ackResult = request.Check();
			var notification = CreateNotification(request, ackResult);
			return ReturnNotification(request.Header, notification);
		}

		partial void OnBeforeValidationRequest(MainSupplement request);

		#endregion

		#region GetResponse

		public Notification GetResponse(Response response)
		{
			OnBeforeValidationRequest(response);
			var ackResult = response.Check();
			var notification = CreateNotification(response, ackResult);
			return ReturnNotification(response.Header, notification);
		}

		partial void OnBeforeValidationRequest(Response response);

		#endregion

		#region ChangeResponse

		public Notification ChangeResponse(ResponseSupplement response)
		{
			OnBeforeValidationRequest(response);
			var ackResult = response.Check();
			var notification = CreateNotification(response, ackResult);
			return ReturnNotification(response.Header, notification);
		}

		partial void OnBeforeValidationRequest(ResponseSupplement response);

		#endregion

		private Notification ReturnNotification(Header header, Notification notification)
		{
			var msg_acknow = GetMsgAcknow(header);

			switch ( msg_acknow )
			{
				case HeaderAsknowEnumType.none:
					return null;
				case HeaderAsknowEnumType.always:
					return notification;
				case HeaderAsknowEnumType.only_when_errors:
					if ( (notification.Acknowledgement.AckResult == null) || (notification.Acknowledgement.AckResult.Count < 1) )
						return null;
					else
					{
						return notification;
					}
			}
			throw new ArgumentOutOfRangeException("msg_acknow", msg_acknow, "Unknown value");
		}

		private HeaderAsknowEnumType GetMsgAcknow(Header header)
		{
			if ( header == null )
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
