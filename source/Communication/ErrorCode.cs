namespace ECM.Communication
{
	/// <summary>
	/// Ошибки из перечня стандарта
	/// </summary>
	public interface IErrorCode
	{
		/// <summary>
		/// Код ошибки
		/// </summary>
		ulong errorcode { get; }

		/// <summary>
		/// Описание ошибки
		/// </summary>
		string Value { get; }
	}

	/// <summary>
	/// Ошибки из перечня стандарта: О доставке и приеме сообщения
	/// </summary>
	public class ErrorReceiptCode : IErrorCode
	{
		/// <summary>
		/// недопустимое значение атрибута 'Вид стандарта' в зоне «Заголовок»
		/// </summary>
		public static ErrorReceiptCode InvalidAttribute_Standard_in_Header_Format  = new ErrorReceiptCode() { errorcode = 1, Value = "недопустимое значение атрибута <{0}> в зоне «Заголовок»" }; // 0:Вид стандарта
		/// <summary>
		/// недопустимое значение атрибута 'Версия стандарта' в зоне «Заголовок»
		/// </summary>
		public static ErrorReceiptCode InvalidAttribute_Version_in_Header_Format = new ErrorReceiptCode() { errorcode = 2, Value = "недопустимое значение атрибута <{0}> в зоне «Заголовок»" }; // 0:Версия стандарта
		/// <summary>
		/// недопустимое значение атрибута 'Вид сообщения' в зоне «Заголовок»
		/// </summary>
		public static ErrorReceiptCode InvalidAttribute_MsgType_in_Header_Format = new ErrorReceiptCode() { errorcode = 3, Value = "недопустимое значение атрибута <{0}> в зоне «Заголовок»" }; // 0:Вид сообщения
		/// <summary>
		/// в зоне «Заголовок» получатель не определен
		/// </summary>
		public static ErrorReceiptCode NotDefined_Recipient_in_Header = new ErrorReceiptCode() { errorcode = 10, Value = "в зоне «Заголовок» получатель не определен" };
		/// <summary>
		/// в зоне «Заголовок» получатель не является организацией, осуществившей прием Сообщения
		/// </summary>
		public static ErrorReceiptCode Recipient_NotReceivedMsg_in_Header = new ErrorReceiptCode() { errorcode = 11, Value = "в зоне «Заголовок» получатель не является организацией, осуществившей прием Сообщения" };
		/// <summary>
		/// в Заголовке отсутствует обязательный атрибут 'Имя атрибут'
		/// </summary>
		public static ErrorReceiptCode MissingRequiredAttribute_in_Header_Format = new ErrorReceiptCode() { errorcode = 12, Value = "в Заголовке отсутствует обязательный атрибут <{0}>" }; // 0:Имя атрибут
		/// <summary>
		/// в сообщении отсутствует зона 'Имя зоны'
		/// </summary>
		public static ErrorReceiptCode MissingAreas_Format = new ErrorReceiptCode() { errorcode = 20, Value = "в сообщении отсутствует зона <{0}>" }; // 0:Имя зоны
		/// <summary>
		/// в сообщении присутствует недопустимый тип зоны (элемент 1-го уровня)
		/// </summary>
		public static ErrorReceiptCode ThereIsInvalidTypeAreas1Level = new ErrorReceiptCode() { errorcode = 21, Value = "в сообщении присутствует недопустимый тип зоны (элемент 1-го уровня)" };
		/// <summary>
		/// наличие нескольких зон 'Имя зоны' одного типа;
		/// </summary>
		public static ErrorReceiptCode MultipleAreas_Format  = new ErrorReceiptCode() { errorcode = 22, Value = "наличие нескольких зон <{0}> одного типа;" }; //0:Имя зоны
		/// <summary>
		/// зона 'Имя зоны' содержит недопустимые элементы
		/// </summary>
		public static ErrorReceiptCode ContainsInvalidElements_Format = new ErrorReceiptCode() { errorcode = 30, Value = "зона <{0}> содержит недопустимые элементы" }; // 0:Имя зоны
		/// <summary>
		/// неправильная вложенность элементов в элементе 'Имя элемента' зоны 'Имя зоны'
		/// </summary>
		public static ErrorReceiptCode IncorrectNestingOfElements_Format = new ErrorReceiptCode() { errorcode = 31, Value = "неправильная вложенность элементов в элементе <{0}> зоны <{1}>" }; //0:Имя элемента; 1:Имя зоны
		/// <summary>
		/// неверная кратность элемента 'Имя элемента' зоны 'Имя зоны'
		/// </summary>
		public static ErrorReceiptCode WrongMultiplicityOfElement_Format = new ErrorReceiptCode() { errorcode = 32, Value = "неверная кратность элемента <{0}> зоны <{1}>" }; //0:Имя элемента; 1:Имя зоны
		/// <summary>
		/// неверный тип данных атрибута 'Имя атрибута' элемента 'Имя элемента' зоны 'Имя зоны'
		/// </summary>
		public static ErrorReceiptCode WrongDataTypeAttribute_Format = new ErrorReceiptCode() { errorcode = 33, Value = "неверный тип данных атрибута <{0}> элемента <{1}> зоны <{2}>" }; //0:Имя атрибута; 1:Имя элемента; 2:Имя зоны
		/// <summary>
		/// неверный тип данных содержания элемента 'Имя элемента' зоны 'Имя зоны'
		/// </summary>
		public static ErrorReceiptCode WrongDataTypeElement_Format = new ErrorReceiptCode() { errorcode = 34, Value = "неверный тип данных содержания элемента <{0}> зоны <{1}>" }; //0:Имя элемента; 1:Имя зоны
		/// <summary>
		/// отсутствует обязательный атрибут 'Имя атрибута' элемента 'Имя элемента' зоны 'Имя зоны'
		/// </summary>
		public static ErrorReceiptCode MissingRequiredAttribute_Format = new ErrorReceiptCode() { errorcode = 35, Value = "отсутствует обязательный атрибут <{0}> элемента <{1}> зоны <{2}>" }; // 0:Имя атрибута; 1:Имя элемента; 2:Имя зоны
		/// <summary>
		/// ссылочная информация в зоне Document в полученном сообщении отличается от информации в зоне Document, ранее полученного сообщения
		/// </summary>
		public static ErrorReceiptCode WrongRefInDocument = new ErrorReceiptCode() { errorcode = 40, Value = "ссылочная информация в зоне Document в полученном сообщении отличается от информации в зоне Document, ранее полученного сообщения" };

		
		public ulong errorcode { get; private set; }
		public string Value { get; private set; }
		protected ErrorReceiptCode() {}
	}
	
	/// <summary>
	/// Ошибки из перечня стандарта: О регистрации документа
	/// </summary>
	public class ErrorRegistrationCode : IErrorCode
	{
		/// <summary>
		/// Документ относится к категории нерегистрируемых
		/// </summary>
		public static ErrorRegistrationCode DocumentIsNotRegistered = new ErrorRegistrationCode() { errorcode = 1, Value = "Документ относится к категории нерегистрируемых" };

		public ulong errorcode { get; private set; }
		public string Value { get; private set; }
		protected ErrorRegistrationCode() { }
	}
}
