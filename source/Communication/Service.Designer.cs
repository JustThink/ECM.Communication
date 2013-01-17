using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECM.Communication.Documents;
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
			var notification = new Notification();

			OnBeforeBuildNotification(request, notification);

			OnBeforeValidationRequest(request);

			var msg_acknow = HeaderAsknowEnumTypeDefault;
			try
			{
				msg_acknow = (HeaderAsknowEnumType) Enum.ToObject(typeof(HeaderAsknowEnumType), request.Header.msg_acknow);
			}
			catch (Exception e)
			{
				throw;
			}
			
			
			


			// TODO: Проверка заполнения полей объекта
			OnAfterValidationRequest(request);
			
			OnAfterBuildNotification(request, notification);


			return notification;
		}

		partial void OnBeforeBuildNotification(Main request, Notification notification);

		partial void OnBeforeValidationRequest(Main request);
		partial void OnAfterValidationRequest(Main request);
		
		partial void OnAfterBuildNotification(Main request, Notification notification);

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
