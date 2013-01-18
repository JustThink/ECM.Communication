using System.Collections.Generic;
using ECM.Communication.Areas;
using ECM.Communication.Documents;
using ECM.Communication.Elements;
using ECM.Communication.Enums;

namespace ECM.Communication
{
	/// <summary>
	/// Информационное взаимодействие двух систем управления документами осуществляется посредством последовательного обмена сообщениями заданного вида.
	/// </summary>
	/// <remarks>
	/// Последовательность обмена сообщениями при информационном взаимодействии систем управления документами приведена в таблице 2.
	/// </remarks>
	public interface IService
	{
		/// <summary>
		/// Номер сообщений 1 и 2
		/// </summary>
		/// <param name="request">Документ и относящиеся к нему задания и дополнительные материалы направляются на исполнение (обработку).</param>
		/// <returns>Направляется информация о доставке и приеме сообщения, об ошибках приема и интерпретации сообщения, о регистрации полученного документа и др.</returns>
		Notification AddRequest(Main request);

		/// <summary>
		/// Номер сообщений 3 и 4
		/// </summary>
		/// <param name="request">К ранее направленному документу направляются дополнительные задания (или изменения ранее выданных заданий) и дополнительные материалы</param>
		/// <returns>Направляется информация о доставке и приеме сообщения, содержащего дополнения к основному документу, об ошибках приема и интерпретации сообщения и др.</returns>
		Notification ChangeRequest(MainSupplement request);

		/// <summary>
		/// Номер сообщений 5 и 6
		/// </summary>
		/// <param name="response">В виде самостоятельного документа направляется ответ на переданный документ (или отчет о его исполнении).</param>
		/// <returns>Направляется информация о доставке и приеме сообщения, содержащего документ-ответ, об ошибках приема и интерпретации сообщения, о регистрации полученного документа-ответа и др.</returns>
		Notification GetResponse(Response response);

		/// <summary>
		/// Номер сообщений 7 и 8
		/// </summary>
		/// <param name="response">К ранее направленному документу-ответу направляются дополнительные материалы.</param>
		/// <returns>Направляется информация о доставке и приеме сообщения, содержащего дополнения к документу-ответу, об ошибках приема и интерпретации сообщения и др.</returns>
		Notification ChangeResponse(ResponseSupplement response);
	}

	public partial class Service
	{
		/// <summary>
		/// Необходимость посылки уведомления (по умолчанию)
		/// </summary>
		private HeaderAsknowEnumType HeaderAsknowEnumTypeDefault = HeaderAsknowEnumType.none;


		// TODO: Добавьте свой код для обработки поступающих сообщений

		#region AddRequest

		partial void OnBeforeValidationRequest(Main request)
		{
			// TODO: Этот метод может быть удален
			// TODO: Добавьте код выполняемый перед проверкой полей полученного запроса
		}

		private Notification CreateNotification(Main request, List<AckResult> ackResult)
		{
			// TODO: Добавьте код выполняемый после проверки полей полученного запроса

			// TODO: Возможно, потребуется сохранить запрос в базу данных
			if (ackResult.Count == 0)
			{
				ackResult.AddRange(SaveToDb(request));
			}

			var notification = Notification.Init();

			// TODO: Необходимо сформировать ответ

			// Добавляем сообщения об ошибках (при необходимости часть можно поправить)
			notification.Acknowledgement.AckResult = ackResult;


			return notification;
		}

		private List<AckResult> SaveToDb(Main data)
		{
			return new List<AckResult>();
		}

		#endregion

		#region ChangeRequest

		partial void OnBeforeValidationRequest(MainSupplement request)
		{
			// TODO: Этот метод может быть удален
			// TODO: Добавьте код выполняемый перед проверкой полей полученного запроса
		}

