using ECM.Communication.Documents;
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
		Notification ChangeResponse(Response response);
	}

	public partial class Service
	{
		/// <summary>
		/// Необходимость посылки уведомления (по умолчанию)
		/// </summary>
		private HeaderAsknowEnumType HeaderAsknowEnumTypeDefault = HeaderAsknowEnumType.none;


		// TODO: Добавьте свой код для обработки поступающих сообщений

		#region AddRequest

		partial void OnBeforeBuildNotification(Main request, Notification notification)
		{
			// TODO: Добавьте код изменяющий информацию о доставке сообщения
		}
		partial void OnBeforeValidationRequest(Main request)
		{
			// TODO: Добавьте код выполняемый перед проверкой полей полученного запроса
		}
		partial void OnAfterValidationRequest(Main request)
		{
			// TODO: Добавьте код выполняемый после проверки полей полученного запроса
		}
		partial void OnAfterBuildNotification(Main request, Notification notification)
		{
			// TODO: Добавьте код изменяющий информацию о доставке сообщения прошедшего валидацию
		}

		#endregion
	}
}
