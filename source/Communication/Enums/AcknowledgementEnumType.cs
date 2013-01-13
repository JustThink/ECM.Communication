namespace ECM.Communication.Enums
{
	/// <summary>
	/// Вид уведомления
	/// </summary>
	public enum AcknowledgementEnumType : sbyte
	{
		/// <summary>
		/// уведомление о доставке и приеме сообщения;
		/// </summary>
		delivery_and_acceptance = 1,
		/// <summary>
		/// 2 - уведомление о регистрации документа в системе управления документами получателя
		/// </summary>
		registered = 2,
	}
}