		private Notification CreateNotification(MainSupplement request, List<AckResult> ackResult)
		{
			// TODO: Добавьте код выполняемый после проверки полей полученного запроса

			// TODO: Возможно, потребуется сохранить запрос в базу данных
			if ( ackResult.Count == 0 )
			{
				ackResult.AddRange(SaveToDb(request));
			}

			var notification = Notification.Init();

			// TODO: Необходимо сформировать ответ

			// Добавляем сообщения об ошибках (при необходимости часть можно поправить)
			notification.Acknowledgement.AckResult = ackResult;


			return notification;
		}

		private List<AckResult> SaveToDb(MainSupplement data)
		{
			return new List<AckResult>();
		}

		#endregion

		#region GetResponse

		partial void OnBeforeValidationRequest(Response request)
		{
			// TODO: Этот метод может быть удален
			// TODO: Добавьте код выполняемый перед проверкой полей полученного запроса
		}

		private Notification CreateNotification(Response response, List<AckResult> ackResult)
		{
			// TODO: Добавьте код выполняемый после проверки полей полученного запроса

			// TODO: Возможно, потребуется сохранить запрос в базу данных
			if ( ackResult.Count == 0 )
			{
				ackResult.AddRange(SaveToDb(response));
			}

			Main main = null;
			var result = LoadFromDb(response, out main);
			if ( result.Count == 0)
			{
				// TODO: Обрабатываем документ main
			}
			ackResult.AddRange(result);

			List<MainSupplement> supplements = null;
			result = LoadFromDb(response, out supplements);
			if ( result.Count == 0 )
			{
				// TODO: Обрабатываем документы supplements
			}
			ackResult.AddRange(result);

			var notification = Notification.Init();

			// TODO: Необходимо сформировать ответ

			// Добавляем сообщения об ошибках (при необходимости часть можно поправить)
			notification.Acknowledgement.AckResult = ackResult;


			return notification;
		}

		private List<AckResult> SaveToDb(Response data)
		{
			return new List<AckResult>();
		}

		private List<AckResult> LoadFromDb(Response data, out Main source)
		{
			source = new Main();
			return new List<AckResult>();
		}

		private List<AckResult> LoadFromDb(Response data, out List<MainSupplement> source)
		{
			source = new List<MainSupplement>();
			return new List<AckResult>();
		}

		#endregion

		#region ChangeResponse

		partial void OnBeforeValidationRequest(ResponseSupplement request)
		{
			// TODO: Этот метод может быть удален
			// TODO: Добавьте код выполняемый перед проверкой полей полученного запроса
		}

		private Notification CreateNotification(ResponseSupplement response, List<AckResult> ackResult)
		{
			// TODO: Добавьте код выполняемый после проверки полей полученного запроса

			// TODO: Возможно, потребуется сохранить запрос в базу данных
			if ( ackResult.Count == 0 )
			{
				ackResult.AddRange(SaveToDb(response));
			}

			Main main = null;
			var result = LoadFromDb(response, out main);
			if ( result.Count == 0 )
			{
				// TODO: Обрабатываем документ main
			}
			ackResult.AddRange(result);

			List<MainSupplement> supplements = null;
			result = LoadFromDb(response, out supplements);
			if ( result.Count == 0 )
			{
				// TODO: Обрабатываем документы supplements
			}
			ackResult.AddRange(result);

			var notification = Notification.Init();

			// TODO: Необходимо сформировать ответ

			// Добавляем сообщения об ошибках (при необходимости часть можно поправить)
			notification.Acknowledgement.AckResult = ackResult;


			return notification;
		}

		private List<AckResult> SaveToDb(ResponseSupplement data)
		{
			return new List<AckResult>();
		}

		private List<AckResult> LoadFromDb(ResponseSupplement data, out Main source)
		{
			source = new Main();
			return new List<AckResult>();
		}

		private List<AckResult> LoadFromDb(ResponseSupplement data, out List<MainSupplement> source)
		{
			source = new List<MainSupplement>();
			return new List<AckResult>();
		}

		#endregion
	}
}
