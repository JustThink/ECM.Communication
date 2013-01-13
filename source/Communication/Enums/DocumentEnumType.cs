namespace ECM.Communication.Enums
{
	/// <summary>
	/// Тип документа
	/// </summary>
	public enum DocumentEnumType : sbyte
	{
		/// <summary>
		/// Исходящий
		/// </summary>
		outbox = 0,
		/// <summary>
		/// Входящий
		/// </summary>
		inbox = 1,
		/// <summary>
		/// Внутренний
		/// </summary>
		inside = 2,

	}
}
